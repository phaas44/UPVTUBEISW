namespace UPVTubeGUI
{
    partial class NewSubjectForm
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
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CodeInput = new System.Windows.Forms.TextBox();
            this.FullNameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(601, 386);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(187, 52);
            this.AddSubjectButton.TabIndex = 0;
            this.AddSubjectButton.Text = "Add Subject";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(41, 78);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(47, 20);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "Code";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(41, 136);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(80, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(41, 191);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // CodeInput
            // 
            this.CodeInput.Location = new System.Drawing.Point(182, 80);
            this.CodeInput.Name = "CodeInput";
            this.CodeInput.Size = new System.Drawing.Size(419, 26);
            this.CodeInput.TabIndex = 4;
            // 
            // FullNameInput
            // 
            this.FullNameInput.Location = new System.Drawing.Point(182, 136);
            this.FullNameInput.Name = "FullNameInput";
            this.FullNameInput.Size = new System.Drawing.Size(419, 26);
            this.FullNameInput.TabIndex = 5;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(182, 203);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(419, 26);
            this.NameInput.TabIndex = 6;
            // 
            // NewSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.FullNameInput);
            this.Controls.Add(this.CodeInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.AddSubjectButton);
            this.Name = "NewSubjectForm";
            this.Text = "NewSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CodeInput;
        private System.Windows.Forms.TextBox FullNameInput;
        private System.Windows.Forms.TextBox NameInput;
    }
}