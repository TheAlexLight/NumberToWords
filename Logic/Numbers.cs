using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NumberToWord.Logic
{
    public abstract class Numbers
    {
        public string[] digits;

        public string this [int index] => digits[index];

        //public string[] Digits
        //{
        //    get => digits;
        //    set
        //    {
        //        digits = value;
        //    }
        //}
    }
}
