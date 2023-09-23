using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator.RepaymentGenerator
{
    public class RepaymentNoDebet : IRepaymentListGenerator
    {
        private readonly Agreement _agrement;

        public RepaymentNoDebet(Agreement agrement)
        {
            _agrement = agrement;
        }

        public IList<Repayment> GeneratePayments
        {
            get

            {
                IList<Repayment> res = new List<Repayment>();

                DateTime startDate = _agrement.StartDate;
                DateTime date = new DateTime(startDate.Year, startDate.Month, _agrement.DayOfPement);
                DateTime endDate = DateTime.Now;


                for (int i = 0; date < DateTime.Now; ++i)
                {
                    date = date.AddMonths(i);
                    Repayment rep = new Repayment()
                    {
                        Value = _agrement.Installment,
                        Date = date
                    };
                    res.Add(rep);
                }


                return res;
            }
        }
    }
}
