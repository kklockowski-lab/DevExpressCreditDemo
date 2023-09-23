using DataCreditGenerator.Model;
using System.Collections.Generic;
using System;
using GeneralHelpers;

namespace DataCreditGenerator
{
    public class Repayments
    {
        private static Random random = new Random();
        private IList<Repayment> result;

        public IList<Repayment> RepeymentList(Agreement agreement)
        {

            if (result is null)
                result = new List<Repayment>();
            else
                return result;

            // Wylosuj czy zadłużony klient czy nie (powyżej 80%)
            bool isDebet = random.Next(1, 100) < 80;

            return genratePayments(agreement, isDebet);

        }

        private IList<Repayment> genratePayments(Agreement agreement, bool isDebet)
        {
            IList<Repayment> res = new List<Repayment>();

            DateTime startDate = agreement.StartDate;
            DateTime date = new DateTime(startDate.Year, startDate.Month, (int)agreement.DayOfPement);
            DateTime endDate = DateTime.Now;

            int mountDebet = 0;
            if (isDebet)
            {
                mountDebet = random.Next(1, DateTimeHelper.MonthCountBetween(date, DateTime.Now));
                endDate = endDate.AddDays(-1*mountDebet);
            }


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

