using DevExpress.Xpo;
using DevExpressCreditDemo.credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.DataGenerator
{
    internal class RandomedAgreement
    {
        private static Random random = new Random();

        public static List<Agreement> Generate(Session session)
        {
            List<Agreement> result = new List<Agreement>();
            var clients = session.Query<Client>();
            var agreementClientIds = session.Query<Agreement>().Select(c => c.IDClient.ID).ToList();
            var cl = clients.Where(c => !agreementClientIds.Contains(c.ID));

            foreach (var client in cl)
            {
                double amount = random.Next(500, 50000);
                int percent = random.Next(40, 60);
                int installmentCount = random.Next(6, 60);
                double installment = Math.Round(amount * (1 + (double)percent / 100) / installmentCount, 4);
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                startDate = DateTime.Now.AddMonths(-1 * random.Next(1, installmentCount - 1));
                startDate = startDate.AddDays(random.Next(0, DateTime.DaysInMonth(startDate.Year, startDate.Month) - 1));

                DateTime endDate = startDate.AddMonths(installmentCount);
                int dayOfPement = random.Next(1, 30);

                Agreement agreement = new Agreement(session)
                {
                    IDClient = client,
                    Amount = amount,
                    Percent = percent,
                    DayOfPement = dayOfPement,
                    Installment = installment,
                    IinstallmentCount = installmentCount,
                    StartDate = startDate.ToString("yyyy-MM-dd"),
                    EndDate = endDate.ToString("yyyy-MM-dd"),
                    Active = random.Next(1,100)>80 ? 0 :1 
                };

                result.Add(agreement);
                //  Console.WriteLine($"{amount}\t{percent}]\t{installmentCount}\t{installment}\t{startDate}\t{endDate}\t{dayOfPement}");
            }

            return result;
        }
    }
}
