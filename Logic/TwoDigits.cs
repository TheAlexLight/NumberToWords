using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    class TwoDigits : Numbers
    {
        public TwoDigits()
        {
            digits = new string[]
            {
                "ten", "eleven", "twelve", "thirteen",
                "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };
        }
    }
}
