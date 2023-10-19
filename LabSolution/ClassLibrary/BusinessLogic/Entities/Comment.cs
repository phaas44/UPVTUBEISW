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
        
        public Comment(string Text, DateTime WritingDate, Content content, Member member) : this()
        {
            
            this.Text = Text;
            this.WritingDate = WritingDate;
            this.Member = member;
            this.Content = content; 
        }

    }
}
