using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace DataCreditGenerator.Heleprs
{
    public enum EGender
    {
        Male,
        Female
    }

    public enum ERepaymentGenerator
        {
        NoDebet,
        DebetAfterDate,
        DebetNoPaidLastMonth,
        DebetPaidLess,
        Combain,
        TotalRandom
    }
}
