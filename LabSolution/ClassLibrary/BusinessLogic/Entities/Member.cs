using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public Member()
        {
            Subscriptors = new List<Member>();
            SubscribedTo = new List<Member>();
            Evaluations = new List<Evaluation>();
            Comments = new List<Comment>();
            Contents = new List<Content>();
            Visualizations = new List<Visualization>();
        }
        public Member(string email, string name, DateTime date, string nick, string pass) : this()
        {

            Email = email;
            FullName = name;
            LastAccessDate = date;
            Nick = nick;
            Password = pass;
        }

        public void AddContent(Content c)
        {
            this.Contents.Add(c);
        }
        public void AddComment(Comment c)
        {
           this.Comments.Add(c); 
        }
        public void AddEvaluation(Evaluation e)
        {
            this.Evaluations.Add(e);
        }


            
    }
}
