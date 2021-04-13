using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    public class NumberConverter
    {
        //public abstract string One();
        //public abstract string Two();
        //public abstract string Three();
        //public abstract string Four();
        //public abstract string Five();
        //public abstract string Six();
        //public abstract string Seven();
        //public abstract string Eight();
        //public abstract string Nine();
        // public abstract int Multiplier();
        Numbers DigitNumbers;

        public void Interpret(NumberData context)
        {

            if (context.Input < 0)
            {
                return;
            }

            int inputCopy = context.Input;
            //int digitCount = (int)Math.Log10(inputCopy) + 1;
            int currentDegree = 0;//(int)Math.Ceiling((double)digitCount / 3) - 1;

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





            if (context.Input < 10)
            {
                DigitNumbers = new SingleDigits();

                context.Output += DigitNumbers[context.Input]/*9 * Multiplier()*/;
                // context.Input = context.Input.Substring(2);
            }
        }
    }

}
