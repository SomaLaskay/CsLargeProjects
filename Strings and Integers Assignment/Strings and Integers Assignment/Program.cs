using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>() { 15, 22, 45, 34, 29 }; //Creating list of integers

            
            try //Try block for exception handling
            {
                Console.WriteLine("Give me a number!"); //Ask for input
                int userInput = Convert.ToInt32(Console.ReadLine()); //Converting and storing user input

                foreach (int i in ints) //Loop for iterating through the list
                {
                    float result = (float) i / userInput; //Carrying out the operation with each element
                    Console.WriteLine(i + " divided by " + userInput + " = " + result); //Displaying results
                }
            }

            catch (FormatException ex) //Catch block for string error
            {
                Console.WriteLine("Don't use strings!"); //Error message
            }

            catch (DivideByZeroException ex) //Catch block for div by zero error
            {
                Console.WriteLine("Not zero please!"); //Error message
            }

            Console.WriteLine("After try/catch block!"); //Message to the user

            Console.ReadLine(); //Keeping the window open
        }
    }
}
