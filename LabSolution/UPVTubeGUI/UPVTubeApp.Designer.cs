namespace UPVTubeGUI
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NicknameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.NicknameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(549, 338);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(203, 75);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(33, 355);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(186, 57);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(310, 34);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(121, 20);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "UPVTube Login";
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NicknameText
            // 
            this.NicknameText.AutoSize = true;
            this.NicknameText.Location = new System.Drawing.Point(43, 113);
            this.NicknameText.Name = "NicknameText";
            this.NicknameText.Size = new System.Drawing.Size(79, 20);
            this.NicknameText.TabIndex = 3;
            this.NicknameText.Text = "Nickname";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(44, 171);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(78, 20);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Password";
            // 
            // NicknameInput
            // 
            this.NicknameInput.Location = new System.Drawing.Point(172, 107);
            this.NicknameInput.Name = "NicknameInput";
            this.NicknameInput.Size = new System.Drawing.Size(486, 26);
            this.NicknameInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(172, 171);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(486, 26);
            this.PasswordInput.TabIndex = 6;
            // 
            // UPVTubeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NicknameInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.NicknameText);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "UPVTubeApp";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.UPVTubeApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label NicknameText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.TextBox NicknameInput;
        private System.Windows.Forms.TextBox PasswordInput;
    }
}

