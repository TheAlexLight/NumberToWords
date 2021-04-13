using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    class TensMultiple : Numbers
    {
        public TensMultiple()
        {
            digits = new string[]
            {
                "", "", "twenty", "thirty", "forty",
                "fifty", "sixty", "seventy", "eighty", "ninety"
            };
        }
    }
}
