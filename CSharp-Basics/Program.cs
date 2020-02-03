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
            /*
             *  Arrays - sort of like a list in Python
             *
            int[]
                We will be creating an array that contains integers
                * this can be replaced with "var"
            numbers
                called numbers
            = new
                We need to create an instance of Array
            int[3]
                Please allocate enough memory to hold 3 integers 
            */
            int[] numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            /*
            outputs:
            1
            0
            0
            When an array is created, each element of the array is initialized 
            with the default value of the data type.
            */

            var flags = new bool[3];
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            /*
            outputs:
            False
            False
            False
            */

            var names = new string[3] { "Jack", "Jason", "Rachel" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names[0] = "Matthew";
            Console.WriteLine(names[0]);
            /*
            outputs:
            Jack
            Jason
            Rachel
            Matthew
            */
        }
    }
}
