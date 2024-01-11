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
using UPVTube.Persistence;
using UPVTube.Entities;

namespace UPVTubeGUI
{
    public partial class DisplayContentForm : Form
    {
        private IUPVTubeService service;
        private Content displayedContent;

        public DisplayContentForm(IUPVTubeService service, Content c)
        {
            this.service = service;
            this.displayedContent = c;
            InitializeComponent();

            TitleText.Text = c.Title;
            NickText.Text = c.Owner.Nick;
            DescriptionText.Text = c.Description;
            DateText.Text = c.UploadDate.ToString();
            URIText.Text = c.ContentURI;

            DisplayComments();
        }

        private void DisplayComments()
        {
            List<Comment> comments = displayedContent.Comments.ToList();

            foreach (Comment com in comments)
            {
                string res = com.Writer.Nick + ": " + com.Text; 
                CommentsListView.Items.Insert(0, res);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TitleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NickText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayContentForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (CommentText.TextLength <= 0)
            {
                MessageBox.Show("Your comment cannot be empty!");
            } else
            {
                string nickname = service.GetLoggedInMember().Nick;
                service.AddComment(CommentText.Text, nickname, this.displayedContent);
                CommentsListView.Items.Insert(0, nickname + ": " + CommentText.Text);
                MessageBox.Show("Your comment has been added!");
                CommentText.Clear();
            }


        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            this.service.AddSubscription(this.displayedContent.Owner.Nick);
            MessageBox.Show("Successfully subscribed.");
        }

        private void UnsunscribeButton_Click(object sender, EventArgs e)
        {
            this.service.RemoveSubscription(this.displayedContent.Owner.Nick);
            MessageBox.Show("Successfully unsubscribed.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
