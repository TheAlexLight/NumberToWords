using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    public class SingleDigits : Numbers
    {
        public SingleDigits()
        {
            digits = new string[]
            {
                "", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };
        }
    }
}
