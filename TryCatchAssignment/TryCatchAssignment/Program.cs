using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false; //Creating a boolean for exiting the while loop if the user input is valid

            while (!validAnswer)  //Staying in the while loop until the user gives a valid answer
            {
                try //Try part, the main code in case of a valid answer
                {
                    Console.WriteLine("What is your age?"); //Asking for the user's age
                    int userInput = Convert.ToInt32(Console.ReadLine()); //Storing and converting the user's answer

                    if (userInput <= 0) //Evaluating the answer for 0 or negative numbers
                    {
                        throw new ArgumentException("Age must be a positive number!"); //Throwing the ArgumentException                   
                    }

                    int birthYear = DateTime.Now.Year - userInput; //Calculating the year of birth
                    int ptcBirthYear = birthYear - 369; //Calculating the Phantom Time Conspiracy birth year
                    Console.WriteLine($"You born in {birthYear}.\nHowever, according to the Phantom Time Conspiracy,\nyou born in {ptcBirthYear}. How crazy is that? :)"); //Displaying results for the user
                    validAnswer = true; //Switching the boolean validator for exiting the loop            
                }
                catch (ArgumentException) //Catch of the ArgumentException
                {
                    Console.WriteLine("The age cannot be 0 or negative number."); //Error message
                }
                catch (Exception) //Catch of any default exceptions
                {
                    Console.WriteLine("Something is wrong. Try again please."); //Error message
                }
                Console.ReadLine();

            }

            






        }
    }
}
