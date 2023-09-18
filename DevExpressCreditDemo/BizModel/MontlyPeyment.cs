using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.BizModel
{
    internal class MontlyPeyment
    {
        public string  Month { get; set; }
        public double  Excepted { get; set; }
        public double  Paid { get; set; }
    }
}
