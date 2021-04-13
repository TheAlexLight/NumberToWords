using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    public class NumberData
    {
        public NumberData(int input)
        {
            Input = input;
        }

        public int Input { get; set; }
        public string Output { get; set; }
    }
}
