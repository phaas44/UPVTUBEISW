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
using UPVTube.Persistence;
using UPVTube.Services;

namespace UPVTubeGUI
{   
    public partial class AddReviewForm : Form
    {
        public Content contentBeingReviewed;

        public AddReviewForm(IUPVTubeService service)
        {
            InitializeComponent();
        }
    }
}
