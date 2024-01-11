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
    public partial class UPVTubeSearchForm : Form
    {
        private IUPVTubeService service;
        //private UPVTubeShowContentDetails showdetails;
        private DisplayContentForm displayContentForm;
        public UPVTubeSearchForm(IUPVTubeService service)
        {
            this.service = service;
            InitializeComponent();

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;
            string nick = NickInput.Text;
            string title = TitleInput.Text;


            List<string> courses = new List<string>();
            if(CoursesCheckBoxList.CheckedItems.Cast<string>().Count() != 0)
            {
                foreach (string str_code in CoursesCheckBoxList.CheckedItems.Cast<string>())
                {
                    int index = str_code.IndexOf(",");
                    string substring = str_code.Substring(index + 2, str_code.Length - 1 - (index + 1));
                    courses.Add(substring);

                }
            }
            

            List<Content> searchedContent = new List<Content>();   
            try
            {
                if(courses.Count > 0) 
                {
                    foreach (string course in courses)
                    {
                        searchedContent.AddRange(service.SearchContent(startDate, endDate, nick, title, course));
                    }
                }

                else
                {
                    searchedContent.AddRange(service.SearchContent(startDate, endDate, nick, title, ""));
                }
                
                
            }

            catch(Exception ex) { MessageBox.Show(ex.Message); }
            

            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Content c in searchedContent)

                //Adding one anonymous object for each reservation obtained
                bindinglist.Add(new
                {
                    //ds_... are DataPropertyNames defined in the DataGridView object
                    //see DataGridView column definitions in Visual Studio Designer
                    ds_Title = c.Title,
                    ds_URI = c.ContentURI,
                    ds_Description = c.Description,
                    ds_UploadDate = c.UploadDate,
                    ds_Owner = c.Owner.Nick
                });

            SearchbindingSource.DataSource = bindinglist;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searcheddataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString());
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            string cont_uri= row.Cells[0].Value.ToString();
            try
            {
                Content content = service.GetContentDetails(cont_uri);

                displayContentForm = new DisplayContentForm(service, content);
                displayContentForm.ShowDialog();

                /*
                showdetails = new UPVTubeShowContentDetails(service, content);
                showdetails.ShowDialog();
                */
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    
    }
}
