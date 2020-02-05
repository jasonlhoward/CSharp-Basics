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

            
            // the long way to define an array
            //string[] names = new string[3] { "Jack", "Jason", "Rachel" };

            // the short way...
            var names = new[] { "Jack", "Jason", "Rachel", "Kieleigh", "Matthew" };

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

            // ----------------------------------------------------------
            // Rectangular 2D Array
            // ----------------------------------------------------------
            var matrix = new int[3, 5];

            var matrix2 = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };
            Console.WriteLine(matrix2[0, 0]); // 1
            Console.WriteLine(matrix2[1, 2]); // 8

            // ----------------------------------------------------------
            // 3D Array
            // ----------------------------------------------------------
            var colors = new int[3, 4, 5];

            // ----------------------------------------------------------
            // Jagged 2D Array (the number of columns vary for each row)
            // ----------------------------------------------------------
            var jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[5];
            jagged[2] = new int[3];
            jagged[0][0] = 1;

            // ----------------------------------------------------------
            // Useful methods
            // ----------------------------------------------------------

            // this was defined earlier...for reference
            //var names = new[] { "Jack", "Jason", "Rachel", "Kieleigh", "Matthew" };

            // Length
            Console.WriteLine("Length()-----------------------------");
            Console.WriteLine(names.Length);

            // IndexOf()
            Console.WriteLine("IndexOf()-----------------------------");
            var indexOfJason = Array.IndexOf(names, "Jason");
            Console.WriteLine(indexOfJason); // 1

            // Clear()
            Console.WriteLine("Clear()-----------------------------");
            // sets element(s) in an array to their default values
            // strings are nulled
            // ints are set to 0
            // bools are set to false
            Array.Clear(names, 0, 1);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Copy()
            Console.WriteLine("Copy()-----------------------------");
            var smallerNames = new string[3];
            Array.Copy(names, smallerNames, 3); //copied the first 3 elements from names into smallerNames
            // smallerNames will hold null, Jason, Rachel

            var anotherSmallerNames = new string[4];
            Array.Copy(names, 1, anotherSmallerNames, 0, 4);
            // anotherSmallerNames will hold Jason, Rachel, Kieleigh, Matthew
            foreach (var name in anotherSmallerNames)
            {
                Console.WriteLine(name);
            }

            // Sort()
            Console.WriteLine("Sort()-----------------------------");
            var arrNumbers = new[] { 1, 4, 7, 3, 5, 6 };
            Array.Sort(arrNumbers);
            foreach (var number in arrNumbers)
            {
                Console.WriteLine(number);
            }

            // Reverse()
            Console.WriteLine("Reverse()-----------------------------");
            Array.Reverse(arrNumbers);
            foreach (var number in arrNumbers)
            {
                Console.WriteLine(number);
            }

            // ----------------------------------------------------------
            // Lists
            // dynamically sized
            // ----------------------------------------------------------
            var aList = new List<int>();
            var bList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            bList.Add(8);
            bList.AddRange(new int[3] { 1, 2, 3 });
            foreach (var item in bList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("First index of 3: " + bList.IndexOf(3));
            Console.WriteLine("Last index of 3: " + bList.LastIndexOf(3));
            Console.WriteLine("Count: " + bList.Count);

            // Cannot modify a collection inside a foreach
            // The following code will cause an exception
            //Unhandled Exception: System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
            //   at System.ThrowHelper.ThrowInvalidOperationException(ExceptionResource resource)
            //   at System.Collections.Generic.List`1.Enumerator.MoveNextRare()
            //   at System.Collections.Generic.List`1.Enumerator.MoveNext()
            //   at CSharp_Basics.Program.Main(String[] args) in C: \Users\jason\Source\Repos\CSharp - Basics\CSharp - Basics\Program.cs:line 177
            //foreach (var number in bList)
            //{
            //    if (number == 1)
            //        bList.Remove(number);
            //}

            for (int i = 0; i < bList.Count; i++)
            {
                if (bList[i] == 1)
                    bList.Remove(bList[i]);
            }
            foreach (var number in bList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
