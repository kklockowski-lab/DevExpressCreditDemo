using DevExpress.Charts.Native;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.Helpers
{
    internal class DateTimeHelper
    {
        public static int MonthCountBetween(DateTime startDate, DateTime endDate)
        {
            if (endDate <= startDate) return 0;
            return (endDate.Year - startDate.Year) * 12 + (endDate.Month - startDate.Month);
        }

        public static string MonthName(int monthNo)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[monthNo - 1];
        }

        // Przeciążenie metody
        public static int MonthCountBetween(DateTime dataStartCheck, DateTime dataEndCheck, DateTime startDate, DateTime endDate)
        {
            if (dataStartCheck <= startDate && dataEndCheck > endDate) return MonthCountBetween(startDate, endDate);
            else if (dataStartCheck >= startDate && dataEndCheck <= endDate) return MonthCountBetween(dataStartCheck, dataEndCheck);
            else if (dataStartCheck <= startDate && dataEndCheck <= endDate) return MonthCountBetween(startDate, dataEndCheck);
            else if (dataStartCheck >= startDate && dataEndCheck >= endDate) return MonthCountBetween(dataStartCheck, endDate);
            else
                return 0;
        }
    }
}
