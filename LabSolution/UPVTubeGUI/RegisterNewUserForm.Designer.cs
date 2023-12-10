namespace UPVTubeGUI
{
    partial class RegisterNewUserForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NicknameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(544, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(159, 41);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(63, 96);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(63, 152);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(63, 212);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(79, 20);
            this.NicknameLabel.TabIndex = 4;
            this.NicknameLabel.Text = "Nickname";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(63, 273);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(78, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(228, 98);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(474, 26);
            this.EmailInput.TabIndex = 6;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(228, 152);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(474, 26);
            this.NameInput.TabIndex = 7;
            // 
            // NicknameInput
            // 
            this.NicknameInput.Location = new System.Drawing.Point(228, 212);
            this.NicknameInput.Name = "NicknameInput";
            this.NicknameInput.Size = new System.Drawing.Size(474, 26);
            this.NicknameInput.TabIndex = 8;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(229, 273);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(474, 26);
            this.PasswordInput.TabIndex = 9;
            // 
            // RegisterNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NicknameInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddButton);
            this.Name = "RegisterNewUser";
            this.Text = "RegisterNewUser";
            this.Load += new System.EventHandler(this.RegisterNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox NicknameInput;
        private System.Windows.Forms.TextBox PasswordInput;
    }
}