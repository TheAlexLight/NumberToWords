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
            NumberData contextData = new NumberData(132543);

            NumberConverter interpeter  = new NumberConverter();

            interpeter.ConvertNumberIntoWords(contextData);

            Console.WriteLine(contextData.Output); 

        }
    }
}
