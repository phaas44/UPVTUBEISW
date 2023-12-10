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

namespace UPVTubeApp
{
    public partial class UPVTubeApp : UPVTubeFormBase
    {
        public UPVTubeApp(IUPVTubeService service) : base(service)
        {
            InitializeComponent();

        }
    }
}
