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

        public Visualization(DateTime VisualizationDate, Content content, Member member) : this()
        {
            
            this.VisualizationDate = VisualizationDate;
            this.Content = content;
            this.Member = member;
        }
    }
}
