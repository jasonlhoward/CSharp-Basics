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
            // Implicit Type Conversion
            byte a = 1;
            int b = a;  // because i is an int and bytes hold a subset of the integer range
            Console.WriteLine(a);
            Console.WriteLine(b);

            // What happens the other way around?
            // This will result in a "Cannot implicitly convert 'int' to 'byte'" error
            // The reason for this is that data loss is possible.
            // An int is 4 bytes and a byte is, well, 1 byte.
            // 1000 = 00000000 00000000 00000011 11101000
            // To stuff 1000 into 1 byte, the first 2 bytes are simply removed, what's left is 232
            // 232 = 00000000 00000000 00000000 11101000
            int c = 1000;
            //byte d = c; // I commented this line so this would compile

            // Explicit Conversion

            // CASTING
            // Using explicit conversion tells the complier that you're aware there could be data loss but you want to do it anyway.
            // Explicit conversion can only be used on similar data types like int->byte or long->int
            int e = 25;
            byte f = (byte)e;
            Console.WriteLine(e);
            Console.WriteLine(f);
            // Back to the earlier issue where you're converting from an int not in the byte range
            int g = 1000;
            byte h = (byte)g; // -> yields 232
            Console.WriteLine(h);

            // CONVERTING
            string number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);

            //byte j = Convert.ToByte(number); // this will throw an exception at runtime so...
            try
            {
                byte j = Convert.ToByte(number);
            }
            catch (Exception) //OverflowException
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string boolStr = "true";
                bool isTrue = Convert.ToBoolean(boolStr);
                Console.WriteLine(isTrue);
            }
            catch (Exception) //OverflowException
            {
                Console.WriteLine("The string 'true' cannot be converted to a Boolean");
            }
        }
    }
}
