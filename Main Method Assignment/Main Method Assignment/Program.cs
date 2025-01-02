using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsTwo magic1 = new MethodsTwo(); //Instantiate the class 1st time
            Console.WriteLine(magic1.mathMagic(3)); //Calling the method with an INT

            MethodsTwo magic2 = new MethodsTwo(); //Instantiate the class 2nd time
            Console.WriteLine(magic2.mathMagic(3.22m)); //Calling the method with an DECIMAL

            MethodsTwo magic3 = new MethodsTwo(); //Instantiate the class 3rd time
            Console.WriteLine(magic3.mathMagic("55")); //Calling the method with an STRING

            Console.ReadLine();
        }
        

    }
}
