using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content(){
            Subjects = new List<Subject>();
            Comments = new List<Comment>();
            Visualizations = new List<Visualization>();
        }

        public Content(string uri, string d, bool p, string t, DateTime upload, Member member) : this() {
        
            this.ContentURI = uri;
            this.Description = d;
            this.IsPublic = p;
            this.Title = t;
            this.UploadDate = upload;
            this.Owner = member;
            
            if (Domains.IsTeacherDomain(member.Email)) {
                this.Authorized = Authorized.Yes;
            } else {
                this.Authorized = Authorized.Pending;
            }
        }
    }
}
