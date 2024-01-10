namespace UPVTubeGUI
{
    partial class UPVTubeSearchForm
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.NickLabel = new System.Windows.Forms.Label();
            this.NickInput = new System.Windows.Forms.TextBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.CoursesCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.URI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(28, 27);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(83, 20);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start Date";
            this.StartDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(32, 61);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(280, 26);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(357, 61);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(280, 26);
            this.EndDatePicker.TabIndex = 3;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(353, 27);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(77, 20);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "End Date";
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Location = new System.Drawing.Point(721, 26);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(39, 20);
            this.NickLabel.TabIndex = 4;
            this.NickLabel.Text = "Nick";
            // 
            // NickInput
            // 
            this.NickInput.Location = new System.Drawing.Point(725, 61);
            this.NickInput.Name = "NickInput";
            this.NickInput.Size = new System.Drawing.Size(231, 26);
            this.NickInput.TabIndex = 5;
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(32, 163);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(231, 26);
            this.TitleInput.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(28, 128);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Title";
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(353, 128);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(68, 20);
            this.CoursesLabel.TabIndex = 8;
            this.CoursesLabel.Text = "Courses";
            // 
            // CoursesCheckBoxList
            // 
            this.CoursesCheckBoxList.FormattingEnabled = true;
            this.CoursesCheckBoxList.Location = new System.Drawing.Point(357, 163);
            this.CoursesCheckBoxList.Name = "CoursesCheckBoxList";
            this.CoursesCheckBoxList.Size = new System.Drawing.Size(171, 119);
            this.CoursesCheckBoxList.TabIndex = 11;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(596, 163);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 35);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URI,
            this.Title,
            this.Owner,
            this.UploadDate,
            this.Description});
            this.dataGridView1.DataSource = this.SearchbindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 376);
            this.dataGridView1.TabIndex = 13;
            // 
            // SearchbindingSource
            // 
            this.SearchbindingSource.CurrentChanged += new System.EventHandler(this.label1_Click);
            // 
            // URI
            // 
            this.URI.DataPropertyName = "ds_URI";
            this.URI.HeaderText = "URI";
            this.URI.MinimumWidth = 8;
            this.URI.Name = "URI";
            this.URI.ReadOnly = true;
            this.URI.Width = 150;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "ds_Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // Owner
            // 
            this.Owner.DataPropertyName = "ds_Owner";
            this.Owner.HeaderText = "Creator";
            this.Owner.MinimumWidth = 8;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 150;
            // 
            // UploadDate
            // 
            this.UploadDate.DataPropertyName = "ds_UploadDate";
            this.UploadDate.HeaderText = "Upload Date";
            this.UploadDate.MinimumWidth = 8;
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.ReadOnly = true;
            this.UploadDate.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "ds_Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // UPVTubeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 689);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CoursesCheckBoxList);
            this.Controls.Add(this.CoursesLabel);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NickInput);
            this.Controls.Add(this.NickLabel);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Name = "UPVTubeSearchForm";
            this.Text = "UPVTubeSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label NickLabel;
        private System.Windows.Forms.TextBox NickInput;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.CheckedListBox CoursesCheckBoxList;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource SearchbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn URI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}