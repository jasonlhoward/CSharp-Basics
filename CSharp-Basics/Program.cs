﻿using System;

namespace CSharp_Basics
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method.ToString()); // Express     

            // Casting the shipping method key to the value
            Console.WriteLine((int)method); // 3

            // Casting the shipping method value to the key
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // Express

            // Parse the method name (as a string) to the method value (i.e. Express)
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod); // Express
        }
    }
}
