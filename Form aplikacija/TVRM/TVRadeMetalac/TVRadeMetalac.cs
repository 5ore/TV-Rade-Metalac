using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ServiceModel;
using System.Globalization;
using System.Data.SqlClient;

namespace TVRadeMetalac
{
    public partial class TVRadeMetalacForm : Form
    {

        public TVRadeMetalacForm()
        {
            InitializeComponent();
            GetMessages();
        }

        /// <summary>
        /// Called when user clicks on the 'btnClose' button, this method terminates the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Checks if the combo box for playing music is checked.
        /// If yes, the music either continues to play or starts for the first time, if unchecked the music stops.
        /// </summary>
        void Music(object sender, EventArgs e)
        {
            if (cbMusic.Checked)
            {
                if (tbPath.Text == string.Empty)
                {
                    MessageBox.Show("Putanja do foldera sa pesmama je prazna.");
                    return;
                }
                MediaManager.PlayMusic(tbPath.Text);
            }
            else
                MediaManager.StopMusic();
        }

        /// <summary>
        /// A YES/NO dialog box that returns true if the user presses the YES button and false otherwise.
        /// </summary>
        /// <returns>True for yes button; false for no.</returns>
        bool ReassureBox()
        {
                switch (MessageBox.Show("Da li ste sigurni?", "Pitanje", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        return true;
                    case DialogResult.No:
                        return false;
                }
            return false;
        }

        /// <summary>
        /// Opens the folder browser and lets the user choose a folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Resets the message the user wants to send to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteText_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }

        /// <summary>
        /// Calls for the next random song to play from the selected folder path (tbPath).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if(tbPath.Text == string.Empty)
            {
                MessageBox.Show("Putanja do foldera sa pesmama je prazna.");
            }
            else if(cbMusic.Checked)
                MediaManager.NewSong(tbPath.Text);
        }

        /// <summary>
        /// Pauses or resumes the current song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            MediaManager.ChangeMusicState();
        }

        /// <summary>
        /// Attempts to send the typed message with the start date and end date.
        /// If it passes through the validation the method 'InsertMessage' is then called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtbMessage.Text == string.Empty)
            {
                MessageBox.Show("Ne mozete poslati prazno obavestenje.");
                return;
            }
            if(dtpStart.Value < DateTime.Now)
            {
                MessageBox.Show("Datum pocetka obavestenja mora biti najranije danasnji datum.");
                return;
            }
            if(dtpEnd.Value < DateTime.Now)
            {
                MessageBox.Show("Datum brisanja obavestenja mora biti najranije danasnji datum.");
                return;
            }
            InsertMessage(rtbMessage.Text, dtpStart.Value, dtpEnd.Value);
        }

        /// <summary>
        /// Used as a click event to call the 'GetMessages' function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RefreshDataGrid(object sender, EventArgs e)
        {
            GetMessages();
        }

        /// <summary>
        /// The main method responsible for refreshing the data grid view from the database.
        /// </summary>
        private void GetMessages()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "SELECT ID,TEKST AS Obavestenje, DATUM_PRIKAZA AS [Datum prikaza], DATUM_BRISANJA AS [Datum brisanja] FROM Obavestenja", connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable("Obavestenja");
                    sqlDataAdapter.Fill(dataTable);
                    dgvObavestenja.DataSource = dataTable;
                    dgvObavestenja.Columns["ID"].Visible = false;
                    dgvObavestenja.Columns["Obavestenje"].Width = 380;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        
        /// <summary>
        /// Used to insert a new message in the table 'Obavestenja' with the following parameters.
        /// </summary>
        /// <param name="message">The string value of the message that needs to be stored.</param>
        /// <param name="startDate">The start date for when the message will be shown.</param>
        /// <param name="endDate">The end date for when the message will be deleted.</param>
        private void InsertMessage(string message,DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Obavestenja (TEKST, DATUM_PRIKAZA, DATUM_BRISANJA)" +
                        "VALUES (@TEKST, @DATUM_PRIKAZA, @DATUM_BRISANJA)", connection);
                    command.Parameters.AddWithValue("@TEKST", message);
                    command.Parameters.AddWithValue("@DATUM_PRIKAZA", startDate);
                    command.Parameters.AddWithValue("@DATUM_BRISANJA", endDate);
                    command.ExecuteNonQuery();
                    GetMessages();
                }
                UpdatedMessages();
                MessageBox.Show("Uspesno ste poslali obavestenje!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Lets the user update all selected rows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvObavestenja.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Morate odabrati barem jedan red u tabeli za izmenu.");
                return;
            }
            if(dgvObavestenja.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Trenutno nema nikakvih obavestenja.");
                return;
            }
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "UPDATE Obavestenja " +
                        "SET TEKST = @TEKST, DATUM_PRIKAZA = @DATUM_PRIKAZA, DATUM_BRISANJA = @DATUM_BRISANJA " +
                        "WHERE ID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.Int);
                    command.Parameters.Add("@TEKST", SqlDbType.NVarChar);
                    command.Parameters.Add("@DATUM_PRIKAZA", SqlDbType.DateTime);
                    command.Parameters.Add("@DATUM_BRISANJA", SqlDbType.DateTime);
                    foreach (DataGridViewRow row in dgvObavestenja.SelectedRows)
                    {
                        command.Parameters["@ID"].Value = row.Cells["ID"].Value;
                        Message newMessage =
                            UserInputDialog.ShowDialog(
                                "Novo obavestenje:",
                                "Datum pocetka prikaza:",
                                "Datum brisanja:",
                                (row.Cells["Obavestenje"].Value.ToString().Length >= 30) ?
                                (row.Cells["Obavestenje"].Value.ToString().Substring(0, 30) + "...") :
                                row.Cells["Obavestenje"].Value.ToString());
                        if (newMessage != null)
                        {
                            command.Parameters["@TEKST"].Value = newMessage.Content;
                            command.Parameters["@DATUM_PRIKAZA"].Value = newMessage.StartDate;
                            command.Parameters["@DATUM_BRISANJA"].Value = newMessage.EndDate;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Uspesno ste izmenili obavestenja!");
                            UpdatedMessages();
                            GetMessages();
                        }
                        else
                        {
                            MessageBox.Show("Izmena izabranih obaveštenja je prekinuta.");
                            break;
                        }    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Used for deleting messages in the SQL database and data grid view component (dgvObavestenja).
        /// </summary>
        void DeleteSelectedMessages(object sender, EventArgs e)
        {
            if (dgvObavestenja.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Morate odabrati barem jedan red u tabeli za brisanje.");
                return;
            }
            if(dgvObavestenja.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Trenutno nema nikakvih obavestenja.");
                return;
            }
            if (!ReassureBox())
                return;
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Obavestenja WHERE ID = @ID", connection);
                    command.Parameters.Add("@ID", SqlDbType.Int);
                    foreach (DataGridViewRow row in dgvObavestenja.SelectedRows)
                    {
                        command.Parameters["@ID"].Value = row.Cells["ID"].Value;
                        command.ExecuteNonQuery();
                    }
                    GetMessages();
                }
                UpdatedMessages();
                MessageBox.Show("Uspesno ste obrisali obavestenja!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Sends notification to the database about the change of class types depending on the checked control.(30min or 45min)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SwitchClassType(object sender, EventArgs e)
        {
            try
            {
                byte result = (rbNormal.Checked) ? (byte)0 : (byte)1;
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "UPDATE Novosti SET Rezim30 = " + result.ToString(),connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Send the database a notification that the messages have been modified.
        /// </summary>
        void UpdatedMessages()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Novosti SET Obavestenja = 1",connection);
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region AdministrativeCode
        void KeyCodeAdminOptions(object sender, KeyEventArgs e)
        {
            if(e.Control && e.Shift && e.Alt && e.KeyCode == Keys.Multiply)
            {
                AdminPrompt adminPrompt = new AdminPrompt();
            }
        }
        void _TEMP_TestMethod(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(
                        "SELECT * FROM Novosti", connection);
                    using (SqlDataAdapter sqlDataReader = new SqlDataAdapter(command))
                    {
                        string values = "";
                        DataTable dataTable = new DataTable("Novosti");
                        sqlDataReader.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                values += cell.ToString() + " ";
                            }
                        }
                        MessageBox.Show(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
