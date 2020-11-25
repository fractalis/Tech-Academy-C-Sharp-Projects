using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_185
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            ShippingCalculator shippingCalc = new ShippingCalculator();
            shippingCalc.RunCalculator();

            // Wait for user input so we can see the message before exiting
            Console.ReadLine();
        }
    }
}
