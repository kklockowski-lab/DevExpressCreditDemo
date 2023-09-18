using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.ORMCreditDBModelCode
{
    [Persistent("VM_REPAID_BY_AGREEMENT")]
    public class VM_REPAID_BY_AGREEMENT : XPLiteObject
    {
        public VM_REPAID_BY_AGREEMENT(Session session) : base(session) { }

        [Key]
        public long ID { get; set; }
        public long IDAgreement { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public long DayOfPement { get; set; }
        public double Installment { get; set; }
        public long IinstallmentCount { get; set; }
        public long Percent { get; set; }

        private double fRepaid;
        public double Repaid { get { return Math.Round(fRepaid, 2); } set { fRepaid = value; } }


    }
}
