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
    public partial class Form1 : Form
    {
        Directory directory;
        public Form1()
        {
            InitializeComponent();
            directory = new Directory();
            directory.FillTestData(100);
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
    }
}
