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
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                tbPath.Text = choofdlog.FileName;
            }
        }
    }
}
