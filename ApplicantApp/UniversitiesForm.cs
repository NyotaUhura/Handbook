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
    public partial class UniversitiesForm : Form
    {
        Directory directory;
        public UniversitiesForm()
        {
            InitializeComponent();
            directory = new Directory();
            directory.FillTestData(100);
            universityBindingSource.DataSource = directory.Universities;
        }
    }
}
