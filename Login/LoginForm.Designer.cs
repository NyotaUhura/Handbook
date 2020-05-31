namespace Login
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(158, 55);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(165, 22);
            this.nameBox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(86, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(58, 101);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(83, 20);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line.Location = new System.Drawing.Point(62, 231);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(293, 17);
            this.line.TabIndex = 3;
            this.line.Text = "________________or__________________";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.SlateGray;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.nextButton.Location = new System.Drawing.Point(89, 158);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(221, 70);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(158, 101);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(165, 22);
            this.passwordBox.TabIndex = 6;
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.SystemColors.Window;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.signUp.Location = new System.Drawing.Point(118, 263);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(163, 38);
            this.signUp.TabIndex = 7;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(402, 333);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.line);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.MaximumSize = new System.Drawing.Size(420, 380);
            this.MinimumSize = new System.Drawing.Size(420, 380);
            this.Name = "loginForm";
            this.Text = "Sign In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signUp;
    }
}

