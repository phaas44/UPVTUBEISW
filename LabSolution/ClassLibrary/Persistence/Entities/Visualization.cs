using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public virtual Member member{ get; set; }
        public virtual Content content{ get; set; }

        public int Id { get; set; }

        public DateTime VisualizationDate { get; set; }
    }
}
