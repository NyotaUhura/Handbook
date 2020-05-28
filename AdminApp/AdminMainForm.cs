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
    //Главное окно администратора, которое отображает список всех университетов.
    public partial class AdminMainForm : Form
    {
        public Directory Directory;
        public Admin CurrentAdmin;
        public AdminMainForm(Directory directory, Admin admin)
        {
            Directory = directory;
            CurrentAdmin = admin;
            InitializeComponent();

            Directory.FillTestData(100);
            universityBindingSource.DataSource = directory.Universities;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.Load();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.Save();
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
                    Directory.Save();
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
                Directory.Universities.Add(auf.CurrentUniversity);
                universityBindingSource.ResetBindings(false);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = universitiyList.SelectedItem as University;
            var res = MessageBox.Show($"Delete {toDel.Name} ?", "Сonfirmation", MessageBoxButtons.YesNo);
            switch (res)
            {
                case DialogResult.Yes:
                    Directory.Universities.Remove(toDel);
                    universityBindingSource.ResetBindings(false);
                    break;
                case DialogResult.No:
                    break;
                
            }
        }
    }
}
