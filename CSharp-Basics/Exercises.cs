using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class Exercises
    {
    //Note: For all these exercises, ignore input validation unless otherwise specified.Assume the user provides input in the format 
    //that the program expects.

    //1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
    //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

        public static void Exercise1()
        {
            Console.Write("Enter some numbers separated by a dash: ");
            var nums = Console.ReadLine().Split('-').Select(Int32.Parse).ToArray();
            var change = new List<int>();
            if (nums.Count() < 3)
            {
                Console.WriteLine("Not Consecutive");
                return;
            }
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                change.Add(Change(nums[i], nums[i + 1]));
            }
            int totalChanges = Math.Abs(change.Sum());
            int totalChange = Math.Abs(nums[0] - nums[nums.Count() - 1]);
            if (totalChanges == totalChange)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        public static int Change(int num1, int num2)
        {
            if (num1 == num2)
                return 0;
            else if (num1 < num2)
                return -1;
            else
                return 1;
        }

        //2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an 
        //input, exit immediately; otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
        public static void Exercise2()
        {
            Console.Write("Enter some numbers separated by a dash: ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) { return; }
            var nums = input.Split('-').Select(Int32.Parse).ToArray();
            var list = new List<int>();

            foreach (var num in nums)
            {
                if (list.Contains(num))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
                list.Add(num);
            }

            Console.WriteLine("No duplicates");
        }

        //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59. 
        //If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
        public static void Exercise3()
        {
            Console.Write("Enter a time value in the 24-hour time format(e.g. 19:00): ");
            var time = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(time))
            {
                Console.WriteLine("Invalid Time");
                return; 
            }            
            var date = "2020-02-10";
            DateTime dateValue;
            if (DateTime.TryParse(date + " " + time, out dateValue))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid Time");
        }

        //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        public static void Exercise4()
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) { return; }
            
            var words = input.Split(' ');
            var builder = new StringBuilder();
            
            foreach (var word in words)
            {
                builder.Append(Formalize(word));
            }

            Console.WriteLine(builder.ToString());
        }

        public static string Formalize(string str)
        {
            str = str.ToUpper();
            return str[0] + str.Substring(1).ToLower();
        }

        //5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
        //So, if the user enters "inadequate", the program should display 6 on the console.
    }
}
