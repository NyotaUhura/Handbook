namespace ApplicantApp
{
    partial class UniversitiesForm
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
            this.universitiesGridView = new System.Windows.Forms.DataGridView();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universities = new System.Windows.Forms.Label();
            this.universitiesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // universitiesGridView
            // 
            this.universitiesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.universitiesGridView.AutoGenerateColumns = false;
            this.universitiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universitiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.universitiesGridView.DataSource = this.universityBindingSource;
            this.universitiesGridView.Location = new System.Drawing.Point(27, 80);
            this.universitiesGridView.Name = "universitiesGridView";
            this.universitiesGridView.RowHeadersWidth = 51;
            this.universitiesGridView.RowTemplate.Height = 24;
            this.universitiesGridView.Size = new System.Drawing.Size(264, 327);
            this.universitiesGridView.TabIndex = 0;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(ApplicantsGuide.Models.University);
            // 
            // universities
            // 
            this.universities.AutoSize = true;
            this.universities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.universities.Location = new System.Drawing.Point(27, 25);
            this.universities.Name = "universities";
            this.universities.Size = new System.Drawing.Size(150, 29);
            this.universities.TabIndex = 1;
            this.universities.Text = "Universities";
            // 
            // universitiesList
            // 
            this.universitiesList.DataSource = this.universityBindingSource;
            this.universitiesList.DisplayMember = "Name";
            this.universitiesList.FormattingEnabled = true;
            this.universitiesList.ItemHeight = 16;
            this.universitiesList.Location = new System.Drawing.Point(337, 80);
            this.universitiesList.Name = "universitiesList";
            this.universitiesList.Size = new System.Drawing.Size(316, 324);
            this.universitiesList.TabIndex = 2;
            // 
            // UniversitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 436);
            this.Controls.Add(this.universitiesList);
            this.Controls.Add(this.universities);
            this.Controls.Add(this.universitiesGridView);
            this.Name = "UniversitiesForm";
            this.Text = "Favorites";
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView universitiesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource universityBindingSource;
        private System.Windows.Forms.Label universities;
        private System.Windows.Forms.ListBox universitiesList;
    }
}