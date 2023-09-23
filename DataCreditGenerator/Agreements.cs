using DataCreditGenerator.Model;
using DataCreditGenerator.RepaymentGenerator;
using System.Collections.Generic;
using System;

namespace DataCreditGenerator
{
    public class Agreements
    {
        private static Random random = new Random();

        private readonly Setttings _settings;
        private IList<Agreement> result;

        public Agreements(Setttings settings = null)
        {
            if (settings is null) _settings = new Setttings();
            _settings = settings;
        }
        public  IList<Agreement> AgreementList(IList<Client> clients)
        {
            if(result is null) result = new List<Agreement>();
            else return result;

            foreach (var client in clients)
            {
                double amount = random.Next(_settings.MinAmount, _settings.MaxAmount);
                int percent = random.Next(_settings.MinPercent, _settings.MaxPercent + 1);
                int installmentCount = random.Next(6, 60);
                double installment = Math.Round(amount * (1 + (double)percent / 100) / installmentCount, 4);
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                startDate = startDate.AddMonths(-1 * random.Next(1, installmentCount - 1));
                startDate = startDate.AddDays(random.Next(0, DateTime.DaysInMonth(startDate.Year, startDate.Month) - 1));

                DateTime endDate = startDate.AddMonths(installmentCount);
                int dayOfPement = random.Next(1, 29); //Dla bezpieczeństwa gdyby wypadł luty (28 dni)

                Agreement agreement = new Agreement()
                {
                    Amount = amount,
                    Percent = percent,
                    DayOfPement = dayOfPement,
                    Installment = installment,
                    IinstallmentCount = installmentCount,
                    StartDate = startDate,
                    EndDate = endDate,
                    Active = random.Next(1, 101) < _settings.ProbabilityOfActivAgreement
                };
                IRepaymentListGenerator generator = new RepaymentNoDebet();
                Repayments repayments = new Repayments(generator);
                agreement.Repayments = repayments.RepeymentList();
                result.Add(agreement);                
            }

            return result;
        }
    }
}
