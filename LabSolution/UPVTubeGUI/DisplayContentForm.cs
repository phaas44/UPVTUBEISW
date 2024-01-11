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
        IUPVTubeService service;
        Content displayedContent;

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
                MessageBox.Show("Your comment has been added!");
                CommentText.Clear();
            }
        }
    }
}
