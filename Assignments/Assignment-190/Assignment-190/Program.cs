using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_190
{
    class Program
    {
        private static Dictionary<(string, string), Person> People = new Dictionary<(string, string), Person>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person Database");

            // This will demonstrate a `while` loop.
            AddPersonLoop();

            // This will demonstrate a `do-while` loop
            DisplayEmailAddresses();

        }

        /// <summary>
        /// Allows the user to display a list of email addresses for a specific person.
        /// </summary>
        static void DisplayEmailAddresses()
        {
            bool isRunning = true;

            // Execute the loop at least once
            do
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Who do you want to display an e-mail address for (or enter Q to quit)?");
                Console.WriteLine("-----------");
                DisplayPeople();
                string userInput = Console.ReadLine();
                if (userInput == "Q")
                {
                    isRunning = false;
                }

                // Split on space
                string[] nameArr = userInput.Split(' ');

                // If we don't have a first and last name, let's consider it invalid
                if(nameArr.Length != 2)
                {
                    Console.WriteLine("Invalid name");
                    continue;
                } else if(!People.ContainsKey((nameArr[0], nameArr[1]))) // Make sure persone exists in our dictionary
                {
                    Console.WriteLine("Person does not exist");
                    continue;
                }
                else
                {
                    // Get person from dictionary
                    Person person = People[(nameArr[0], nameArr[1])];
                    Console.WriteLine($"Email Addresses for: {person.ToString()}");
                    Console.WriteLine("-----------");
                    person.DisplayEmailAddresses();
                }

            }
            while (isRunning); // While user has not entered 'Q' to quit.


        }

        static void AddPersonLoop()
        {
            bool isRunning = true;

            // While program is still running
            while (isRunning)
            {
                // Display out menu
                DisplayMenu();
                // Get user input
                char userInput = char.Parse(Console.ReadLine());

                // Switch on user input
                switch (userInput)
                {
                    case 'A':
                        // Add a person
                        AddPerson();
                        break;
                    case 'D':
                        // Display all people
                        DisplayPeople();
                        break;
                    case 'E':
                        // Add an e-mail address for an existing person
                        AddEmailAddress();
                        break;
                    case 'Q':
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please select again.");
                        break;
                }
            }
        }

        /// <summary>
        /// Prompts user to add an email address for a specific person
        /// </summary>
        static void AddEmailAddress()
        {
            Console.WriteLine("Who do you want to add an e-mail address for?");
            DisplayPeople();
            string name = Console.ReadLine();
            string[] nameArr = name.Split(' ');

            // If we don't have a first and last name, lets consider it invalid.
            if(nameArr.Length != 2)
            {
                Console.WriteLine("Invalid name");
                return;
            }
            if(!People.ContainsKey((nameArr[0], nameArr[1]))) // Make sure person exists in our dictionary
            {
                Console.WriteLine("No such person exists");
                return;
            }

            // Get person from dictionary
            Person person = People[(nameArr[0], nameArr[1])];

            Console.WriteLine("Enter an email address: ");
            string email = Console.ReadLine();
            person.AddEmailAddress(email);
        }

        /// <summary>
        /// Displays each person that we've added so far.
        /// </summary>
        static void DisplayPeople()
        {
            Console.WriteLine("-----------");
            foreach (Person person in People.Values)
            {
                Console.WriteLine($"Person: {person.ToString()}");
            }
            Console.WriteLine("-----------");
        }

        /// <summary>
        /// Adds a new person to our collection
        /// </summary>
        static void AddPerson()
        {
            Console.WriteLine("Adding a new person");
            Console.WriteLine("-----------");
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();
            Person person = new Person(firstName, lastName);
            People.Add((firstName, lastName), person);
        }

        /// <summary>
        /// Displays the menu for the user
        /// </summary>
        static void DisplayMenu()
        {
            Console.WriteLine("(A)dd Person");
            Console.WriteLine("Add (E)mail Address");
            Console.WriteLine("(D)isplay People");
            Console.WriteLine("(Q)uit");
            Console.WriteLine("-----------");
        }
    }
}
