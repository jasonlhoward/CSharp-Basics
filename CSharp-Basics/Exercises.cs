using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class Exercises
    {
        //Note: for all these exercises, ignore input validation unless otherwise directed.Assume the user enters a value in the format 
        //    that the program expects. For example, if the program expects the user to enter a number, don't worry about validating if the 
        //    input is a number or not. When testing your program, simply enter a number.

        //1- Write a program and ask the user to enter a number.
        //    The number should be between 1 to 10. 
        //    If the user enters a valid number, display "Valid" on the console.
        //    Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }

        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public static void Exercise2()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 <= num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num1);
            }

        }

        //3- Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
        public static void Exercise3()
        {
            Console.Write("Enter the height of the picture: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the picture: ");
            int width = Convert.ToInt32(Console.ReadLine());
            if (height < width)
            {
                Console.WriteLine("landscape");
            }
            else
            {
                Console.WriteLine("portrait");
            }

        }
        //4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus 
        //    purely on the logic.Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a 
        //    car.If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed 
        //    limit, the program should calculate the number of demerit points.For every 5km/hr above the speed limit, 1 demerit points should 
        //    be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.
        public static void Exercise4()
        {
            int speedLimit = 60;
            
            Console.Write("Do you know fast you were going? ");
            int.TryParse(Console.ReadLine(), out int speed);    
            int demerits = (speed - speedLimit) / 5;

            if (speed < speedLimit)
                Console.WriteLine("Do you even know where the gas pedal is?");
            else if (speed == speedLimit)
                Console.WriteLine("Ok, move along.");
            else if (demerits == 0)
                Console.WriteLine("Watch your speed. Here's a warning.");
            else if (demerits < 12)
                Console.WriteLine("You just earned {0} demerits, leadfoot.", demerits);
            else
                Console.WriteLine("Your license is suspended!");
        }
    }
}
