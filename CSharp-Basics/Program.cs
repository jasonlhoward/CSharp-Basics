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

            // Trim
            var fullName = "Jason Howard ";
            fullName = fullName.Trim();  // "Jason Howard"

            // ToUpper
            fullName = "Jason Howard ";
            fullName = fullName.Trim().ToUpper(); // "JASON HOWARD"

            // ToLower
            fullName = "Jason Howard ";
            fullName = fullName.Trim().ToLower(); // "jason howard"

            // Split
            fullName = "Jason Howard";
            var names = fullName.Split(' ');  // ["Jason"]["Howard"]
            firstName = names[0]; // "Jason"
            lastName = names[1];  // "Howard"

            // Replace
            fullName = "Mosh Hamedani";
            fullName = fullName.Replace("Mosh", "Moshfegh");  // "Moshfegh Hamedani"

            // Validation
            if (String.IsNullOrWhiteSpace("\n"))
                Console.WriteLine("Invalid");

            // Convert to Number (not sure it can be converted?)
            var ageString = "25";
            if (int.TryParse(ageString, out int age))
                Console.WriteLine("Your age plus 10 years: " + (age + 10));

            // Convert to Number (you know it can be converted)
            age = Convert.ToInt32(ageString);

            // Number to String
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
            Console.WriteLine(price.ToString("C2"));
            

            // Summarize a long string
            var sentence = "This is going to be a really really really really really really long sentence.";
            var summary = StringUtilities.Summarize(sentence, 25);
            Console.WriteLine(summary);

            // StringBuilder 
            var builder = new StringBuilder();

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            // can chain methods because a StringBuilder object returns itself
            builder
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('*', 10));

            var firstCharacter = builder[0];

            Console.WriteLine(builder);

        }
    }
}
