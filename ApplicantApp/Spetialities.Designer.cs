namespace ApplicantApp
{
    partial class Spetialities
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
            this.components = new System.ComponentModel.Container();
            this.spetialityGridView = new System.Windows.Forms.DataGridView();
            this.spetialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFundedPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayPlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сorrespondencePlacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spetialityGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spetialityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spetialityGridView
            // 
            this.spetialityGridView.AllowUserToAddRows = false;
            this.spetialityGridView.AllowUserToDeleteRows = false;
            this.spetialityGridView.AllowUserToResizeColumns = false;
            this.spetialityGridView.AllowUserToResizeRows = false;
            this.spetialityGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.spetialityGridView.AutoGenerateColumns = false;
            this.spetialityGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.spetialityGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.spetialityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spetialityGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.contestDataGridViewTextBoxColumn,
            this.stateFundedPlacesDataGridViewTextBoxColumn,
            this.dayPlacesDataGridViewTextBoxColumn,
            this.сorrespondencePlacesDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn});
            this.spetialityGridView.DataSource = this.spetialityBindingSource;
            this.spetialityGridView.Location = new System.Drawing.Point(21, 37);
            this.spetialityGridView.Name = "spetialityGridView";
            this.spetialityGridView.ReadOnly = true;
            this.spetialityGridView.RowHeadersVisible = false;
            this.spetialityGridView.RowHeadersWidth = 51;
            this.spetialityGridView.RowTemplate.Height = 24;
            this.spetialityGridView.Size = new System.Drawing.Size(838, 348);
            this.spetialityGridView.TabIndex = 0;
            this.spetialityGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spetialityGridView_CellContentClick);
            // 
            // spetialityBindingSource
            // 
            this.spetialityBindingSource.DataSource = typeof(ApplicantsGuide.Models.Spetiality);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(876, 407);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // contestDataGridViewTextBoxColumn
            // 
            this.contestDataGridViewTextBoxColumn.DataPropertyName = "Contest";
            this.contestDataGridViewTextBoxColumn.HeaderText = "Contest";
            this.contestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contestDataGridViewTextBoxColumn.Name = "contestDataGridViewTextBoxColumn";
            this.contestDataGridViewTextBoxColumn.ReadOnly = true;
            this.contestDataGridViewTextBoxColumn.Width = 85;
            // 
            // stateFundedPlacesDataGridViewTextBoxColumn
            // 
            this.stateFundedPlacesDataGridViewTextBoxColumn.DataPropertyName = "StateFundedPlaces";
            this.stateFundedPlacesDataGridViewTextBoxColumn.HeaderText = "StateFundedPlaces";
            this.stateFundedPlacesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateFundedPlacesDataGridViewTextBoxColumn.Name = "stateFundedPlacesDataGridViewTextBoxColumn";
            this.stateFundedPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateFundedPlacesDataGridViewTextBoxColumn.Width = 160;
            // 
            // dayPlacesDataGridViewTextBoxColumn
            // 
            this.dayPlacesDataGridViewTextBoxColumn.DataPropertyName = "DayPlaces";
            this.dayPlacesDataGridViewTextBoxColumn.HeaderText = "DayPlaces";
            this.dayPlacesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayPlacesDataGridViewTextBoxColumn.Name = "dayPlacesDataGridViewTextBoxColumn";
            this.dayPlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayPlacesDataGridViewTextBoxColumn.Width = 104;
            // 
            // сorrespondencePlacesDataGridViewTextBoxColumn
            // 
            this.сorrespondencePlacesDataGridViewTextBoxColumn.DataPropertyName = "СorrespondencePlaces";
            this.сorrespondencePlacesDataGridViewTextBoxColumn.HeaderText = "СorrespondencePlaces";
            this.сorrespondencePlacesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.сorrespondencePlacesDataGridViewTextBoxColumn.Name = "сorrespondencePlacesDataGridViewTextBoxColumn";
            this.сorrespondencePlacesDataGridViewTextBoxColumn.ReadOnly = true;
            this.сorrespondencePlacesDataGridViewTextBoxColumn.Width = 184;
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "Places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "Places";
            this.placesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            this.placesDataGridViewTextBoxColumn.ReadOnly = true;
            this.placesDataGridViewTextBoxColumn.Width = 79;
            // 
            // Spetialities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 442);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.spetialityGridView);
            this.Name = "Spetialities";
            this.Text = "Spetialities";
            ((System.ComponentModel.ISupportInitialize)(this.spetialityGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spetialityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView spetialityGridView;
        private System.Windows.Forms.BindingSource spetialityBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFundedPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayPlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сorrespondencePlacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
    }
}