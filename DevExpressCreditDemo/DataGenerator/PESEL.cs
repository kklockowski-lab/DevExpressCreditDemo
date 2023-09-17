using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCreditDemo.DataGenerator
{
    internal class Pesel
    {
        private static Random random = new Random();
        public static string Generate(Gender gender)
        {
            int year = random.Next(DateTime.Now.AddYears(-68).Year, DateTime.Now.AddYears(-18).Year);     
            int month = random.Next(1, 13);            
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            month = year > 1999 ? month + 20 : month;
            int digit = random.Next(1001, 9999);

            //Poprawka na płeć.
            if ((gender == Gender.Male && digit % 2 == 0)
                ||
                (gender == Gender.Female && digit % 2 == 1))
                digit = digit - 1;

            int[] weight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            string sYear = year.ToString().Substring(2, 2);
            string sMont = month.ToString().PadLeft(2, '0');
            string sDay = day.ToString().PadLeft(2, '0');
            string sDigit = digit.ToString();

            string sNoControl = sYear + sMont + sDay + sDigit;

            //Suma controlna
            int control = 0;
            for(int i=0; i<weight.Length;++i)
            {
                string sChar = sNoControl[i].ToString();
                control += (weight[i] * int.Parse(sChar)) %10;
            }

            control = control==10? 0 : 10 - control % 10;

            return sNoControl + control.ToString();
        }

    }
}
