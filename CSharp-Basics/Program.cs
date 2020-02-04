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
            // -----------------------------------------------------
            // if/else
            // -----------------------------------------------------
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }                
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }                

            // {} is optional if the line of code is one line
            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");

            // -----------------------------------------------------
            // ternary
            // -----------------------------------------------------
            bool isGoldCustomer = true;
            
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            // this can be rewritten as follows:
            price = (isGoldCustomer) ? 19.95f : 29.95f;

            // -----------------------------------------------------
            // switch
            // -----------------------------------------------------
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                
                case Season.Summer:
                    Console.WriteLine("It's summer");
                    break;
                
                default:
                    Console.WriteLine("Default output");
                    break;
            }

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion");
                    break;

                default:
                    Console.WriteLine("Default output");
                    break;
            }

            // -----------------------------------------------------
            // for loop
            // -----------------------------------------------------
            Console.WriteLine("Begin for loop:");
            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // -----------------------------------------------------
            // foreach - loop through strings, lists, arrays
            // -----------------------------------------------------
            Console.WriteLine("Begin foreach over string:");
            string name = "Jason Howard";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("Begin foreach over array:");
            var nums = new int[] { 1, 2, 3, 4 };
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }


            // -----------------------------------------------------
            // while
            // -----------------------------------------------------
            Console.WriteLine("Begin while:");
            var i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;                
            }

            // -----------------------------------------------------
            // break; // to break out of a loop
            // continue; // to go to the next iteration of the loop
            // -----------------------------------------------------

            Console.WriteLine("Begin demo using break in while loop");
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: " + input);
            }

            Console.WriteLine("Begin demo using continue in while loop");
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }                   

                break;
            }

            // -----------------------------------------------------
            // do while
            // -----------------------------------------------------
            Console.WriteLine("Begin do while:");
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            // -----------------------------------------------------
            // random
            // -----------------------------------------------------
            Console.WriteLine("Print 10 random integers:");
            var random = new Random();
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next());
            }

            Console.WriteLine("Print 10 random lowercase characters:");
            for (i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next((int)'a', (int)'z'));
            }
            Console.WriteLine();

        }
    }
}
