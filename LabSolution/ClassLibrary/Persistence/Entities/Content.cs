using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Authorized Authorized { get; set; }
        public string ContentURI { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public virtual Member Owner { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Visualization> Visualizations { get; set; }
    }
}
