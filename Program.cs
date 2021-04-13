using _5.NumberToWord.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberData contextData = new NumberData(102);

            NumberConverter interpeter  = new NumberConverter();

            interpeter.Interpret(contextData);

        }
    }
}
