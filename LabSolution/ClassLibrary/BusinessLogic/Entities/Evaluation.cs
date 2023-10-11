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

        public Evaluation(DateTime e, string r, Content c, Member m) : this()
        {
            EvaluationDate = e;
            RejectionReason = r;
            content = c;
            member = m;
        }
    }
}
