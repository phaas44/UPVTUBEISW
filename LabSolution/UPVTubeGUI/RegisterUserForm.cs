using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class RegisterUserForm : Form
    {
        private IUPVTubeService service;
        public UPVTubeService Service;
        
        public RegisterUserForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
         }
          

        private void RegisterUserForm_Load(object sender, EventArgs e)
        {
  
        }

        private void RegisterUserClick(object sender, EventArgs e)
        {
            string nick = nickTextbox.Text;
            string password = PasswordText.Text;
            string email = emailTextbox.Text;
            string fullName = fullNameTextbox.Text;

            try
            {
                if (ReenterText.Text != PasswordText.Text)
                {
                    MessageBox.Show("Make sure both passwords are equal!");
                    PasswordText.Clear();
                    ReenterText.Clear();
                }
                else if (PasswordText.TextLength == 0)
                {
                    MessageBox.Show("Password cannot be empty!");
                }
                else
                {
                    service.RegisterNewUser(email, fullName, nick, password);
                    MessageBox.Show("You have registered successfully!");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Full_name_lable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_lable_Click(object sender, EventArgs e)
        {

        }

        private void Nick_lable_Click(object sender, EventArgs e)
        {

        }

        private void E_mail_lable_Click(object sender, EventArgs e)
        {

        }
    }
}
