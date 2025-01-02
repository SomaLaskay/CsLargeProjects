using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassOne stuff = new ClassOne(); //Instatiate the class
            stuff.Ops(5, 10); //Call the method by passing in two numbers
            stuff.Ops(num1: 7, num2: 20); //Call the method, passing the paramethers by specifying their names
            Console.ReadLine();
        }
    }
}
