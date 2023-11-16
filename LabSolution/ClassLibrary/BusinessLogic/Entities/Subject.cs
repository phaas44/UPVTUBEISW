using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            this.Contents = new List<Content>();
        }

        public Subject(int c, string fn, string n) : this()
        {
            this.Code = c;
            this.FullName = fn;
            this.Name = n;
        }
        
        public void AddContent(Content c)
        {
            this.Contents.Add(c);
        }
  
    }
}
