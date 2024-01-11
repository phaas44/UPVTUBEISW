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
            this.TitleLabel.Location = new System.Drawing.Point(24, 58);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(24, 102);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // URILabel
            // 
            this.URILabel.AutoSize = true;
            this.URILabel.Location = new System.Drawing.Point(24, 145);
            this.URILabel.Name = "URILabel";
            this.URILabel.Size = new System.Drawing.Size(31, 17);
            this.URILabel.TabIndex = 2;
            this.URILabel.Text = "URI";
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(24, 250);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(113, 17);
            this.CoursesLabel.TabIndex = 3;
            this.CoursesLabel.Text = "Related Courses";
            // 
            // RestrictedLabel
            // 
            this.RestrictedLabel.AutoSize = true;
            this.RestrictedLabel.Location = new System.Drawing.Point(24, 197);
            this.RestrictedLabel.Name = "RestrictedLabel";
            this.RestrictedLabel.Size = new System.Drawing.Size(72, 17);
            this.RestrictedLabel.TabIndex = 4;
            this.RestrictedLabel.Text = "Restricted";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(188, 58);
            this.TitleInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(440, 22);
            this.TitleInput.TabIndex = 5;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(188, 100);
            this.DescriptionInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(440, 22);
            this.DescriptionInput.TabIndex = 6;
            // 
            // URIInput
            // 
            this.URIInput.Location = new System.Drawing.Point(188, 145);
            this.URIInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.URIInput.Name = "URIInput";
            this.URIInput.Size = new System.Drawing.Size(440, 22);
            this.URIInput.TabIndex = 7;
            // 
            // RestrictedCheckbox
            // 
            this.RestrictedCheckbox.AutoSize = true;
            this.RestrictedCheckbox.Location = new System.Drawing.Point(188, 197);
            this.RestrictedCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestrictedCheckbox.Name = "RestrictedCheckbox";
            this.RestrictedCheckbox.Size = new System.Drawing.Size(108, 21);
            this.RestrictedCheckbox.TabIndex = 8;
            this.RestrictedCheckbox.Text = "Is Restricted";
            this.RestrictedCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(575, 322);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 28);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add Content";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddContentButton_Click);
            // 
            // CoursesCheckBoxList
            // 
            this.CoursesCheckBoxList.FormattingEnabled = true;
            this.CoursesCheckBoxList.Location = new System.Drawing.Point(185, 258);
            this.CoursesCheckBoxList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoursesCheckBoxList.Name = "CoursesCheckBoxList";
            this.CoursesCheckBoxList.Size = new System.Drawing.Size(152, 89);
            this.CoursesCheckBoxList.TabIndex = 10;
            this.CoursesCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.CoursesCheckBoxList_SelectedIndexChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(348, 262);
            this.AddCourseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(104, 25);
            this.AddCourseButton.TabIndex = 11;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // UPVTubeUploadContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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