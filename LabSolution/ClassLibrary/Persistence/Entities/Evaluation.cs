using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public DateTime EvaluationDate { get; set; }
        public string RejectionReason { get; set; }
        public Content content { get; set; }
        public Member member { get; set; }
    }
}
