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
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.E_mail_lable = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.Full_name_lable = new System.Windows.Forms.Label();
            this.fullNameTextbox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nickTextbox
            // 
            this.nickTextbox.Location = new System.Drawing.Point(263, 57);
            this.nickTextbox.Name = "nickTextbox";
            this.nickTextbox.Size = new System.Drawing.Size(236, 20);
            this.nickTextbox.TabIndex = 0;
            // 
            // Nick_lable
            // 
            this.Nick_lable.AutoSize = true;
            this.Nick_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nick_lable.Location = new System.Drawing.Point(178, 57);
            this.Nick_lable.Name = "Nick_lable";
            this.Nick_lable.Size = new System.Drawing.Size(40, 23);
            this.Nick_lable.TabIndex = 1;
            this.Nick_lable.Text = "Nick";
            // 
            // Password_lable
            // 
            this.Password_lable.AutoSize = true;
            this.Password_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lable.Location = new System.Drawing.Point(178, 104);
            this.Password_lable.Name = "Password_lable";
            this.Password_lable.Size = new System.Drawing.Size(79, 23);
            this.Password_lable.TabIndex = 3;
            this.Password_lable.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(263, 104);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(236, 20);
            this.passwordTextbox.TabIndex = 2;
            // 
            // E_mail_lable
            // 
            this.E_mail_lable.AutoSize = true;
            this.E_mail_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_mail_lable.Location = new System.Drawing.Point(178, 149);
            this.E_mail_lable.Name = "E_mail_lable";
            this.E_mail_lable.Size = new System.Drawing.Size(53, 23);
            this.E_mail_lable.TabIndex = 5;
            this.E_mail_lable.Text = "E-mail";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(263, 149);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(236, 20);
            this.emailTextbox.TabIndex = 4;
            // 
            // Full_name_lable
            // 
            this.Full_name_lable.AutoSize = true;
            this.Full_name_lable.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Full_name_lable.Location = new System.Drawing.Point(178, 193);
            this.Full_name_lable.Name = "Full_name_lable";
            this.Full_name_lable.Size = new System.Drawing.Size(81, 23);
            this.Full_name_lable.TabIndex = 7;
            this.Full_name_lable.Text = "Full Name";
            // 
            // fullNameTextbox
            // 
            this.fullNameTextbox.Location = new System.Drawing.Point(263, 193);
            this.fullNameTextbox.Name = "fullNameTextbox";
            this.fullNameTextbox.Size = new System.Drawing.Size(236, 20);
            this.fullNameTextbox.TabIndex = 6;
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(342, 236);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(75, 23);
            this.Register_button.TabIndex = 8;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.RegisterUserClick);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 323);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Full_name_lable);
            this.Controls.Add(this.fullNameTextbox);
            this.Controls.Add(this.E_mail_lable);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.Password_lable);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.Nick_lable);
            this.Controls.Add(this.nickTextbox);
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
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label E_mail_lable;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label Full_name_lable;
        private System.Windows.Forms.TextBox fullNameTextbox;
        private System.Windows.Forms.Button Register_button;
    }
}