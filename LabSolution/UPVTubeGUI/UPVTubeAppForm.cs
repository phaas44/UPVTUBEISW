﻿using System;
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
    public partial class UPVTubeAppForm : Form
    {
        private IUPVTubeService service;

        private UPVTubeUploadContentForm uploadContentForm;
        private PendingReviewContentForm pendingReviewContentForm;
        public UPVTubeAppForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void UPVTubeAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            service.LogoutUser();
            MessageBox.Show("Logged out.");
        }

        private void LogoutStrip_Click(object sender, EventArgs e)
        {
            this.Close(); //Automatically logs out since UPVTubeAppForm_FormClosing is called.
        }

        private void UploadContentStrip_Click(object sender, EventArgs e)
        {
            uploadContentForm = new UPVTubeUploadContentForm(service);
            uploadContentForm.ShowDialog();
        }

        private void ViewPendingContentStrip_Click(object sender, EventArgs e)
        {
            if (service.IsProfessor())
            {
                pendingReviewContentForm = new PendingReviewContentForm(service);
                pendingReviewContentForm.ShowDialog();
            }
            else MessageBox.Show("You must be a teacher to see content pending for review!");
        }

        /*
        private void CheckUserType_Click(object sender, EventArgs e)
        {

        }
        */

    }
}
