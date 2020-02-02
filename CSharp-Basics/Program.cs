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
            // Variables
            //  Named values that are mutable(the variable value can be changed)
            int myNumber;
            myNumber = 1;
            myNumber = 2;

            // Constants
            //  Named values that are immutable(the value cannot be changed)
            const float Pi = 3.14f;

            // Code Convention
            //  Use camelCase for variables
            //  Use PascalCase for constants
            //  Must start with a letter (or underscore)
            //  Can contain letters, numbers and underscore

            // Primitive Types

            // 8 bit (0 - 255)
            byte myByte = 1;

            // 32 bit 
            int myInt = 1;

            // 64 bit
            long myLong = 1;

            // Real Numbers (in ascending precision)
            float myFloat = 1.1f;
            double myDouble = 1.1;
            decimal myDecimal = 1.1m;

            // must use single quotes
            char myChar = 'J';

            // must use double quotes
            string myString = "Jason";

            //
            bool myBool = true;

            // Array
            // Enum
            // Class


            // rather than explicitly telling c# the variable type
            // can use "var" and C# complier will determine which is best
            // hovering over the variable name will show the type
            // hovering over the "var" keyword will show the .NET character type

            var number = 5;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Jason";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

             // the complier will not let you reassign the value of a constant
            // Pi = 5;
            Console.WriteLine(Pi);
        }
    }
}
