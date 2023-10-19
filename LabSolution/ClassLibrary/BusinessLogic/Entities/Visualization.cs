using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() { }

        public Visualization(int Id, DateTime VisualizationDate, Content content, Member member) : this()
        {
            this.Id = Id;
            this.VisualizationDate = VisualizationDate;
            this.content = content;
            this.member = member;
        }
    }
}
