using ApplicantsGuide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantApp
{
    public partial class Spetialities : Form
    {
        public University CurrentUniversity { set; get; }
        public Spetialities(University university)
        {
            InitializeComponent();
            CurrentUniversity = university;
            spetialityBindingSource.DataSource = CurrentUniversity.Spetialities;
        }

        private void spetialityGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
