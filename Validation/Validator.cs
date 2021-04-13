using _5.NumberToWord.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Validation
{
    class Validator
    {
        public bool CheckIntOnPositive(int intToCheck)
        {
            return (intToCheck > 0 && intToCheck < Constant.MAX_NUMBER_SIZE);
        }
    }
}
