using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator.RepaymentGenerator
{
    /// <summary>
    /// Generowanie listy płatności, zadłużenie wynikające z braku płatności rat. 
    /// </summary>
    public class RepaymentDebetPaidLess : BaseRepaymentGenerator, IRepaymentListGenerator
    {
        public RepaymentDebetPaidLess(Agreement agrement) : base(agrement) { }

        public IList<Repayment> GeneratePayments
        {
            get
            {
                IList<Repayment> res = new List<Repayment>();

                DateTime startDate = _agrement.StartDate;
                DateTime date = new DateTime(startDate.Year, startDate.Month, _agrement.DayOfPement);

                for (int i = 0; date < DateTime.Now; ++i)
                {
                    date = date.AddMonths(i);
                   
                    Repayment rep = new Repayment()
                    {
                        Value = random.Next(0, (int)Math.Floor(_agrement.Installment)) + random.NextDouble(),
                        Date = date
                    };
                    res.Add(rep);
                }

                return res;
            }
        }
    }
}
