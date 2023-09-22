using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCreditGenerator.Model
{
    public class Agreement
    {
        public Client Client { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public uint DayOfPement { get; set; }


        public double Amount { get; set; }
        public uint Percent { get; set; }
        public uint IinstallmentCount { get; set; }
        public double Installment { get; set; }


        public byte[] Attachment { get; set; }
        public bool Active { get; set; }
        public IList<Repayment> Repayments { get; set; }
    }
}
