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
        //FavoritesList favoritesList;
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uf = new UniversitiesForm();
            if (uf.ShowDialog() == DialogResult.OK)
            {
                //directory.FavoritesList.Favorites.Add(uf.University);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = favoriteList.SelectedItem as University;
            MessageBox.Show($"Delete {toDel.Name} ?");
            //directory.FavoritesList.Universities.Remove(toDel);
            universityBindingSource.ResetBindings(false);
        }
    }
}
