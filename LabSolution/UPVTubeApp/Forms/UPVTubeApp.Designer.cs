namespace UPVTube.Presentation.Forms
{
    partial class UPVTubeApp
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
            this.TitleLabel.Location = new System.Drawing.Point(27, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(27, 128);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            // 
            // URILabel
            // 
            this.URILabel.AutoSize = true;
            this.URILabel.Location = new System.Drawing.Point(27, 181);
            this.URILabel.Name = "URILabel";
            this.URILabel.Size = new System.Drawing.Size(38, 20);
            this.URILabel.TabIndex = 2;
            this.URILabel.Text = "URI";
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.Location = new System.Drawing.Point(27, 312);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(128, 20);
            this.CoursesLabel.TabIndex = 3;
            this.CoursesLabel.Text = "Related Courses";
            // 
            // RestrictedLabel
            // 
            this.RestrictedLabel.AutoSize = true;
            this.RestrictedLabel.Location = new System.Drawing.Point(27, 246);
            this.RestrictedLabel.Name = "RestrictedLabel";
            this.RestrictedLabel.Size = new System.Drawing.Size(82, 20);
            this.RestrictedLabel.TabIndex = 4;
            this.RestrictedLabel.Text = "Restricted";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(212, 73);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(495, 26);
            this.TitleInput.TabIndex = 5;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(212, 125);
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(495, 26);
            this.DescriptionInput.TabIndex = 6;
            // 
            // URIInput
            // 
            this.URIInput.Location = new System.Drawing.Point(212, 181);
            this.URIInput.Name = "URIInput";
            this.URIInput.Size = new System.Drawing.Size(495, 26);
            this.URIInput.TabIndex = 7;
            // 
            // RestrictedCheckbox
            // 
            this.RestrictedCheckbox.AutoSize = true;
            this.RestrictedCheckbox.Location = new System.Drawing.Point(212, 246);
            this.RestrictedCheckbox.Name = "RestrictedCheckbox";
            this.RestrictedCheckbox.Size = new System.Drawing.Size(125, 24);
            this.RestrictedCheckbox.TabIndex = 8;
            this.RestrictedCheckbox.Text = "Is Restrcited";
            this.RestrictedCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(647, 403);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(141, 35);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add Content";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddContentButton_Click);
            // 
            // CoursesCheckBoxList
            // 
            this.CoursesCheckBoxList.FormattingEnabled = true;
            this.CoursesCheckBoxList.Location = new System.Drawing.Point(208, 322);
            this.CoursesCheckBoxList.Name = "CoursesCheckBoxList";
            this.CoursesCheckBoxList.Size = new System.Drawing.Size(171, 119);
            this.CoursesCheckBoxList.TabIndex = 10;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(392, 327);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(117, 31);
            this.AddCourseButton.TabIndex = 11;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // UPVTubeUploadContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< Updated upstream:LabSolution/UPVTubeApp/Forms/UPVTubeApp.Designer.cs
            this.Text = "UPVTubeApp";
=======
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
            this.Name = "UPVTubeUploadContentForm";
            this.Text = "UPVTubeUploadContentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

>>>>>>> Stashed changes:LabSolution/UPVTubeGUI/UPVTubeUploadContentForm.Designer.cs
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