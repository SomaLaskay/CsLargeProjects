using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //Instantiating the struct as a real object
            number.Amount = 466; //Assigning an amount to the Amount property of the number struct

            Console.WriteLine(number.Amount); //Displaying the value of the Amount property

            Console.ReadLine();
        }

        public struct Number //Creating the struct
        {
            public decimal Amount { get; set; } //Giving it the Amount property
        }

    }
}
