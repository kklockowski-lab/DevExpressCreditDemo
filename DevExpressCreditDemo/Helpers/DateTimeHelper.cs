using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.Helpers
{
    internal class DateTimeHelper
    {
        public static int GetMonthDiff(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate) return 0;
            return (endDate.Year - startDate.Year) * 12 + (endDate.Month - startDate.Month);
        }
    }
}
