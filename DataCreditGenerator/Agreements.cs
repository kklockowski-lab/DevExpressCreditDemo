using DataCreditGenerator.Model;
using DataCreditGenerator.RepaymentGenerator;
using System.Collections.Generic;
using System;
using DataCreditGenerator.Heleprs;

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
            else _settings = settings;
        }
        public IList<Agreement> AgreementList(IList<Client> clients)
        {
            if (result is null) result = new List<Agreement>();
            else return result;

            foreach (var client in clients)
            {
                double amount = random.Next(_settings.MinAmount, _settings.MaxAmount);
                int percent = random.Next(_settings.MinPercent, _settings.MaxPercent + 1);
                int installmentCount = random.Next(_settings.MinInstallmentCount, _settings.MaxInstallmentCount);
                double installment = Math.Round(amount * (1 + (double)percent / 100) / installmentCount, 4);
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                startDate = startDate.AddMonths(-1 * random.Next(1, installmentCount - 1));
                startDate = startDate.AddDays(random.Next(0, DateTime.DaysInMonth(startDate.Year, startDate.Month) - 1));

                DateTime endDate = startDate.AddMonths(installmentCount);
                int dayOfPement = random.Next(1, 29); //Dla bezpieczeństwa gdyby wypadł luty (28 dni)

                // Podstawowe dane umowy
                Agreement agreement = new Agreement()
                {
                    Amount = amount,
                    Percent = percent,
                    DayOfPement = dayOfPement,
                    Installment = installment,
                    IinstallmentCount = installmentCount,
                    StartDate = startDate,
                    EndDate = endDate,
                    Active = random.Next(1, 101) <= _settings.ProbabilityOfActivAgreement
                };

                // Tworzenie płatności dla danej umowy
                IRepaymentListGenerator generator = SelectGenerator(agreement);
                Repayments repayments = new Repayments(generator);
                agreement.Repayments = repayments.RepeymentList();


                result.Add(agreement);
            }

            return result;
        }

        /// <summary>
        /// Domyślnie podaje tyko umowę, ale mogę wymusić wybór interfejsu. 
        /// Zrobionje tak, aby móc rekurencyjnie wybrać interface podczas losowania.
        /// </summary>
        /// <param name="agreement"></param>
        /// <param name="repaymentEnum"></param>
        /// <returns></returns>
        private IRepaymentListGenerator SelectGenerator(Agreement agreement, ERepaymentGenerator? repaymentEnum = null)
        {
            ERepaymentGenerator switchValue = repaymentEnum ?? _settings.RepaymentGenerator;
            switch (switchValue)
            {
                case Heleprs.ERepaymentGenerator.DebetAfterDate:
                    return new RepaymentNoDebet(agreement);
                case Heleprs.ERepaymentGenerator.DebetNoPaid:
                    return new RepaymentNoDebet(agreement);
                case Heleprs.ERepaymentGenerator.Combain:
                    return new RepaymentNoDebet(agreement);
                case Heleprs.ERepaymentGenerator.TotalRandom:
                    {
                        ERepaymentGenerator selectedOption = ERepaymentGenerator.TotalRandom;
                        while (selectedOption.Equals(Heleprs.ERepaymentGenerator.TotalRandom))
                        {
                            int r = random.Next(0, Enum.GetValues(typeof(ERepaymentGenerator)).Length);
                            selectedOption = (ERepaymentGenerator)Enum.ToObject(typeof(ERepaymentGenerator), r);
                        }
                        return SelectGenerator(agreement, selectedOption);
                    }
                default: return new RepaymentNoDebet(agreement);
            }
        }
    }
}
