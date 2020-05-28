﻿using ApplicantsGuide.Models;
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
    //Главное окно студента, которое отбражает список избранных.
    public partial class HomeForm : Form
    {
        public Directory Directory;
        public Applicant CurrentApplicant;
        public HomeForm(Directory directory, Applicant applicant)
        {
            Directory = directory;
            CurrentApplicant = applicant;
            InitializeComponent();

            Directory.FillTestData(100);
            universityBindingSource.DataSource = applicant.Favorites;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var uf = new UniversitiesForm(CurrentApplicant.Favorites);
            if (uf.ShowDialog() == DialogResult.OK)
            {
                //foreach (University university in CurrentApplicant.Favorites)
                //{
                //    if (uf.currentUniversity.Name == university.Name)
                //        universityBindingSource.ResetBindings(false);
                //    else
                //    {
                        CurrentApplicant.Favorites.Add(uf.currentUniversity);
                        universityBindingSource.ResetBindings(false);
                //    }
                //}
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.favoriteGridView.SelectedRows.Count > 0)
            {
                var toDel = favoriteGridView.CurrentRow;
                var res = MessageBox.Show($"Delete university?", "Сonfirmation", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        favoriteGridView.Rows.RemoveAt(this.favoriteGridView.SelectedRows[0].Index);
                        universityBindingSource.ResetBindings(false);
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void favoriteList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
