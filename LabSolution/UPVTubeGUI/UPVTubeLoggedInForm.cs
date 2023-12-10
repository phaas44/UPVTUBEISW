using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;

namespace UPVTubeGUI
{
    public partial class UPVTubeLoggedInForm : Form
    {
        private IUPVTubeService service;

        private UPVTubeUploadContentForm uploadContentForm;
        public UPVTubeLoggedInForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void LogoutStrip_Click(object sender, EventArgs e)
        {
            service.LogoutUser();
            MessageBox.Show("Successfully logged out.");
            this.Close();

        }

        private void UploadContentStrip_Click(object sender, EventArgs e)
        {
            uploadContentForm = new UPVTubeUploadContentForm(service);
            uploadContentForm.Show();
        }
    }
}
