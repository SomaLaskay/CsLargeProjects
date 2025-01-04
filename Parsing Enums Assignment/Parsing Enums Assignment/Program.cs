using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false; //A boolean variable for tracking whether we need to stay in the loop of asking the question
            while (!isValid) //The loop we are staying in for forcing the user to give us a valid answer
            {
                try //Try / Catch for exception handling
                {
                    Console.WriteLine("Write the current day of the week!"); //Asking the user to type in a valid day of the week
                    string userInput = Console.ReadLine(); //Storing the userInput
                    Days day = (Days)Enum.Parse(typeof(Days), userInput); //Assigning the userInput to a new, Days type variable and attempting to parse enum
                    Console.WriteLine($"{day} is a legit day of the week!"); //Displaying a message when the userInput is valid
                    Console.ReadLine();
                    isValid = true; //Changing the state of the validity tracker
                }

                catch (ArgumentException ex) //Message when the userInput is invalid
                {
                    Console.WriteLine("Sorry, the day you entered is invalid!");
                }


                

            }
        }

        public enum Days //Creating the enum for data validation
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
