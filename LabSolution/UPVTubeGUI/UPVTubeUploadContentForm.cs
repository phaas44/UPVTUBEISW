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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTubeGUI
{
    public partial class UPVTubeUploadContentForm : Form
    {
        private IUPVTubeService service;
        private NewSubjectForm newSubjectForm;

        public UPVTubeUploadContentForm(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            this.newSubjectForm = new NewSubjectForm(this, service);
            LoadData();
        }

        private void LoadData()
        {
            CoursesCheckBoxList.Items.Clear();
            ICollection<Subject> subjects = service.GetAllSubjects();
            if (subjects != null)
                foreach (Subject s in subjects)
                    CoursesCheckBoxList.Items.Add(s.Code + ", " + s.Name);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_CLick(object sender, EventArgs e)
        {

        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            newSubjectForm.ShowDialog();
        }

        public void UpdateSubjectsList(string course) 
        {
            CoursesCheckBoxList.Items.Add(course);
            CoursesCheckBoxList.SetItemChecked(CoursesCheckBoxList.Items.IndexOf(course), true);


        }

        private void AddContentButton_Click(object sender, EventArgs e)
        {
            string title = TitleInput.Text;
            string description = DescriptionInput.Text;
            string uri = URIInput.Text;
            bool restricted = RestrictedCheckbox.Checked;
            List<int> courses = new List<int>();
            foreach (string str_code in CoursesCheckBoxList.CheckedItems.Cast<string>())
            {
                int index = str_code.IndexOf(",");
                string substring = str_code.Substring(0, index);
                int code = Int32.Parse(substring);
                courses.Add(code);
                
            }

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(uri) && !string.IsNullOrEmpty(description)) 
            {
                Content content = new Content(uri,description, !restricted, title, DateTime.Now, service.GetLoggedInMember());

                try
                {
                    service.UploadNewContent(content, courses);
                    MessageBox.Show("Content has been created and stored.");
                    this.Close();


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }

            else { MessageBox.Show("Provide at least title, URI and description."); }

            
        }

        private void UPVTubeUploadContentForm_Load(object sender, EventArgs e)
        {

        }

        private void CoursesCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
