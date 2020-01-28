using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            string First = str.Substring(0, 1);
            First.ToUpper();

            string second = str.Substring(1);

            return First.ToUpper() + second;
        }
    }
}
