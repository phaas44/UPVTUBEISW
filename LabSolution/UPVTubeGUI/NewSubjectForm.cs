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
    public partial class NewSubjectForm : Form
    {
        private UPVTubeUploadContentForm uploadContentForm;
        private IUPVTubeService service;
        public NewSubjectForm(UPVTubeUploadContentForm uploadContentForm, IUPVTubeService service)
        {
            InitializeComponent();
            this.uploadContentForm = uploadContentForm;
            this.service = service;

        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            int code = Int32.Parse(CodeInput.Text);
            string fullname = FullNameInput.Text;
            string name = NameInput.Text;

            if (!string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(name)) 
            { 
                Subject subject = new Subject(code,fullname,name);

                try
                {
                    service.AddSubject(subject);
                    MessageBox.Show("Subject has been created and stored.");

                    string course = code + ", " + name;
                    uploadContentForm.UpdateSubjectsList(course);
                    this.Close();

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
