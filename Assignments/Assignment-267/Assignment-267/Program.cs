using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_267
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.2 Create an object of data type Number and assign an amount to it.
            Number number = new Number(100_000M);

            // Step 1.3 Print this amount to the console.
            Console.WriteLine($"The amount is {number.Amount:C0}.");

            Console.ReadLine();
        }
    }
}
