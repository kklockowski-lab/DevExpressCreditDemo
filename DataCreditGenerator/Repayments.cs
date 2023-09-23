using DataCreditGenerator.Model;
using DataCreditGenerator.RepaymentGenerator;
using GeneralHelpers;
using System;
using System.Collections.Generic;

namespace DataCreditGenerator
{
    public class Repayments
    {
        private IList<Repayment> result;
        private readonly Agreement agreement;
        private IRepaymentListGenerator _generator;
        public Repayments(IRepaymentListGenerator generator )
        {
            _generator = generator;
        }
        public IList<Repayment> RepeymentList()
        {

            if (result is null)
                result = new List<Repayment>();
            else
                return result;

            return _generator.GeneratePayments(agreement);

        }
    }
}

