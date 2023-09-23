using GeneralHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralHelpers
{
    public class StringHelper
    {
        public static string ToPascalCase(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return (text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower()).Trim();
            }
            return text;
        }

        public static string ToSnakeCase(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return (text.Replace(" ", "_")).Trim();
            }
            return text;
        }

    }
}
