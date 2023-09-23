using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.ORMCreditDBModelCode
{
    [Persistent("View_ClientRepayments")]
    public class View_ClientRepayments : XPLiteObject
    {
        public View_ClientRepayments(Session session) : base(session) { }

        [Key]
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Date { get; set; }
        public double Value { get; set; }
        public long DayOfPement { get; set; }

    }
}
