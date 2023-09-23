using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCreditGenerator
{
    public class Setttings
    {
        /// <summary>
        /// Ilość losowanych klientów
        /// </summary>
        public int ClientCount { get; set; } = 100;

        /// <summary>
        /// Maksymalna ilość umów dla jednego klienta
        /// </summary>
        public int MaxAgreementPerClient { get; set; } = 1;

        /// <summary>
        /// Prawdopofobieństwo, że wylosowany klient jest aktywny.
        /// </summary>
        public int ProbabilityOfActivClient { get; set; } = 90;

        /// <summary>
        /// Prawdopofobieństwo, że wylosowana umowa jest aktywna.
        /// </summary>
        public int ProbabilityOfActivAgreement { get; set; } = 90;

        /// <summary>
        /// Minimalna kwota kredytu.
        /// </summary>
        public int MinAmount { get; set; } = 500;

        /// <summary>
        /// Maksymalna kwota kredytu.
        /// </summary>
        public int MaxAmount { get; set; } = 100000;

        /// <summary>
        /// Minimalnay procent kredytu.
        /// </summary>
        public int MinPercent { get; set; } = 40;

        /// <summary>
        /// Maksymalny procent kredytu.
        /// </summary>
        public int MaxPercent { get; set; } = 60;
    }
}
