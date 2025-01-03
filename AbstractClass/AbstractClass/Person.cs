using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person //Abstract class created
    {
        public string firstName { get; set; } //Creating properties
        public string lastName { get; set; } //Creating properties

        public abstract void SayName(); //Creating the abstract method to ensure we are going to define it in the inherited classes
    }
}
