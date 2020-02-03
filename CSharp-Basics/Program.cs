using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person john = new Person();
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            /*
            Structures vs Classes
            
            Primitive data types are Structures and take no more than 8 bytes

            Non-primitives are Classes

            Structures -> Value Types
            Classes -> Reference Types

            Value Types
                - Allocated on stack
                - Memory allocation is done automatically
                - immediately removed when out of scope

            Reference Types
                - YOU need to allocate memory (i.e. the "new" keyword)
                - Memory allocated on heap
                - Garbage collected by CLR
            */
        }
    }
}
