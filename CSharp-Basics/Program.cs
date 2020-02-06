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
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("ToLongDateString: " + now.ToLongDateString());       // Thursday, February 6, 2020
            Console.WriteLine("ToShortDateString: " + now.ToShortDateString());     // 2/6/2020
            Console.WriteLine("ToLongTimeString: " + now.ToLongTimeString());       // 11:08:15 AM
            Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString());     // 11:08 AM
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm"));                    // 2020-02-06 11:08

            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);   // 1 hour, 2 min, 3 sec
            var timeSpan1 = new TimeSpan(1, 0, 0);  // 1 hour, 0 min, 0 sec
            var timeSpan2 = TimeSpan.FromHours(1);  // same as previous

            var startDt = DateTime.Now;
            var endDt = DateTime.Now.AddMinutes(2);
            var duration = endDt - startDt;             // result is a TimeSpan
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add/Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Add 8 minutes to orginal timespan - now will be 10 minutes
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // Subtract 2 minutes from orginal timespan - now will be 10 minutes
        }
    }
}
