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

        public Evaluation(Member Censor, Content content, DateTime EvaluationDate, int Id, string RejectionReason):this() {
        
            this.censor = Censor;
            this.content = content;
            this.EvaluationDate = EvaluationDate;
            this.Id = Id;
            this.RejectionReason = RejectionReason;
        }
    }
}
