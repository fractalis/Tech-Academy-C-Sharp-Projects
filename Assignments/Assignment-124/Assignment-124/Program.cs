using System;

namespace Assignment_124
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the Console Foreground and Background Color
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            // Print out welcome screen
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we're \"accounting\" on you!");

            // Wait for user input so we can see the message
            Console.Read();
        }
    }
}
