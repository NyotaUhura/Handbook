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
    //Форма добавления специальности выбраному университету.
    public partial class AddSpetialityForm : Form
    {

        public Spetiality CurrentSpetiality { set; get; }
        
        public AddSpetialityForm()
        {
            InitializeComponent();
            CurrentSpetiality = new Spetiality();
        }

        private void AddSpetialityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nameBox.Text != string.Empty)
            {
                CurrentSpetiality.Name = nameBox.Text;
                CurrentSpetiality.Price = priceBox.Value;
                CurrentSpetiality.Contest = contestBox.Value;
                CurrentSpetiality.StateFundedPlaces = stateFundedPlacesBox.Value;
                CurrentSpetiality.DayPlaces = dayPlacesBox.Value;
                CurrentSpetiality.СorrespondencePlaces = correspondancePlacesBox.Value;
                CurrentSpetiality.Places = dayPlacesBox.Value + correspondancePlacesBox.Value;
            }
            else
            {
                MessageBox.Show("All fields are required.");
                e.Cancel = true;
            }
}

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
