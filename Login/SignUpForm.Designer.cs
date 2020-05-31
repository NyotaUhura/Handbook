namespace Login
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(132, 293);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 32);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(191, 84);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 22);
            this.nameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(191, 126);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(129, 22);
            this.passwordBox.TabIndex = 3;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox2.Location = new System.Drawing.Point(191, 211);
            this.passwordBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(129, 22);
            this.passwordBox2.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(12, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(58, 20);
            this.name.TabIndex = 5;
            this.name.Text = "Name:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(12, 126);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(88, 20);
            this.password.TabIndex = 6;
            this.password.Text = "Password:";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password2.Location = new System.Drawing.Point(12, 173);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(244, 20);
            this.password2.TabIndex = 7;
            this.password2.Text = "Please, confirm your password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "______________________________";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.okButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(394, 383);
            this.MinimumSize = new System.Drawing.Size(394, 383);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}