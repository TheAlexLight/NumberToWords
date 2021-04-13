using _5.NumberToWord.Logic;
using _5.NumberToWord.Validation;
using _5.NumberToWord.View;
using ConsoleTaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Controller
{
    class NumberController
    {
        ConsolePrinter _printer = new ConsolePrinter();

        public void ExecuteMainOperation(string number)
        {
            int _number = CheckNumberValue(number);

            NumberData contextData = new NumberData(_number);

            NumberConverter numberToWordsConverter = new NumberConverter();

            numberToWordsConverter.ConvertNumberIntoWords(contextData);

            _printer.WriteLine(string.Format(Constant.NUMBER_TO_WORDS, _number, contextData.Output));

        }

        public int CheckNumberValue(string number)
        {
            Converter converterArgs = new Converter();
            Validator validArgs = new Validator();

            int result = converterArgs.TryParseToInt(number);

            if (result != -1)
            {
                if (!validArgs.CheckIntOnPositive(result))
                {
                    _printer.WriteLine(Constant.WRONG_BOUNDARIES);
                    _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT));
                    Environment.Exit(-1);
                }
            }
            else
            {
                _printer.WriteLine(Constant.INT_WRONG_TYPE);
                _printer.ShowInstruction(Constant.INSTRUCTION, string.Format(Constant.FIRST_ARGUMENT));
                Environment.Exit(-1);
            }

            return result;
        }

    }
}
