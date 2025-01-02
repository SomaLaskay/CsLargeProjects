using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Divider class
            Divider divider = new Divider();

            // Ask the user for a number
            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call DivideByTwo method and display result
            divider.DivideByTwo(userInput, out int dividedResult);
            Console.WriteLine($"Your number divided by two is: {dividedResult}");

            // Use static MathOperations class to perform division with output parameters
            Console.WriteLine("Using the MathOperations static class...");

            // Call overloaded method for integers
            MathOperations.Divide(10, 2, out int intResult);
            Console.WriteLine($"Integer division result: {intResult}");

            // Call overloaded method for doubles
            MathOperations.Divide(10.0, 3.0, out double doubleResult);
            Console.WriteLine($"Double division result: {doubleResult:F2}");

            // Call the method specifying parameters by name
            MathOperations.Divide(a: 20, b: 4, out int namedResult);
            Console.WriteLine($"Named parameter division result: {namedResult}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
