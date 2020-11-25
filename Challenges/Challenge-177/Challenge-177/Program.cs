using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_177
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomGuess = random.Next(101);
            int countTries = 0;

            // Challenge: Utilize the greater than operator and display the output to the console
            while(true)
            {
                int userGuess = GetUserInputAsInteger("Guess the number between 0 and 100");
                countTries += 1;
                if (userGuess > randomGuess)
                {
                    Console.WriteLine("Too High, go lower.");
                }
                else if (userGuess < randomGuess)
                {
                    Console.WriteLine("Too Low, go Higher.");
                }
                else
                {
                    Console.WriteLine($"You guess correctly in {countTries} tries!");
                    break;
                }
            }

            // Challenge: Utilize the lesser than or equal to operator and display output to the console
            int userAge = GetUserInputAsInteger("What is your age?");
            if(userAge <= 17)
            {
                Console.WriteLine("Sorry, you're unable to vote.");
            }
            else
            {
                Console.WriteLine("Thank you for voting!");
            }
        }

        static int GetUserInputAsInteger(string message)
        {
            Console.WriteLine(message);
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter a valid number: ");
                    continue;
                }
            }
        }
    }
}
