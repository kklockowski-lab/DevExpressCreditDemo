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

                List<Repayment> repList = isDebet ? GenerateDebet(agreement) : GenerateNoDebet(agreement);           

            return result;
        }

        private static List<Repayment> GenerateNoDebet(Agreement agr)
        {
            List<Repayment> res = new List<Repayment>();

            DateTime startDate =agr.StartDate;
            DateTime date = new DateTime(startDate.Year, startDate.Month, (int)agr.DayOfPement);

            for (int i = 0; date < DateTime.Now; ++i)
            {
                date = date.AddMonths(i);
                Repayment rep = new Repayment()
                {
                    Value = agr.Installment,
                    Date = date
                };
                res.Add(rep);
            }


            return res;

        }

        private static List<Repayment> GenerateDebet(Agreement agr)
        {
            List<Repayment> res = new List<Repayment>();

            DateTime date = agr.StartDate;

            int mountDebet = random.Next(1, DateTimeHelper.MonthCountBetween(date, DateTime.Now));

            for (int i = 0; date.AddMonths(i) < DateTime.Now.AddMonths(mountDebet); ++i)
            {
                Repayment rep = new Repayment()
                {
                    Value = agr.Installment,
                    Date = date
                };
                res.Add(rep);
            }


            return res;
        }

    }
}

