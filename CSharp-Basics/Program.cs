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
            // Arithmetic
            // postfix increment
            int a = 1;
            int b = a++;    // b is assigned to the value of a and then a is incremented
            Console.WriteLine("a = {0}, b = {1}", a, b); // -> a = 2, b = 1

            // prefix increment
            int c = 1;
            int d = ++c;    // c is incremented and then d is assigned to the value of c
            Console.WriteLine("c = {0}, d = {1}", c, d); // -> c = 2, d = 2

            // postfix decrement
            int e = 1;
            int f = e--;    // f is assigned to the value of e and then e is decremented
            Console.WriteLine("e = {0}, f = {1}", e, f); // -> e = 0, f = 1

            // prefix decrement
            int g = 1;
            int h = --g;    // g is decremented and then h is assigned the value of g
            Console.WriteLine("g = {0}, h = {1}", g, h); // -> g = 0, h = 0

            // Comparison
            // == is equal to
            // != not equal
            //  > greater than
            // >= greater than or equal to
            //  < less than
            // <= less than or equal to

            // Assignment
            // a = 1    -> set a equal to 1
            // a += 3   -> increment a by 3, then set this new value to a
            // a -= 3   -> decrement a by 3, then set this new value to a
            // a *= 3   -> multiply a by 3, then set this new value to a
            // a /= 3   -> divide a by 3, then set this new value to a
            // a = !b   -> set a = true is b is false, set a = false is b is true

            // Logical
            // a && b   -> evaluate to true if a and b are true
            // a || b   -> evaluate to true if a or b are true
            // a ! b    -> evaluate to true is a is not equal to b

            // Bitwise
            // & -> bitwise "and"
            // | -> bitwise "or"


            // Examples
            a = 1;
            b = 2;
            c = 3;

            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);
        }
    }
}
