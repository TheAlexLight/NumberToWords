using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    class TensPower : Numbers
    {
        public TensPower()
        {
            digits = new string[]
            {
                "hundred", "thousand", "million", "billion", "trillion",
                "quadrillion", "quantillion"
            };

        }
    }
}
