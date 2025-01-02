using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    // Static class
    public static class MathOperations
    {
        // Overloaded method: divides two integers
        public static void Divide(int a, int b, out int result)
        {
            result = a / b;
        }

        // Overloaded method: divides two doubles
        public static void Divide(double a, double b, out double result)
        {
            result = a / b;
        }
    }

    public class Divider
    {
        // Method that divides input by 2 and outputs the result
        public void DivideByTwo(int input, out int result)
        {
            result = input / 2;
        }
    }
}
