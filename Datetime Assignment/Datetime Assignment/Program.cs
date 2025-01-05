using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDT = DateTime.Now; //Assigning the current DateTime to a variable
            Console.WriteLine($"The current Date and Time is {currentDT}."); //Writing out the current DateTime
            Console.WriteLine("\nHow many hours you need to arrive?"); //Asking the user how many hours they need to arrive
            int userDelay = Convert.ToInt32(Console.ReadLine()); //Converting and storing the answer into a variable
            Console.WriteLine($"\nYour ETA is confirmed: {currentDT.AddHours(userDelay)}."); //Writing out the calculated new DateTime as an answer
            
            Console.ReadLine();
        }
    }
}
