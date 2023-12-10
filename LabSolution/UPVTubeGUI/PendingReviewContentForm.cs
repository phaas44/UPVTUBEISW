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

namespace UPVTubeGUI
{
    public partial class PendingReviewContentForm : Form
    {

        private IUPVTubeService service;
        public PendingReviewContentForm(IUPVTubeService service)
        {
            this.service = service;
            InitializeComponent();
        }
    }
}
