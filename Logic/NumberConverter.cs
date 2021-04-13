using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    public class NumberConverter
    {
        Numbers DigitNumbers;

        public void ConvertNumberIntoWords(NumberData context)
        {
            if (context.Input < 0)
            {
                return;
            }

            int inputCopy = context.Input;
            int currentDegree = 0;

            while (inputCopy != 0)
            {
                int currentBlock = inputCopy;

                if (inputCopy >= 100)
                {
                    currentBlock = inputCopy % (int)Math.Pow(10, 3);
                    inputCopy /= (int)Math.Pow(10, 3);
                }
                else
                {
                    inputCopy = 0;
                }

                string tempOutput = "";

                while (currentBlock != 0)
                {
                    int subtractionValue = currentBlock;

                    tempOutput = ProcessNumber(currentBlock, tempOutput, ref subtractionValue);

                    currentBlock -= subtractionValue;
                }

                if (currentDegree != 0)
                {
                    DigitNumbers = new TensPower();
                    tempOutput += DigitNumbers[currentDegree] + " ";
                }

                context.Output = tempOutput + context.Output;

                currentDegree++;
            }
        }

        private string ProcessNumber(int currentBlock, string tempOutput, ref int subtractionValue)
        {
            if (currentBlock >= 100)
            {
                DigitNumbers = new SingleDigits();
                tempOutput += DigitNumbers[currentBlock / 100] + " ";

                DigitNumbers = new TensPower();
                tempOutput += DigitNumbers[0] + " ";

                subtractionValue = 100 * (currentBlock / 100);
            }
            else if (currentBlock < 10)
            {
                DigitNumbers = new SingleDigits();
                tempOutput += DigitNumbers[currentBlock] + " ";
            }
            else if (currentBlock < 20)
            {
                DigitNumbers = new TwoDigits();
                tempOutput += DigitNumbers[currentBlock - 10] + " ";
            }
            else
            {
                DigitNumbers = new TensMultiple();
                tempOutput += DigitNumbers[currentBlock / 10] + " ";

                subtractionValue = (currentBlock / 10) * 10;
            }

            return tempOutput;
        }

    }
}
