namespace AdminApp
{
    partial class AddUniversityForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.adressBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.spetialities = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSpetialitiesButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.spetialitiesBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(116, 38);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(384, 22);
            this.nameBox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(35, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.Name_Click);
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress.Location = new System.Drawing.Point(35, 83);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(58, 17);
            this.adress.TabIndex = 3;
            this.adress.Text = "Adress";
            this.adress.Click += new System.EventHandler(this.label1_Click);
            // 
            // adressBox
            // 
            this.adressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adressBox.Location = new System.Drawing.Point(116, 83);
            this.adressBox.Name = "adressBox";
            this.adressBox.Size = new System.Drawing.Size(384, 22);
            this.adressBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(312, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 217);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(38, 370);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(101, 28);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(399, 370);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // spetialities
            // 
            this.spetialities.AutoSize = true;
            this.spetialities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spetialities.Location = new System.Drawing.Point(35, 135);
            this.spetialities.Name = "spetialities";
            this.spetialities.Size = new System.Drawing.Size(88, 17);
            this.spetialities.TabIndex = 8;
            this.spetialities.Text = "Spetialities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // addSpetialitiesButton
            // 
            this.addSpetialitiesButton.BackColor = System.Drawing.SystemColors.Control;
            this.addSpetialitiesButton.Location = new System.Drawing.Point(151, 129);
            this.addSpetialitiesButton.Name = "addSpetialitiesButton";
            this.addSpetialitiesButton.Padding = new System.Windows.Forms.Padding(2);
            this.addSpetialitiesButton.Size = new System.Drawing.Size(135, 28);
            this.addSpetialitiesButton.TabIndex = 10;
            this.addSpetialitiesButton.Text = "Add spetialities";
            this.addSpetialitiesButton.UseVisualStyleBackColor = false;
            // 
            // spetialitiesBox
            // 
            this.spetialitiesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spetialitiesBox.FormattingEnabled = true;
            this.spetialitiesBox.ItemHeight = 16;
            this.spetialitiesBox.Location = new System.Drawing.Point(38, 182);
            this.spetialitiesBox.Name = "spetialitiesBox";
            this.spetialitiesBox.Size = new System.Drawing.Size(248, 164);
            this.spetialitiesBox.TabIndex = 11;
            // 
            // AddUniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 420);
            this.Controls.Add(this.spetialitiesBox);
            this.Controls.Add(this.addSpetialitiesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spetialities);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.adressBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.Name = "AddUniversityForm";
            this.Text = "AddUniversityForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUniversityForm_FormClosing);
            this.Load += new System.EventHandler(this.AddUniversityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.TextBox adressBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label spetialities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSpetialitiesButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListBox spetialitiesBox;
    }
}