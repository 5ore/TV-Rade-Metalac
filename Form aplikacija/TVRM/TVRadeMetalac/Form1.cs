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

namespace TVRadeMetalac
{
    public partial class TVRadeMetalacForm : Form
    {
        public TVRadeMetalacForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            switch (ReassureBox())
            {
                case true:
                    ApplyChanges();
                    break;
                case false:
                    return;
            }
        }

        void ApplyChanges()
        {
            Music();
            //ClassType();
            //DeleteTexts();
        }

        void Music()
        {
            if (cbMusic.Checked)
                MediaManager.PlayMusic(tbPath.Text);
            else
                MediaManager.StopMusic();
        }

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

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDeleteText_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if(tbPath.Text == string.Empty)
            {
                MessageBox.Show("Putanja do foldera sa pesmama je prazna.");
            }
            if(cbMusic.Checked)
                MediaManager.NewSong(tbPath.Text);
        }
    }
}
