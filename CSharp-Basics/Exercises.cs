using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Exercises
    {
        //Note: For any of these exercises, ignore input validation unless otherwise directed.Assume the user enters values in the format that 
        //the program expects.



        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.

        public static void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                    break;
                names.Add(name);
            }
            if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            else if (names.Count >= 3)
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count-2);
            else
                Console.WriteLine("No one likes your post, LOSER!");
            return;
        }

        //2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. 
        //Display the reversed name on the console.
        public static void Exercise2()
        {
            var name = Prompt("Enter a name: ");
            Console.WriteLine(ReverseString(name));

        }

        public static string ReverseString(string input)
        {
            return String.Join("", input.ToCharArray().Reverse());
        }

        public static string Prompt(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().Trim();
        }



        //3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, 
        //display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        public static void Exercise3()
        {
            var numbers = new int[5];
            var ndx = 0;
            while (ndx <= 4)
            {
                int num = Convert.ToInt32(Prompt("Enter a number: "));
                if (Array.IndexOf(numbers, num) >= 0)
                {
                    Console.WriteLine("You've already entered that number. Try again!");
                    continue;
                }
                else
                {
                    numbers[ndx] = num;
                    ndx++;
                }
            }
            Console.WriteLine("You've entered the following numbers: ");
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }



        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
        //Display the unique numbers that the user has entered.

        // get input - string
        // if input == "Quit" -> exit
        // if input is int -> array
        // continuous input
        // display array but only unique
        //      loop through array
        //      if first and last index of a value is the same then display

        public static void Exercise4()
        {
            var nums = new List<int>();
            while (true)
            {
                var input = Prompt("Enter a number (or 'Quit' to exit): ");
                if (input.ToLower() == "quit") { break; }
                nums.Add(Convert.ToInt32(input));
            }
            nums.Sort();
            Console.WriteLine("The unique numbers you've entered: ");
            foreach (var num in nums)
            {
                if (nums.IndexOf(num) == nums.LastIndexOf(num))
                    Console.WriteLine(num);
            }
        }

        //5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less 
        //than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
        public static void Exercise5()
        {
            var input = Prompt("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid List");
                return;
            }
            
            var nums = input.Split(',').Select(Int32.Parse).ToArray();
            if (nums.Length < 5)
            {
                Console.WriteLine("Invalid List");
                return;
            }

            Console.WriteLine("The 3 smallest numbers:");
            Array.Sort(nums);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(nums[i]);
            }
            
        }


    }
}
