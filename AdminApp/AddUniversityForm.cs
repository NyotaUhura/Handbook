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
    //Форма добавления университета в справочник абитуриента.
    public partial class AddUniversityForm : Form
    {
        public University CurrentUniversity { set; get; }
        public AddUniversityForm()
        {
            InitializeComponent();

            CurrentUniversity = new University
            (
                adressBox.Text,
                nameBox.Text
            );

            spetialityBindingSource.DataSource = CurrentUniversity.Spetialities;
        }

        private void AddUniversityForm_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddUniversityForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void addSpetialitiesButton_Click(object sender, EventArgs e)
        {
            var asf = new AddSpetialityForm();
            if (asf.ShowDialog() == DialogResult.OK)
            {
                CurrentUniversity.Spetialities.Add(asf.currentSpetiality);
                spetialityBindingSource.ResetBindings(false);
            }
        }

        private void spetialitiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
