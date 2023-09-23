using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator.RepaymentGenerator
{
    /// <summary>
    /// Generowanie listy płatności, tak aby nie występowało zadłużenie. 
    /// Czyli płatność od początku spłąty do bieżącego miesiąca i wyskość wpłaty zgodna z ratą.
    /// </summary>
    public class RepaymentNoDebet : BaseRepaymentGenerator, IRepaymentListGenerator
    {
        public RepaymentNoDebet(Agreement agrement) : base(agrement) { }

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
