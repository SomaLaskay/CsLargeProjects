using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {
            // INT ARRAY
            int[] intArray = { 12, 23, 34, 45, 56 }; //Creating the array of integers.

            Console.WriteLine("Choose a number between 0 and 4!"); //Asking for input of the user.
            int answer1 = Convert.ToInt32(Console.ReadLine()); //Converting and storing the answer.
            bool isCorrect = answer1 >= intArray.Length; //Evaluating the answer by comparing it to the length of the array.

            if (isCorrect) //Branching for exception handling, based on bool value
            {
                Console.WriteLine("Nope."); //Error message if the user's answer is incorrect.
            }
            else //In case the answer evaluates to true.
            {
                Console.WriteLine(intArray[answer1]); //Printing out the value on the index the user requested.
            }

            // STRING ARRAY
            string[] meats = new string[] { "Chicken", "Chorizo", "Steak" }; //Creating the array of strings.

            Console.WriteLine("\nChoose a number between 0 and 2"); //Asking for input of the user.
            int answer2 = Convert.ToInt32(Console.ReadLine()); //Converting and storing the user's answer.

            Console.WriteLine(meats[answer2]); //Printing out the value on the index requested by the user.


            Console.ReadLine(); //Keeping the window open.

        }
    }
}
