using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_198
{
    class ArrayListHelper
    {
        /// <summary>
        /// Constructs a string array, then prompts the user to view a
        /// particular index of that array.
        /// </summary>
        public void DisplayStringArray()
        {
            string[] customerNames =
            {
                "Joe Summers",
                "Robert Perry",
                "Henry Byrne",
                "Jaylen Cobb",
                "Kate Davidson",
                "Naomi Reid",
                "Georgina Fox"
            };

            int index = GetIndexFromUser<string>(customerNames);
            Console.WriteLine($"Customer Name: {customerNames[index],20}");
        }

        /// <summary>
        /// Constructs an integer array, then prompts the user to view a
        /// particular index of that array.
        /// </summary>
        public void DisplayIntArray()
        {
            int[] productQuantities =
            {
                500,
                250,
                75,
                90,
                0,
                100,
                1249
            };

            int index = GetIndexFromUser<int>(productQuantities);
            Console.WriteLine($"Product Quantity: {productQuantities[index],20}");
        }

        /// <summary>
        /// Constructs a list of strings, then prompts the user to view
        /// a particular index of that list.
        /// </summary>
        public void DisplayListOfStrings()
        {
            List<string> abilityNames = new List<string>();
            abilityNames.Add("Arcane-fire Volley");
            abilityNames.Add("Illusion");
            abilityNames.Add("Reanimate");
            abilityNames.Add("Alteration Hymn");
            abilityNames.Add("Aura of Storms");
            abilityNames.Add("Sunlight Burst");
            abilityNames.Add("Electric Flux");

            int index;
            while(true)
            {
                index = GetUserInputAsInteger($"Please enter an index to view (between 0 and {abilityNames.Count - 1})");
                
                if (index < 0 || index >= abilityNames.Count)
                {
                    Console.WriteLine("Sorry, please enter another index.");
                    continue;
                }
                // User entered a valid index, break out of while loop
                break;
            }

            Console.WriteLine($"Ability Name: {abilityNames[0],20}");
        }

        /// <summary>
        /// Gets an index from the user, retrying if they exceed the bounds of the array we passed in
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="arr">The array of values we want to get an index for</param>
        /// <returns>The index the user entered, constrained within the bounds of the size of the array</returns>
        public int GetIndexFromUser<T>(T[] arr)
        {
            while(true)
            {
                int index = GetUserInputAsInteger($"Please enter an index to view (between 0 and {arr.Length - 1})");

                if (index < 0 || index >= arr.Length)
                {
                    Console.WriteLine("Sorry, please enter another index.");
                    continue;
                }
                // User entered a valid index, return the index.
                return index;
            }
        }



        /// <summary>
        /// Gets an integer value from the user.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user</param>
        /// <returns>The integer value the user entered</returns>
        private int GetUserInputAsInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Sorry, you entered an invalid value. Please try again.");
                    continue;
                }
            }
        }
    }
}
