namespace AdminApp
{
    partial class AddSpetialityForm
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
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.contest = new System.Windows.Forms.Label();
            this.stateFundedPlaces = new System.Windows.Forms.Label();
            this.dayPlaces = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.correspondencePlaces = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.contestBox = new System.Windows.Forms.NumericUpDown();
            this.stateFundedPlacesBox = new System.Windows.Forms.NumericUpDown();
            this.dayPlacesBox = new System.Windows.Forms.NumericUpDown();
            this.correspondancePlacesBox = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateFundedPlacesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPlacesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondancePlacesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(158, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(162, 71);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(45, 17);
            this.price.TabIndex = 1;
            this.price.Text = "Price";
            // 
            // contest
            // 
            this.contest.AutoSize = true;
            this.contest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contest.Location = new System.Drawing.Point(144, 115);
            this.contest.Name = "contest";
            this.contest.Size = new System.Drawing.Size(63, 17);
            this.contest.TabIndex = 2;
            this.contest.Text = "Contest";
            // 
            // stateFundedPlaces
            // 
            this.stateFundedPlaces.AutoSize = true;
            this.stateFundedPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateFundedPlaces.Location = new System.Drawing.Point(48, 160);
            this.stateFundedPlaces.Name = "stateFundedPlaces";
            this.stateFundedPlaces.Size = new System.Drawing.Size(159, 17);
            this.stateFundedPlaces.TabIndex = 3;
            this.stateFundedPlaces.Text = "State-Funded Places";
            // 
            // dayPlaces
            // 
            this.dayPlaces.AutoSize = true;
            this.dayPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayPlaces.Location = new System.Drawing.Point(118, 208);
            this.dayPlaces.Name = "dayPlaces";
            this.dayPlaces.Size = new System.Drawing.Size(89, 17);
            this.dayPlaces.TabIndex = 4;
            this.dayPlaces.Text = "Day Places";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(423, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // correspondencePlaces
            // 
            this.correspondencePlaces.AutoSize = true;
            this.correspondencePlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correspondencePlaces.Location = new System.Drawing.Point(27, 254);
            this.correspondencePlaces.Name = "correspondencePlaces";
            this.correspondencePlaces.Size = new System.Drawing.Size(180, 17);
            this.correspondencePlaces.TabIndex = 6;
            this.correspondencePlaces.Text = "Correspondence Places";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(237, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 22);
            this.nameBox.TabIndex = 7;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.Location = new System.Drawing.Point(237, 71);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(300, 22);
            this.priceBox.TabIndex = 8;
            // 
            // contestBox
            // 
            this.contestBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contestBox.Location = new System.Drawing.Point(237, 115);
            this.contestBox.Name = "contestBox";
            this.contestBox.Size = new System.Drawing.Size(300, 22);
            this.contestBox.TabIndex = 9;
            // 
            // stateFundedPlacesBox
            // 
            this.stateFundedPlacesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateFundedPlacesBox.Location = new System.Drawing.Point(237, 160);
            this.stateFundedPlacesBox.Name = "stateFundedPlacesBox";
            this.stateFundedPlacesBox.Size = new System.Drawing.Size(300, 22);
            this.stateFundedPlacesBox.TabIndex = 10;
            // 
            // dayPlacesBox
            // 
            this.dayPlacesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayPlacesBox.Location = new System.Drawing.Point(237, 208);
            this.dayPlacesBox.Name = "dayPlacesBox";
            this.dayPlacesBox.Size = new System.Drawing.Size(300, 22);
            this.dayPlacesBox.TabIndex = 11;
            // 
            // correspondancePlacesBox
            // 
            this.correspondancePlacesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correspondancePlacesBox.Location = new System.Drawing.Point(237, 252);
            this.correspondancePlacesBox.Name = "correspondancePlacesBox";
            this.correspondancePlacesBox.Size = new System.Drawing.Size(300, 22);
            this.correspondancePlacesBox.TabIndex = 12;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(51, 327);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(94, 30);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // AddSpetialityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 369);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.correspondancePlacesBox);
            this.Controls.Add(this.dayPlacesBox);
            this.Controls.Add(this.stateFundedPlacesBox);
            this.Controls.Add(this.contestBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.correspondencePlaces);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dayPlaces);
            this.Controls.Add(this.stateFundedPlaces);
            this.Controls.Add(this.contest);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Name = "AddSpetialityForm";
            this.Text = "AddSpetialityForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSpetialityForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contestBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateFundedPlacesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayPlacesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correspondancePlacesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label contest;
        private System.Windows.Forms.Label stateFundedPlaces;
        private System.Windows.Forms.Label dayPlaces;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label correspondencePlaces;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown contestBox;
        private System.Windows.Forms.NumericUpDown stateFundedPlacesBox;
        private System.Windows.Forms.NumericUpDown dayPlacesBox;
        private System.Windows.Forms.NumericUpDown correspondancePlacesBox;
        private System.Windows.Forms.Button okButton;
    }
}