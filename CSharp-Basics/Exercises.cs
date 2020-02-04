using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Exercises
    {
        //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
        public static void Exercise1()
        {
            int cntDivisibleBy3 = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                    cntDivisibleBy3++;
            }
            Console.WriteLine(cntDivisibleBy3 + " numbers between 1 and 100 are divible by 3");
        }



        //2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered 
        //numbers and display it on the console.
        public static void Exercise2()
        {
            int total = 0;
            while (true)
            {
                Console.Write("Enter a number or 'ok' to exit: ");
                var input = Console.ReadLine().ToLower();
                if (input.Equals("ok") || String.IsNullOrWhiteSpace(input))
                    break;

                int number;
                bool isInt = Int32.TryParse(input, out number);
                if (!isInt)
                    break;

                total += number;

            }
            Console.WriteLine("Total: " + total);
        }



        //3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. For example, 
        //if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void Exercise3()
        {
            Console.Write("Enter an integer: ");
            var input = Console.ReadLine();
            
            int number;
            var isInt = Int32.TryParse(input, out number);
            if (!isInt)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            long factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }

            Console.WriteLine(input + "! = " + factorial);
        }



        //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, 
        //display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the 
        //console first.)
        public static void Exercise4()
        {
            var random = new Random();
            int pick = random.Next(1, 10);

            Console.WriteLine(pick);
            
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Pick a number between 1 and 10: ");
                var input = Console.ReadLine();

                int number;
                var isInt = Int32.TryParse(input, out number);

                if (isInt && number == pick)
                {
                    Console.WriteLine("You won!");
                    return;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("You lost!");
            return;

        }



        //5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the 
        //console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static void Exercise5()
        {
            Console.Write("Enter a series of numbers separated by a comma: ");
            var input = Console.ReadLine();
            var items = input.Split(',');
            int largest = int.MinValue;
            foreach (var item in items)
            {
                var isInt = Int32.TryParse(item.Trim(), out int number);
                if (!isInt) return;

                largest = (number > largest) ? number : largest;
            }
            Console.WriteLine(largest);
        }
    }
}
