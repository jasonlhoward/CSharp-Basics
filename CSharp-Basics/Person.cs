using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Person
    {
        public string FirstName;
        public string LastName;

        /*
        public
            Access not limited
        void
            The method does not return a value
        Introduce
            The name of the method
        ()
            This method has no arguments        
        */

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is {0} {1}.", FirstName, LastName);
        }
    }
}
