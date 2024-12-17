using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I'll do magic with it!"); //Asking for user input
            int usrInpt = Convert.ToInt32(Console.ReadLine()); //Converting and storing user input
            int squareRes = mathMagic.square(usrInpt); //Calling and storing method 1
            int cubeRes = mathMagic.cube(usrInpt); //Calling and storing method 2
            int multiRandRes = mathMagic.multiRand(usrInpt); //Calling and storing method 3
            Console.WriteLine("\nGreat! Your number is the " + usrInpt + "!\n"); //Writing out user input for confirmation
            Console.WriteLine("Your number's square is " + squareRes); //Writing out result of method 1
            Console.WriteLine("Your number's cube is " + cubeRes); //Writing out result of method 2
            Console.WriteLine("Your number multiplied by a random number between 5 and 50 is " + multiRandRes); //Writing out result of method 3

            Console.ReadLine(); //Keeping the window open
        }
    }
}
