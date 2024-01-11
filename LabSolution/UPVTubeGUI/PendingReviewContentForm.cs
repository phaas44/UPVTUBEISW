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
    public partial class PendingReviewContentForm : Form
    {

        private IUPVTubeService service;
        private bool contentApproved;
        Content selectedContent;
        
        public PendingReviewContentForm(IUPVTubeService service)
        {
            this.service = service;
            InitializeComponent();

            ContentGrid.Sort(ContentGrid.Columns["UploadDate"], ListSortDirection.Ascending);
            ContentGrid.Columns["Content"].Visible = false;
            
            string isPublic;
            foreach (Content c in service.GetAllPendingContents())
            {
                if (c.IsPublic) { isPublic = "Yes"; }
                else { isPublic = "No"; }
                ContentGrid.Rows.Add(c.Title, c.Owner.Nick, c.Description, isPublic, c.UploadDate, SubjectsToString(c), c);
            }
        }

        private static string SubjectsToString(Content c)
        {
            List<Subject> subjects = c.Subjects.ToList();
            string res = "";

            foreach(Subject s in subjects)
            {
                if (subjects.IndexOf(s) == subjects.Count - 1) { res += s.Name; }
                else { res += s.Name + ", "; }
            }
            return res;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            contentApproved = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ContentGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a content to review!");
            }
            else
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    MessageBox.Show("Please approve or reject the selected content!");
                } 
                else
                {
                    string review = textBox1.Text;
                    if (review.Length == 0 && !contentApproved)
                    {
                        MessageBox.Show("You must provide a justification in case of rejection!");
                    } else if (review.Length == 0 && contentApproved)
                    {
                        review = "Accepted";

                        selectedContent = ContentGrid.SelectedRows[0].Cells[6].Value as Content;
                        service.AddEvaluation(selectedContent.Id, review, !contentApproved);
                        MessageBox.Show("Content is accepted.");
                    } else 
                    {
                        selectedContent = ContentGrid.SelectedRows[0].Cells[6].Value as Content;
                        service.AddEvaluation(selectedContent.Id, review, contentApproved);
                        MessageBox.Show("Content is rejected.");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            contentApproved = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ContentGrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a content");
            } else
            {
                selectedContent = ContentGrid.SelectedRows[0].Cells[6].Value as Content;
                DisplayContentForm displayContentForm = new DisplayContentForm(service, selectedContent);
                displayContentForm.ShowDialog();
            }
        }
    }
}
