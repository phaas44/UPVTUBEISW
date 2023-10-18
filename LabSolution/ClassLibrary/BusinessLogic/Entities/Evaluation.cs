using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {

        public Evaluation() { }

        public Evaluation(DateTime EvaluationDate, int Id, string RejectionReason, Member Censor, Content content):this() {
        
            this.EvaluationDate = EvaluationDate;
            this.Id = Id;
            this.RejectionReason = RejectionReason;
            this.content = content;
            this.member = Censor;
        }
    }
}
