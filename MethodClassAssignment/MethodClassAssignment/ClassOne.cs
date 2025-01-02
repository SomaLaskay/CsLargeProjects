using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class ClassOne
    {
        public void Ops(int num1, int num2) //Creating the method that takes two parameters, doing an operation with the first one and displays the second untouched
        {
            int result = num1 + 100;
            Console.WriteLine(result);
            Console.WriteLine(num2);
        }
    }
}
