﻿namespace Login
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(30, 220);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(175, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 22);
            this.nameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(121, 75);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(129, 22);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox2.Location = new System.Drawing.Point(121, 152);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(129, 22);
            this.passwordBox2.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(12, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 17);
            this.name.TabIndex = 5;
            this.name.Text = "Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(12, 78);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 17);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password2.Location = new System.Drawing.Point(12, 118);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(230, 17);
            this.password2.TabIndex = 7;
            this.password2.Text = "Please, confirm your password";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(282, 266);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximumSize = new System.Drawing.Size(300, 313);
            this.MinimumSize = new System.Drawing.Size(300, 313);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label password2;
    }
}