namespace UPVTubeGUI
{
    partial class UPVTubeLoginForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SystemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateSampleDBStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDBStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(488, 270);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 60);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(29, 284);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(165, 46);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(284, 39);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(108, 17);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "UPVTube Login";
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NicknameText
            // 
            this.NicknameText.AutoSize = true;
            this.NicknameText.Location = new System.Drawing.Point(38, 90);
            this.NicknameText.Name = "NicknameText";
            this.NicknameText.Size = new System.Drawing.Size(70, 17);
            this.NicknameText.TabIndex = 3;
            this.NicknameText.Text = "Nickname";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(39, 137);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(69, 17);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Password";
            // 
            // NicknameInput
            // 
            this.NicknameInput.Location = new System.Drawing.Point(153, 86);
            this.NicknameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NicknameInput.Name = "NicknameInput";
            this.NicknameInput.Size = new System.Drawing.Size(432, 22);
            this.NicknameInput.TabIndex = 5;
            this.NicknameInput.TextChanged += new System.EventHandler(this.NicknameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(153, 137);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(432, 22);
            this.PasswordInput.TabIndex = 6;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(711, 28);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // SystemStrip
            // 
            this.SystemStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSampleDBStrip,
            this.DeleteDBStrip,
            this.ExitStrip});
            this.SystemStrip.Name = "SystemStrip";
            this.SystemStrip.Size = new System.Drawing.Size(70, 24);
            this.SystemStrip.Text = "System";
            // 
            // CreateSampleDBStrip
            // 
            this.CreateSampleDBStrip.Name = "CreateSampleDBStrip";
            this.CreateSampleDBStrip.Size = new System.Drawing.Size(247, 26);
            this.CreateSampleDBStrip.Text = "Create New Sample DB";
            this.CreateSampleDBStrip.Click += new System.EventHandler(this.CreateSampleDBStrip_Click);
            // 
            // DeleteDBStrip
            // 
            this.DeleteDBStrip.Name = "DeleteDBStrip";
            this.DeleteDBStrip.Size = new System.Drawing.Size(247, 26);
            this.DeleteDBStrip.Text = "Delete DB";
            this.DeleteDBStrip.Click += new System.EventHandler(this.DeleteDBStrip_Click);
            // 
            // ExitStrip
            // 
            this.ExitStrip.Name = "ExitStrip";
            this.ExitStrip.Size = new System.Drawing.Size(247, 26);
            this.ExitStrip.Text = "Exit";
            this.ExitStrip.Click += new System.EventHandler(this.ExitStrip_Click);
            // 
            // UPVTubeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NicknameInput);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.NicknameText);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UPVTubeLoginForm";
            this.Text = "UPVTubeApp";
            this.Load += new System.EventHandler(this.UPVTubeApp_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SystemStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateSampleDBStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteDBStrip;
    }
}

