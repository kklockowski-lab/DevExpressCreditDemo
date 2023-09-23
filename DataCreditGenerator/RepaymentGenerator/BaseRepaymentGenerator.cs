using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCreditGenerator.RepaymentGenerator
{
    /// <summary>
    /// Klasa bazowa dla klas implementujących interfejs IRepaymentListGenerator.
    /// Wykorzystanie bazowego konstruktora, zmienna protecteg dla umowy, aby była widoczna tylko w klasach pochodnych.
    /// </summary>
    public class BaseRepaymentGenerator
    {
        protected readonly Agreement _agrement;
        public BaseRepaymentGenerator(Agreement agrement)
        {
            _agrement = agrement;
        }
    }
}
