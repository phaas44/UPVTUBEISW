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
    public partial class UPVTubeApp : Form
    {
        private IUPVTubeService service;
        public UPVTubeApp(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void UPVTubeApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string nickname = NicknameInput.Text;
            string password = PasswordInput.Text;

            if ((!string.IsNullOrEmpty(nickname))&&(!string.IsNullOrEmpty(password)))
            {
                try
                {
                    service.LoginUser(nickname, password);
                    MessageBox.Show("Login Successful!");

                }

                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
                    
                

            }

            else
            {
                MessageBox.Show("Provide Nickname or Password wich is not empty.");
            }


        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Open a new window to get to the registration form.

     

        }
    }
}
