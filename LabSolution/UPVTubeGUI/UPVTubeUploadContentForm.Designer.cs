namespace UPVTubeGUI
{
    partial class UPVTubeUploadContentForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.URILabel = new System.Windows.Forms.Label();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.RestrictedLabel = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.URIInput = new System.Windows.Forms.TextBox();
            this.RestrictedCheckbox = new System.Windows.Forms.CheckBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CoursesCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(18, 47);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(18, 83);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // URILabel
            // 
            this.URILabel.AutoSize = true;
            this.URILabel.Location = new System.Drawing.Point(18, 118);
            this.URILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URILabel.Name = "URILabel";
            this.URILabel.Size = new System.Drawing.Size(26, 13);
            this.URILabel.TabIndex = 2;
            this.URILabel.Text = "URI";
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(18, 203);
            this.CoursesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(85, 13);
            this.CoursesLabel.TabIndex = 3;
            this.CoursesLabel.Text = "Related Courses";
            // 
            // RestrictedLabel
            // 
            this.RestrictedLabel.AutoSize = true;
            this.RestrictedLabel.Location = new System.Drawing.Point(18, 160);
            this.RestrictedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RestrictedLabel.Name = "RestrictedLabel";
            this.RestrictedLabel.Size = new System.Drawing.Size(55, 13);
            this.RestrictedLabel.TabIndex = 4;
            this.RestrictedLabel.Text = "Restricted";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(141, 47);
            this.TitleInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(331, 20);
            this.TitleInput.TabIndex = 5;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(141, 81);
            this.DescriptionInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(331, 20);
            this.DescriptionInput.TabIndex = 6;
            // 
            // URIInput
            // 
            this.URIInput.Location = new System.Drawing.Point(141, 118);
            this.URIInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.URIInput.Name = "URIInput";
            this.URIInput.Size = new System.Drawing.Size(331, 20);
            this.URIInput.TabIndex = 7;
            // 
            // RestrictedCheckbox
            // 
            this.RestrictedCheckbox.AutoSize = true;
            this.RestrictedCheckbox.Location = new System.Drawing.Point(141, 160);
            this.RestrictedCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestrictedCheckbox.Name = "RestrictedCheckbox";
            this.RestrictedCheckbox.Size = new System.Drawing.Size(85, 17);
            this.RestrictedCheckbox.TabIndex = 8;
            this.RestrictedCheckbox.Text = "Is Restricted";
            this.RestrictedCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(431, 262);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add Content";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddContentButton_Click);
            // 
            // CoursesCheckBoxList
            // 
            this.CoursesCheckBoxList.FormattingEnabled = true;
            this.CoursesCheckBoxList.Location = new System.Drawing.Point(139, 209);
            this.CoursesCheckBoxList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CoursesCheckBoxList.Name = "CoursesCheckBoxList";
            this.CoursesCheckBoxList.Size = new System.Drawing.Size(115, 79);
            this.CoursesCheckBoxList.TabIndex = 10;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(261, 213);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(78, 20);
            this.AddCourseButton.TabIndex = 11;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // UPVTubeUploadContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.CoursesCheckBoxList);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RestrictedCheckbox);
            this.Controls.Add(this.URIInput);
            this.Controls.Add(this.DescriptionInput);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.RestrictedLabel);
            this.Controls.Add(this.CoursesLabel);
            this.Controls.Add(this.URILabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UPVTubeUploadContentForm";
            this.Text = "UPVTubeUploadContentForm";
            this.Load += new System.EventHandler(this.UPVTubeUploadContentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label URILabel;
        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Label RestrictedLabel;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.TextBox URIInput;
        private System.Windows.Forms.CheckBox RestrictedCheckbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckedListBox CoursesCheckBoxList;
        private System.Windows.Forms.Button AddCourseButton;
    }
}