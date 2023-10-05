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

        public Visualization(int Id, Content content, Member member, DateTime VisualizationDate) : this()
        {
            this.Id = Id;
            this.content = content;
            this.member = member;
            this.VisualizationDate = VisualizationDate;
        }
    }
}
