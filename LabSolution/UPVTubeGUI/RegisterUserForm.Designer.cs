namespace UPVTubeGUI
{
    partial class RegisterUserForm
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
            this.nickTextbox = new System.Windows.Forms.TextBox();
            this.Nick_lable = new System.Windows.Forms.Label();
            this.Password_lable = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.E_mail_lable = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.Full_name_lable = new System.Windows.Forms.Label();
            this.fullNameTextbox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReenterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nickTextbox
            // 
            this.nickTextbox.Location = new System.Drawing.Point(122, 232);
            this.nickTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nickTextbox.Name = "nickTextbox";
            this.nickTextbox.Size = new System.Drawing.Size(258, 22);
            this.nickTextbox.TabIndex = 0;
            // 
            // Nick_lable
            // 
            this.Nick_lable.AutoSize = true;
            this.Nick_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick_lable.Location = new System.Drawing.Point(117, 199);
            this.Nick_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nick_lable.Name = "Nick_lable";
            this.Nick_lable.Size = new System.Drawing.Size(51, 29);
            this.Nick_lable.TabIndex = 1;
            this.Nick_lable.Text = "Nick";
            this.Nick_lable.Click += new System.EventHandler(this.Nick_lable_Click);
            // 
            // Password_lable
            // 
            this.Password_lable.AutoSize = true;
            this.Password_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lable.Location = new System.Drawing.Point(117, 282);
            this.Password_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_lable.Name = "Password_lable";
            this.Password_lable.Size = new System.Drawing.Size(101, 29);
            this.Password_lable.TabIndex = 3;
            this.Password_lable.Text = "Password";
            this.Password_lable.Click += new System.EventHandler(this.Password_lable_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(122, 315);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(258, 22);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // E_mail_lable
            // 
            this.E_mail_lable.AutoSize = true;
            this.E_mail_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_mail_lable.Location = new System.Drawing.Point(117, 107);
            this.E_mail_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.E_mail_lable.Name = "E_mail_lable";
            this.E_mail_lable.Size = new System.Drawing.Size(68, 29);
            this.E_mail_lable.TabIndex = 5;
            this.E_mail_lable.Text = "E-mail";
            this.E_mail_lable.Click += new System.EventHandler(this.E_mail_lable_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(122, 140);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(258, 22);
            this.emailTextbox.TabIndex = 4;
            // 
            // Full_name_lable
            // 
            this.Full_name_lable.AutoSize = true;
            this.Full_name_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_name_lable.Location = new System.Drawing.Point(117, 23);
            this.Full_name_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Full_name_lable.Name = "Full_name_lable";
            this.Full_name_lable.Size = new System.Drawing.Size(101, 29);
            this.Full_name_lable.TabIndex = 7;
            this.Full_name_lable.Text = "Full Name";
            this.Full_name_lable.Click += new System.EventHandler(this.Full_name_lable_Click);
            // 
            // fullNameTextbox
            // 
            this.fullNameTextbox.Location = new System.Drawing.Point(122, 56);
            this.fullNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameTextbox.Name = "fullNameTextbox";
            this.fullNameTextbox.Size = new System.Drawing.Size(258, 22);
            this.fullNameTextbox.TabIndex = 6;
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(198, 472);
            this.Register_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(100, 28);
            this.Register_button.TabIndex = 8;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.RegisterUserClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 375);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Re-enter password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReenterText
            // 
            this.ReenterText.Location = new System.Drawing.Point(123, 408);
            this.ReenterText.Margin = new System.Windows.Forms.Padding(4);
            this.ReenterText.Name = "ReenterText";
            this.ReenterText.Size = new System.Drawing.Size(257, 22);
            this.ReenterText.TabIndex = 9;
            this.ReenterText.UseSystemPasswordChar = true;
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReenterText);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Full_name_lable);
            this.Controls.Add(this.fullNameTextbox);
            this.Controls.Add(this.E_mail_lable);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.Password_lable);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.Nick_lable);
            this.Controls.Add(this.nickTextbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterUserForm";
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.RegisterUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nickTextbox;
        private System.Windows.Forms.Label Nick_lable;
        private System.Windows.Forms.Label Password_lable;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label E_mail_lable;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label Full_name_lable;
        private System.Windows.Forms.TextBox fullNameTextbox;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReenterText;
    }
}