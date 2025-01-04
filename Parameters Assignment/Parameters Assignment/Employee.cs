using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Employee<T> //Making the class generic by "<T>"
    {
        public List<T> things { get; set; } = new List<T>(); //Creating a property with a type of generic list
    }
}
