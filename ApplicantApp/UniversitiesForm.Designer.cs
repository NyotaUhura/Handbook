﻿namespace ApplicantApp
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // universitiesGridView
            // 
            this.universitiesGridView.AllowUserToAddRows = false;
            this.universitiesGridView.AllowUserToDeleteRows = false;
            this.universitiesGridView.AllowUserToOrderColumns = true;
            this.universitiesGridView.AllowUserToResizeColumns = false;
            this.universitiesGridView.AllowUserToResizeRows = false;
            this.universitiesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.universitiesGridView.AutoGenerateColumns = false;
            this.universitiesGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.universitiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universitiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.universitiesGridView.DataSource = this.universityBindingSource;
            this.universitiesGridView.Location = new System.Drawing.Point(32, 61);
            this.universitiesGridView.MultiSelect = false;
            this.universitiesGridView.Name = "universitiesGridView";
            this.universitiesGridView.ReadOnly = true;
            this.universitiesGridView.RowHeadersVisible = false;
            this.universitiesGridView.RowHeadersWidth = 51;
            this.universitiesGridView.RowTemplate.Height = 24;
            this.universitiesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.universitiesGridView.Size = new System.Drawing.Size(428, 354);
            this.universitiesGridView.TabIndex = 0;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Name";
            this.adressDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 300;
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
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.Location = new System.Drawing.Point(32, 463);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 28);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(360, 463);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // UniversitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 503);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.universities);
            this.Controls.Add(this.universitiesGridView);
            this.MinimumSize = new System.Drawing.Size(510, 550);
            this.Name = "UniversitiesForm";
            this.Text = "Universities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UniversitiesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.universitiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView universitiesGridView;
        private System.Windows.Forms.BindingSource universityBindingSource;
        private System.Windows.Forms.Label universities;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}