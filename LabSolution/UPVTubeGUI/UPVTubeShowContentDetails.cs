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
using UPVTube.Entities;

namespace UPVTubeGUI
{
    public partial class UPVTubeShowContentDetails : Form
    {

        private IUPVTubeService service;
        private Content content;
        public UPVTubeShowContentDetails(IUPVTubeService service, Content content)
        {
            this.service = service;
            this.content = content;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            TitleTextBox.Text = this.content.Title;
            URITextBox.Text = this.content.ContentURI;
            CreatorTextBox.Text = this.content.Owner.Nick;
            UploadDateTextBox.Text = this.content.UploadDate.ToString();
            if(this.content.IsPublic)
            {
                IsPublicTextBox.Text = "True";
            }
            else
            {
                IsPublicTextBox.Text = "False";
            }

            CommentsTextBox.Text = this.content.Comments.Count().ToString();    
            VisualizationsTextBox.Text = this.content.Visualizations.Count().ToString();
            DescriptionTextBox.Text = this.content.Description;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            try 
            {
                this.service.AddSubscription(this.content.Owner.Nick);
                MessageBox.Show("Successfully subscribed.");
            }
            catch(Exception ex) {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.service.RemoveSubscription(this.content.Owner.Nick);
                MessageBox.Show("Successfully unsubscribed.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
