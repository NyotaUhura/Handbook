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
    public partial class AddSpetialityForm : Form
    {
        public Spetiality Spetiality { set; get; }
        public AddSpetialityForm()
        {
            InitializeComponent();
        }

        private void AddSpetialityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Spetiality = new Spetiality
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
