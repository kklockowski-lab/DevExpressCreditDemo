using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator.RepaymentGenerator
{
    public class RepaymentNoDebet : IRepaymentListGenerator
    {
        public IList<Repayment> GeneratePayments(Agreement agreement)
        {
            IList<Repayment> res = new List<Repayment>();

            DateTime startDate = agreement.StartDate;
            DateTime date = new DateTime(startDate.Year, startDate.Month, (int)agreement.DayOfPement);
            DateTime endDate = DateTime.Now;

            int mountDebet = 0;


            for (int i = 0; date < DateTime.Now; ++i)
            {
                date = date.AddMonths(i);
                Repayment rep = new Repayment()
                {
                    Value = agreement.Installment,
                    Date = date
                };
                res.Add(rep);
            }


            return res;
        }
    }
}
