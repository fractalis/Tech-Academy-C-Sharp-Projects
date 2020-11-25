using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_204
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignmentHelper assignmentHelper = new AssignmentHelper();

            // This is Part 1 of the Assignment, Asking the user for some text
            // appending it to an array of strings, then printing it out.
            assignmentHelper.AskUserForText();
            assignmentHelper.PrintBusinessNames();

            Console.WriteLine("------------------");
            bool isRunning = true;

            // This is part 2 of the assignment
            // This demonstrates an infinite loop that has a condition
            // that causes it to eventually terminate (when the user enters Q)
            while(isRunning)
            {
                char userInput = GetUserInputAsChar();
                switch(userInput)
                {
                    case 'Q':
                        isRunning = false;
                        break;
                    case 'P':
                        assignmentHelper.PrintBusinessNames();
                        break;
                    default:
                        Console.WriteLine("Invalid menu item, please try again.");
                        break;
                }
            }

            // This is for part 3 of the assignment
            // The method here demonstrates both kind of loops, one using the
            // "<" operator and the other using the "<=" operator.
            Console.WriteLine("------------------");
            assignmentHelper.DemonstrateLoops();

            Console.WriteLine("------------------");
            // This is for part 4 of the assignment. It demonstrates
            // a list of strings that are unique and allows the user to
            // search for a string, displaying the index that string
            // matches if it exists.
            assignmentHelper.DemonstrateStringList();
            Console.WriteLine("------------------");

            // This is for part 5 of the assignment, it demonstrates
            // a List of strings with two identical strings and allows
            // the user to search for a string, displaying each index that
            // matches.
            assignmentHelper.DemonstrateIdenticalStringList();
            Console.WriteLine("------------------");
            

            // This is for part 6 of the assignment, it demonstrates
            // a List of strings with two identical strings and iterates
            // through, printing whether or not it was the first occurence of
            // that particular string or else printing out the indices in which
            // that word has appeared.
            assignmentHelper.DemonstrateIdenticalStringAlreadyAppeared();

            Console.ReadLine();


        }

        static char GetUserInputAsChar()
        {
            while(true)
            {
                DisplayMenu();
                try
                {
                    return char.Parse(Console.ReadLine().ToUpper());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter a valid menu item.");
                    continue;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("(P)rint Businesses");
            Console.WriteLine("(Q)uit");
        }
    }
}
