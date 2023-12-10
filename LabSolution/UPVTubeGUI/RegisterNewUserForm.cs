using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class RegisterNewUserForm : Form
    {

        private IUPVTubeService service;
        
        public RegisterNewUserForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string email = EmailInput.Text;
            string name = NameInput.Text;
            string nickname = NicknameInput.Text;
            string password = PasswordInput.Text;

            if ((!string.IsNullOrEmpty(email)) && (!string.IsNullOrEmpty(password)) && (!string.IsNullOrEmpty(nickname)))
            {
                try
                {
                    service.RegisterNewUser(email, name, DateTime.Now, nickname, password);
                    MessageBox.Show("Registration Successful!");


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

            else
            {
                MessageBox.Show("Provide Email, Nickname and Password!");
            }

        }

        private void RegisterNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
