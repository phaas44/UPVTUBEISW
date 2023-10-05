using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public ICollection<Member> Members{ get; set; }
        public ICollection<Content> Contents{ get; set; }

        public int Id { get; set; }

        public string Text{ get; set; }

        public DateTime VisualizationDate { get; set; }
    }
}
