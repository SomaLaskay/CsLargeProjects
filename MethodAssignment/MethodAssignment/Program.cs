using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methodClass areaMagic = new methodClass(); //Instatiate the class
            Console.WriteLine("Give me the WIDTH of the area."); //Asking for the first parameter
            int inputWidth = Convert.ToInt32(Console.ReadLine()); //Converting and storing the first parameter
            Console.WriteLine("Give me the HEIGHT of the area. (Optional)"); //Asking for the second parameter as an option

            try
            {
                int inputHeight = Convert.ToInt32(Console.ReadLine()); //Converting and storing the second parameter
                Console.WriteLine("The surface of the area you defined is " + areaMagic.areaMethod(inputWidth, inputHeight)); //Displaying the results if both parameters are given by the user
            }

            catch
            {
                Console.WriteLine("The surface calculated based on your number as WIDTH and 1 as HEIGHT is " + areaMagic.areaMethod(inputWidth)); //Displaying if only the first parameter is given by the user
            }
            

            

            Console.ReadLine();
        }
    }
}
