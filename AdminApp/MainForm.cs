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

namespace AdminApp
{
    public partial class MainForm : Form
    {
        Directory directory;
        public MainForm()
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auf = new AddUniversityForm();
            if (auf.ShowDialog() == DialogResult.OK)
            {
                directory.Universities.Add(auf.University);
            }
        }
    }
}
