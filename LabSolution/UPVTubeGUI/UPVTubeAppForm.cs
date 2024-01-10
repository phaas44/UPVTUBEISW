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
using UPVTube.Entities;

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
            LoadData();
        }

        private void LoadData()
        {
            Member logged = service.GetLoggedInMember();
            DateTime lastLogin = logged.LastAccessDate;

            List<Content> newContent = new List<Content>();
            
            foreach (Member subscribed in logged.SubscribedTo)
            {
                newContent.AddRange(service.SearchContent(lastLogin, DateTime.Now, subscribed.Nick, null, null));

            }

            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Content c in newContent)

                //Adding one anonymous object for each reservation obtained
                bindinglist.Add(new
                {
                    //ds_... are DataPropertyNames defined in the DataGridView object
                    //see DataGridView column definitions in Visual Studio Designer
                    Title = c.Title,
                    URI = c.ContentURI,
                    Description = c.Description,
                    UploadDate = c.UploadDate,
                    Owner = c.Owner
                });

            newcontentbindingSource.DataSource = bindinglist;




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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
        private void CheckUserType_Click(object sender, EventArgs e)
        {

        }
        */

    }
}
