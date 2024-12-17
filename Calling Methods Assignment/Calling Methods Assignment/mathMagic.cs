using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    public class mathMagic //Creating public class
    {
        public static int square (int usrInpt) //Creating method 1
        {
            int result = usrInpt * usrInpt; //Carrying out operations
            return result; //Returning with the results
        }

        public static int cube (int usrInpt) //Creating method 2
        {
            int result = usrInpt * usrInpt * usrInpt; //Carrying out operations
            return result; //Returning with the results
        }

        public static int multiRand (int usrInpt) //Creating method 3
        {
            Random myRand = new Random(); //Creating a random number
            int result = usrInpt * myRand.Next(5, 50); //Carrying out operations
            return result; //Returning with the results
        }


    }
}
