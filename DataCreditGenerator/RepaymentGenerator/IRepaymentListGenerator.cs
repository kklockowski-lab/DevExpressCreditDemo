using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCreditGenerator.RepaymentGenerator
{
    /// <summary>
    /// Interface, slużący do wstrzykiwania zależności (Dependency Injection)
    /// w celu różnej implementacji wyliczania wpłat, a w konsekwencji zadłużenia (zadlużenie wysokością raty, spóźnieniem wpłąty, bez zadłużenia)
    /// Ma też to uskuteczniach zasadę SOLID (Open-Close), aczkolwiek po dodaniu impelemntacji tego interfejsu,
    /// należy także zmodyfikować klasę Agreements (metoda SelectGenerator) oraz Settings (ERepaymentGenerator) aby 
    /// nowy generator poprawnie wybierał sie (ew.losował).
    /// </summary>
    public interface IRepaymentListGenerator
    {
        IList<Repayment> GeneratePayments { get; }
    }
}
