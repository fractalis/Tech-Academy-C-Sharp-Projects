using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_226
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();

            // Step 1.2 - Instantiate the class and call the one method, passing in an integer. Display the result to the screen.
            Random random = new Random();
            int nextInt = random.Next(1000);
            Console.WriteLine($"{nextInt} added to a random number is: {simpleCalculator.Calculate(nextInt)}");

            // Step 1.4 - Instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            decimal baseValue = 100M;
            Console.WriteLine($"{baseValue} cubed is equal to: {simpleCalculator.Calculate(baseValue)}");

            // Step 1.6 - Instantiate the class and call the third method, passing in a string that equates to an integer. Display
            // the result to the screen.
            string randomNumberStr = random.Next(100).ToString();
            Console.WriteLine($"{randomNumberStr} multiplied by a random number is: {simpleCalculator.Calculate(randomNumberStr)}");

            Console.ReadLine();
        }
    }
}
