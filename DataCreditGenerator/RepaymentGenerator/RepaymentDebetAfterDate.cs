﻿using DataCreditGenerator.Model;
using GeneralHelpers;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator.RepaymentGenerator
{
    /// <summary>
    /// Generowanie listy płatności, wygenerowanie zadłużenia bo spłata później niż dzień wpłąty.
    /// </summary>
    public class RepaymentDebetAfterDate : BaseRepaymentGenerator, IRepaymentListGenerator
    {
        public RepaymentDebetAfterDate(Agreement agrement) : base(agrement) { }

        public IList<Repayment> GeneratePayments
        {
            get
            {
                IList<Repayment> res = new List<Repayment>();

                DateTime startDate = _agrement.StartDate;
                DateTime date = new DateTime(startDate.Year, startDate.Month, _agrement.DayOfPement);

                int afterDays = random.Next(0, DateTime.DaysInMonth(startDate.Year, startDate.Month) - _agrement.DayOfPement);
                date.AddDays(afterDays);

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
