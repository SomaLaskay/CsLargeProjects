using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public interface IQuittable //Creating this interface for other classes inherit from
    {
        void Quit(); //Creating the Quit method, so we can test the inheritence
    }
}
