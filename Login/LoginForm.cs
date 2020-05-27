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
        Directory directory;
        public loginForm()
        {
            directory = new Directory();
            if (!File.Exists("directory.bin"))
                directory.FillTestData(100);
            else
                directory.Load();
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            var suf = new SignUpForm();
            if (suf.ShowDialog() == DialogResult.OK)
            {
                //directory.Applicants.Add(suf.CurrentApplicant);
            }
        }
    }
}
