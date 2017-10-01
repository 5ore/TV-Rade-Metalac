using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVRadeMetalac
{
    public partial class AdminPrompt : Form
    {
        public AdminPrompt()
        {
            InitializeComponent();
        }

        private void btnResetMessageUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Novosti SET Obavestenja = 0", connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetClassTypeUpdates_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TVRMConnectionString"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Novosti SET Rezim30 = 0");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            btnResetMessageUpdates.PerformClick();
            btnResetClassTypeUpdates.PerformClick();
        }
    }
}
