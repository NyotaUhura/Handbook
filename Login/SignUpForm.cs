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
        public Directory Directory;
        public SignUpForm(Directory directory)
        {
            InitializeComponent();
            Directory = directory;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != string.Empty && passwordBox.Text != string.Empty &&
                            passwordBox2.Text != string.Empty)
            {
                if (passwordBox.Text == passwordBox2.Text)
                {
                    if (nameBox.Text == "admin")
                    {
                        MessageBox.Show("Please, change your name.", "Error", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        CurrentApplicant = new Applicant(
                        nameBox.Text,
                        passwordBox.Text
                        );

                        Directory.Applicants.Add(CurrentApplicant);
                        Directory.Save();
                        this.Close();                    }
                }
                else
                {
                    MessageBox.Show("Wrong password. Try it again.", "Error", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OKCancel);
            }

            //Directory.Save();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (nameBox.Text != string.Empty && passwordBox.Text != string.Empty &&
            //                passwordBox2.Text != string.Empty)
            //{
            //    if (passwordBox.Text == passwordBox2.Text)
            //    {
            //        if (nameBox.Text == "admin")
            //        {
            //            MessageBox.Show("Please, change your name.");
            //            e.Cancel = true;
            //        }
            //        else
            //        {
            //            CurrentApplicant = new Applicant(
            //            nameBox.Text,
            //            passwordBox.Text
            //            );
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong password. Try it again.");
            //        e.Cancel = true;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("All fields are required.");
            //    e.Cancel = true;
            //}
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
