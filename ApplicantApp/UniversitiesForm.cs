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
    //Форма добавления университета в список избранных.
    public partial class UniversitiesForm : Form
    {
        Directory Directory;
        List<University> favorites;
        public University currentUniversity;
        public UniversitiesForm(List<University> universityList, Directory directory)
        {
            InitializeComponent();
            Directory = directory;

            universityBindingSource.DataSource = directory.Universities;
            favorites = universityList;
        }

        private void UniversitiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var un = (University)universityBindingSource.Current;
                    currentUniversity = un;
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        
    }
}
