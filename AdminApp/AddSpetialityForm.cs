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
        
        
        public AddSpetialityForm()
        {
            InitializeComponent();
        }

        private void AddSpetialityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            currentSpetiality = new Spetiality
            (
                nameBox.Text,
                priceBox.Value,
                contestBox.Value,
                stateFundedPlacesBox.Value,
                dayPlacesBox.Value,
                correspondancePlacesBox.Value
            );
        }
    }
}
