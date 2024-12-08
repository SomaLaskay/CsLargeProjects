using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Assignment Part I
            //Console.WriteLine("Assignment Part I\n"); //Title for results

            //string[] fruits = { "Strawberry", "Peach", "Cherry", "Apple" }; //1D array of strings

            //Console.WriteLine("What are we cooking from fruits?"); //Asking for input
            //string userInput = Console.ReadLine(); //Storing input

            //for (int i = 0;  i < fruits.Length; i++) //Iterating through the array
            //{
            //    fruits[i] += "-" + userInput; //Updating the strings with the user's input
            //}

            //foreach (string fruit in fruits) //Printing out each updated string, 1 by 1
            //{
            //    Console.WriteLine(fruit);
            //}



            ////Assignment Part II
            //Console.WriteLine("\nAssignment Part II\n"); //Title for results
            //int counter = 0; //Counter for the loop

            //while (counter < fruits.Length) //Loop for creating infinite loop
            //{
            //    Console.WriteLine("Infinite: " + fruits[counter]); //Writing out the result until the condition is met
            //    counter++; //Infinite loop fixed
            //}

            ////Assignment Part III ("<" operator was used in Part II)
            //Console.WriteLine("\nAssignment Part III\n"); //Title for results
            //int counter2 = 0;
            //while (counter2 <= fruits.Length-1) //Loop for creating infinite loop
            //{
            //    Console.WriteLine("Less than or equals to: " + fruits[counter2]); //Writing out the result until the condition is met
            //    counter2++; //Infinite loop fixed
            //}

            ////Assignment Part IV
            //Console.WriteLine("\nAssignment Part IV\n"); //Title for results

            //List<string> desserts = new List<string>() { "cake", "cream", "mousse", "pie" };
            //Console.WriteLine("What dessert are you looking for?");
            //string dessertChosen = Console.ReadLine();
            //bool doesExist = true;
            //int resultIndex = 0;

            //for (int j = 0; j < desserts.Count; j++)
            //{
            //    if (desserts[j] == dessertChosen)
            //    {
            //        resultIndex = j;
            //        doesExist = true;
            //        break;
            //    }
            //    else
            //    {
            //        doesExist = false;
            //    }
            //}

            //if (!doesExist)
            //{
            //    Console.WriteLine("Sorry, " + dessertChosen + " is not on the list.");
            //}
            //else
            //{
            //    Console.WriteLine("The index of the item you're searching for is " + resultIndex);
            //}

            ////Assignment Part V
            //Console.WriteLine("\nAssignment Part V\n"); //Title for results

            //List<string> cities = new List<string>() { "London", "Budapest", "Tokyo", "New York", "Tokyo"}; //Creating the list
            //Console.WriteLine("Choose one from the list below by it's number!"); //Asking for user input
            //string inputCity = Console.ReadLine(); //Storing the input
            //bool matchFound = false; //Logical switch for tracking whether the search was successful

            //for (int i = 0; i < cities.Count; i++) //Iterating through the list
            //{
            //    if (cities[i] == inputCity) //Branching for printing out indicies if there's a match
            //    {
            //        Console.WriteLine(i);
            //        matchFound = true; //Toggle the logical switch if there's a match
            //    }
            //}

            //if (!matchFound) //Checking the status of the logical switch
            //{
            //    Console.WriteLine("Not on the list!"); //Telling the user that there was no match
            //}

            //Assignment Part VI
            Console.WriteLine("\nAssignment Part VI\n"); //Title for results

            List<string> zones = new List<string>() { "alpha", "bravo", "charlie", "bravo", "delta", "echo", "alpha", "foxtrot", "echo" }; //Creating a list with at least 2 identical strings
            List<string> register = new List<string>(); //Register list for checking redundancy

            foreach (string zone in zones) //Loop to iterate through the original list and check the values one by one
            {
                Console.WriteLine(zone); //Writing out the current step
                if (register.Contains(zone)) //Checking if it already exists
                {
                    Console.WriteLine("This zone EXISTS!"); //Message if exists
                }
                else
                {
                    Console.WriteLine("This zone is NEW!"); //Message if it's new
                    register.Add(zone); //Adding the value to the register, so we can check if exists
                    //I'd only add the values to the register once, so I could also write out the unique values 
                }
            }

            Console.WriteLine("Register list: "); //Writing out the list of the unique values only
            foreach (string x in register) //Iterating through the list
            {
                Console.WriteLine(x); //and writing them out one by one
            }


            Console.ReadLine(); //Keep the window open
        }
    }
}
