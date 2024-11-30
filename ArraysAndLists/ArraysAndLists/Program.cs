using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main()
        {

            int[] intArray = { 12, 23, 34, 45, 56 };

            Console.WriteLine("Choose a number between 0 and 4!");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            bool isCorrect = answer1 >= intArray.Length;

            if (isCorrect)
            {
                Console.WriteLine("Nope.");
            }
            else
            {
                Console.WriteLine(intArray[answer1]);
            }

            string[] meats = new string[] { "Chicken", "Chorizo", "Steak" };

            Console.WriteLine("\nChoose a number between 0 and 2");
            int answer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(meats[answer2]);


            Console.ReadLine();

        }
    }
}
