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
    public partial class AddUniversityForm : Form
    {
        public University University { set; get; }
        public AddUniversityForm()
        {
            InitializeComponent();
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
            University = new University
            {
                //+специальности
                Adress = adressBox.Text,
                Image = pictureBox1.Image,
                Name = nameBox.Text
            };
        }
    }
}
