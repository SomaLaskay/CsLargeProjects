using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varsAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is " + yourname + "!");

            //Console.WriteLine("What is your favorite number?");
            //string favNum = Console.ReadLine();
            //int favNumInt = Convert.ToInt32(favNum);
            //int result = favNumInt + 5;
            //Console.WriteLine("Your fav number plus 5 is " + result);

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -25;
            char randomLetter = 'S';
            
            decimal moneyInBank = 100.5m;
            double heightInCm = 185.15335;
            float secondsLeft = 2.62f;

            short tempOnMars = -341;
            string myName = "Soma";

            int currentAge = 40;
            string myAge = currentAge.ToString();



            Console.WriteLine(randomLetter);
            

        }
    }
}
