using ApplicantsGuide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantApp
{
    public partial class HomeForm : Form
    {
        Directory directory;
        public HomeForm()
        {
            InitializeComponent();
            directory = new Directory();
            directory.FillTestData(100);
            universityBindingSource.DataSource = directory.Universities;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directory.Load();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directory.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    directory.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
