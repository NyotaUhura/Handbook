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

        public Spetiality currentSpetiality { set; get; }
        List<Spetiality> spetialities;
        
        public AddSpetialityForm(University currentUniversity)
        {
            InitializeComponent();
            //spetialities = currentUniversity.Spetialities;
        }

        private void AddSpetialityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            currentSpetiality = new Spetiality
            {
                Name = nameBox.Text,
                Price = priceBox.Value,
                Contest = contestBox.Value,
                StateFundedPlaces = stateFundedPlacesBox.Value,
                DayPlaces = dayPlacesBox.Value,
                СorrespondencePlaces = correspondancePlacesBox.Value
            };
        }
    }
}
