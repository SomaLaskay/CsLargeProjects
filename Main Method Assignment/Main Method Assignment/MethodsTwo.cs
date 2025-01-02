using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class MethodsTwo
    {
        public int mathMagic(int number) //Creating the first method for INT inputs
        {
            return number * 5;
        }

        public int mathMagic(decimal number) //Creating the first method for DECIMAL inputs
        {
            int result = Convert.ToInt32(number);
            return result + 22;
        }

        public int mathMagic(string number) //Creating the first method for STRING inputs
        {
            int resultString = Convert.ToInt32(number);
            return resultString % 3;
        }
    }
}
