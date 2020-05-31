using AdminApp;
using ApplicantApp;
using ApplicantsGuide.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Directory = ApplicantsGuide.Models.Directory;

namespace Login
{
    public partial class loginForm : Form
    {
        public Directory Directory;
        public Admin Admin;
        public Applicant Applicant;

        public loginForm()
        {
            Directory = new Directory();
            Admin = new Admin("admin", "admin");
            if (!File.Exists("directory.bin"))
                Directory.FillTestData(100);
            else
                Directory.Load();
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            var suf = new SignUpForm(Directory);
            suf.Show();
                //Directory.Applicants.Add(suf.CurrentApplicant);
                //Directory.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void SignIn_Click(object sender, EventArgs e)
        {
            
        }

        private void CheckAdmin()
        {
            if (nameBox.Text == Admin.Name && passwordBox.Text == Admin.Password)
            {
                var adminApp = new AdminMainForm(Directory, Admin);
                this.Hide();
                adminApp.ShowDialog();
                
                this.Close();
            }
        }

        private void CheckApplicant()
        {
            if (nameBox.Text != string.Empty && passwordBox.Text != string.Empty)
            {
                foreach (var applicant in Directory.Applicants)
                {
                    if (nameBox.Text == applicant.Name)
                    {
                        if (passwordBox.Text == applicant.Password)
                        {
                            var applicantApp = new HomeForm(Directory, applicant);
                            this.Hide();
                            applicantApp.ShowDialog();

                            this.Close();
                            return;
                        }
                    }
                    //else MessageBox.Show("Wrong password. Try it again.");
                }
            }
            //MessageBox.Show("All fields are required.");
        }



        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Directory.Save();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            CheckAdmin();
            CheckApplicant();
        }
    }
}
