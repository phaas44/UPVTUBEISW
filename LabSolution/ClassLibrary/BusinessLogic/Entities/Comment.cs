using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public Comment() { }
        
        public Comment(int Id, string Text, DateTime WritingDate, Member member, Content content) : this()
        {
            this.Id = Id;
            this.Text = Text;
            this.WritingDate = WritingDate;
            this.member = member;
            this.content = content; 
        }

    }
}
