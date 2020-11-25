using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_204
{
    class AssignmentHelper
    {
        public string[] businessNames { get; private set; }

        public AssignmentHelper()
        {
            businessNames = new string[] { 
                "Petal Solutions", 
                "Void Corporation", 
                "Lemonnetworks", 
                "Rosecurity",
                "Enigmotors",
                "Hatchwares",
                "Auratronics"
             };
        }

        /// <summary>
        /// Demonstrates two types of for loops, using the "<" operator and the ">=" operator
        /// </summary>
        public void DemonstrateLoops()
        {
            List<Book> books = new List<Book>()
            {
                new Book("C# For Beginners", "183-8-12-148419-0", "Infinitas Publishing"),
                new Book("JavaScript Tips and Tricks", "182-9-12-149839-1", "Crystallic Productions"),
                new Book("Professional CSS3",  "181-7-10-199832-2", "Solstice Networks Publishing")
            };

            // Assignment Part 3.1 demonstrates a loop using the "<" operator.
            for( int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Title: {books[i].BookTitle}\tISBN: {books[i].BookISBN}\tPublisher: {books[i].BookPublisher}");
            }

            int booksToAdd = GetUserInputAsInteger("How many books do you want to add?");
            
            // Assignment Part 3.2 demonstrats a loop using the "<=" operator
            for( int booksAdded = 1; booksAdded <= booksToAdd; booksAdded++)
            {
                string title = GetUserInput("Enter a book title");
                string isbn = GetUserInput("Enter an ISBN:");
                string publisher = GetUserInput("Enter a publisher:");

                Book book = new Book(title, isbn, publisher);
                books.Add(book);
            }

        }

        /// <summary>
        /// Demonstrates a list of unique strings and allowing the user to
        /// search for a string and displaying the index of the string if
        /// a match was found in the list.
        /// </summary>
        public void DemonstrateStringList()
        {
            // Step 4.1 A list of strings where each item in the list is unique
            List<string> planetNames = new List<string>()
            {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Uranus",
                "Neptune"
            };

            // Step 4.2 Ask the user to input text to search for in the list
            string planetInput = GetUserInput("Please enter a planet to search for: ");
            bool matchFound = false;

            // Step 4.3 "A loop that iterates through the list..."
            foreach (var planet in planetNames.Select((value, i) => new { i, value }))
            {
                // If a match was found
                if (planet.value == planetInput)
                {
                    // Step 4.3 "...and then displays the index of the list that contains matching text on the screen"
                    Console.WriteLine($"Index of match: {planet.i}");
                    matchFound = true;

                    // Step 4.5 Add Code to the loop that stops it from executing once a match has been found
                    break;
                }
                
                // Part 4.4 Check to see if the user has entered text that isn't on the list, and if they did,
                // tells the user their input is not on the list.
                if(!matchFound && planet.i == (planetNames.Count-1))
                {
                    Console.WriteLine($"Sorry, {planetInput} is not in the list.");
                }
            }


        }

        /// <summary>
        /// Demonstrates two identical strings in a list, and allowing a user to input
        /// a string to search for the string and display the indices in which the string
        /// was found.
        /// </summary>
        public void DemonstrateIdenticalStringList()
        {
            // Step 5.1 "A list of strings that has at least two identical strings in the list..."
            List<string> companyNames = new List<string>()
            {
                "Lucent Coms",
                "Topiary Corporation",
                "Golden Road Corp",
                "Twilighttechnologies",
                "Golden Road Corp",
                "Cloudnite",
                "Monarctronics"
            };

            // Step 5.1 "... Ask the user to select text to search for in the list."
            string companyInput = GetUserInput("Please enter a company to search for: ");
            bool companyFound = false;

            // Step 5.2 Create a loop that iterates through the list and then display shte indices of the list that contain matching
            // text on the screen
            for (int i = 0; i < companyNames.Count; i++)
            {
                if (companyInput == companyNames[i])
                {
                    Console.WriteLine($"Matching index at {i}");
                    companyFound = true;
                }

                // Step 5.3 "Add code to the loop to check if the user put in text that isn't on the list..."
                if (i == (companyNames.Count) && !companyFound)
                {
                    // Step 5.3 "...and if they did, tells the user their input is not on the list."
                    Console.WriteLine("Company You searched for does not exist in the list");
                }
            }
        }

        /// <summary>
        /// Demonstrates two identical strings appearing in the same list, and printing each one
        /// and whether or not they've already appeared in the list.
        /// </summary>
        public void DemonstrateIdenticalStringAlreadyAppeared()
        {
            List<string> starList = new List<string>
            {
                "Gliese 412",
                "Gliese 832",
                "EV Lacertae",
                "Altair",
                "El Cancri",
                "Stein 2051",
                "Altair",
                "Sigma Draconis",
                "LP 816-60",
                "Sigma Draconis"
            };

            // Mapping of star to list of indices in which the word appeared
            Dictionary<string, List<int>> starMappingToIndex = new Dictionary<string, List<int>>();

            // Loop through each star, injecting the index into an anonymous type along with the actual string value
            foreach(var star in starList.Select((value, i) => new { value, i }))
            {
                // If our dictionary contains our key
                if(starMappingToIndex.ContainsKey(star.value))
                {
                    // Add the current index to the list of indices
                    starMappingToIndex[star.value].Add(star.i);
                    // Write out the list of indices the star has appeared at.
                    Console.WriteLine($"Star {star.value} appeared again at index {star.i} - Current Indices: [{String.Join(",", starMappingToIndex[star.value].ToArray())}]");
                }
                else
                {
                    // Else initialize the list to a new list with just the single index.
                    starMappingToIndex[star.value] = new List<int>() { star.i };
                    // Print out to the user the first occurrence of the star.
                    Console.WriteLine($"First occurrence of {star.value} at index {star.i}.");
                }
            }


        }

        private int GetUserInputAsInteger(string prompt)
        {
            Console.WriteLine(prompt);
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


        public void PrintBusinessNames()
        {
            for(int i = 0; i < businessNames.Length; i++)
            {
                Console.WriteLine(businessNames[i]);
            }
        }

        public void AskUserForText()
        {
            string input = GetUserInput("Please input some text: ");

            for (int i = 0; i < businessNames.Length; i++)
            {
                businessNames[i] += input;
            }
        }

        private string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
