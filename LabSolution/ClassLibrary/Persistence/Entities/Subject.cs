using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UPVTube.Entities
{
    public partial class Subject
    {
        [Key]
        public int Code { get; set; }

        public string FullName { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
    }
}
