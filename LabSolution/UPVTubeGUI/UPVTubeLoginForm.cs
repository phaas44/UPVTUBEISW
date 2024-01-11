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
    public partial class UPVTubeLoginForm : Form
    {
        private IUPVTubeService service;

        private UPVTubeAppForm loggedInForm;

        private RegisterUserForm registerUserForm;
        

        public UPVTubeLoginForm(IUPVTubeService service)
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

            try
            {
                service.LoginUser(nickname, password);
                MessageBox.Show("Login Successful!");
                NicknameInput.Clear();
                PasswordInput.Clear();

                //Create next displayed form.
                loggedInForm = new UPVTubeAppForm(service);
                loggedInForm.ShowDialog();

            }

            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }


        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            registerUserForm = new RegisterUserForm(service);
            registerUserForm.ShowDialog();
            
        }

        private void CreateSampleDBStrip_Click(object sender, EventArgs e)
        {
            service.DBInitialization();

            MessageBox.Show("Sample Database has been created!");
        }

        private void DeleteDBStrip_Click(object sender, EventArgs e)
        {

            service.RemoveAllData();
            MessageBox.Show("All data has been removed.");
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NicknameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
