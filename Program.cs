using _5.NumberToWord.Controller;
using _5.NumberToWord.Logic;
using _5.NumberToWord.View;
using ConsoleTaskLibrary;
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
            try
            {
                if (args.Length != 1)
                {
                    throw new ArgumentException();
                }

                NumberController controller = new NumberController();

                controller.ExecuteMainOperation(args[0]);

            }
            catch (Exception)
            {
                ConsolePrinter _printer = new ConsolePrinter();
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT));
                Environment.Exit(-1);
            }
        }
    }
}
