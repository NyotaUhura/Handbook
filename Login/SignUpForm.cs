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

namespace Login
{
    public partial class SignUpForm : Form
    {
        public Applicant CurrentApplicant { set; get; }
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == passwordBox2.Text)
            {
                CurrentApplicant = new Applicant(
                nameBox.Text,
                passwordBox.Text
                );  
            }
            
        }
    }
}
