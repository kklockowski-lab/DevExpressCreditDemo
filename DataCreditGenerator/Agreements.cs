using DataCreditGenerator.Model;
using System.Collections.Generic;
using System;

namespace DataCreditGenerator
{
    public class Agreements
    {
        private static Random random = new Random();

        private IList<Agreement> result;
        public  IList<Agreement> AgreementList(IList<Client> clients)
        {

            foreach (var client in clients)
            {
                double amount = random.Next(500, 50000);
                int percent = random.Next(40, 60);
                int installmentCount = random.Next(6, 60);
                double installment = Math.Round(amount * (1 + (double)percent / 100) / installmentCount, 4);
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                startDate = startDate.AddMonths(-1 * random.Next(1, installmentCount - 1));
                startDate = startDate.AddDays(random.Next(0, DateTime.DaysInMonth(startDate.Year, startDate.Month) - 1));

                DateTime endDate = startDate.AddMonths(installmentCount);
                int dayOfPement = random.Next(1, 30);

                Agreement agreement = new Agreement()
                {
                    Amount = amount,
                    Percent = percent,
                    DayOfPement = dayOfPement,
                    Installment = installment,
                    IinstallmentCount = installmentCount,
                    StartDate = startDate,
                    EndDate = endDate,
                    Active = random.Next(1, 100) < 80 
                };

                result.Add(agreement);                
            }

            return result;
        }
    }
}
