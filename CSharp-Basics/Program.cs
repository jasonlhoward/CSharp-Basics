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
            string firstName = "Jason";
            string lastName = "Howard";
            string name = firstName + " " + lastName;
            name = string.Format("{0} {1}", firstName, lastName);

            var numbers2 = new int[3] { 1, 2, 3 };
            var list = string.Join(",", numbers2);
            Console.WriteLine(list);

            firstName = "Jason";
            char firstNameStartsWith = firstName[0]; // "J"

            /*
            Escape characters:
            \n  newline
            \t  tab
            \\  backslash
            \'  single quote
            \"  double quote
            */

            // Verbatim strings:
            string path = "c:\\users\\jason\\folder1";
            path = @"c:\users\jason\holder1";

            var unreadableStr = "Hi John,\nLook into the following paths:\nc:\\folder1\\folder2\nc:\\users\\john";
            Console.WriteLine(unreadableStr);

            var verbatimStr = @"Hi John,
Look into the following paths:
c:\folder1\folder2
c:\users\john";
            Console.WriteLine(verbatimStr);
        }
    }
}
