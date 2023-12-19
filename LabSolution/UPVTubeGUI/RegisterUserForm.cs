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
            string password = passwordTextbox.Text;
            string email = emailTextbox.Text;
            string fullName = fullNameTextbox.Text;

            try
            {
                service.RegisterNewUser(email, fullName, nick, password);
                MessageBox.Show("You have registered successfully!");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
