using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!"); //Asking for user input
            string userInput = Console.ReadLine(); //Storing user input into a variable
            userInput += "\n*coming from the log file*"; //Some addition to the text to see it really comes back from the file and not just writing out the original user input
            File.WriteAllText(@"C:\CsharpDev\log.txt", userInput); //Writing the text out to the log file
            string import =
            File.ReadAllText(@"C:\CsharpDev\log.txt"); //Reading out the text from the file
            Console.WriteLine(import); //Displaying the imported text

            Console.ReadLine();
        }
    }
}
