using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() {

            Contents = new List<Content>();
            Members = new List<Member>();
            

                   
        
        }  

        public Visualization(int Id, DateTime VisualzationDate) : this()
        {
            this.Id = Id;
            this.VisualizationDate = VisualizationDate;


        }
    }
}
