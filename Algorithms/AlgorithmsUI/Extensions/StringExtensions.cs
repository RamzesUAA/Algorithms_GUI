using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUI.Extensions
{
    public static class StringExtensions
    {
        public static bool IsDigitsOnly(this string str)
        {
            return str.Any(ch => char.IsDigit(ch));
        }
    }
}
