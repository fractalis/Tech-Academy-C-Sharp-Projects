using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_185
{
    public class ShippingCalculator
    {
        private const int MAX_DIMENSIONS = 50;
        private const int MAX_WEIGHT = 50;

        public int PackageWeight { get; private set; }
        public int PackageHeight { get; private set; }
        public int PackageWidth { get; private set; } 
        public int PackageLength { get; private set; }
        public int PackageDimensions {
            get {
                return PackageHeight + PackageWidth + PackageLength;
            }
        }
        public decimal TotalCost
        {
            get
            {
                return (PackageHeight * PackageWidth * PackageLength * PackageWeight) / 100.0m;
            }
        }

        public ShippingCalculator()
        {

        }

        /// <summary> 
        /// Runs through the calculator, collecting the weight, dimensions, and then validating and printing the cost.
        /// </summary>
        public void RunCalculator()
        {
            // Get weight
            GetWeight();

            // Validate that the weight is within the parameters specified
            if (ValidateWeight())
            {
                GetDimension("width", "PackageWidth");
                GetDimension("height", "PackageHeight");
                GetDimension("length", "PackageLength");

                if (ValidateDimensions())
                {
                    Console.WriteLine($"Your estimated total for shipping this package is: {TotalCost:C2}");
                    Console.WriteLine("Thank you!");
                }
            }
        }

        /// <summary>
        /// Gets the weight of the package
        /// </summary>
        private void GetWeight()
        {
            PackageWeight = GetUserInputAsInteger("Please enter the package weight: ");
        }

        /// <summary>
        /// Gets the dimensions given by Dimension Name, setting the Property given by Property Name on the object reference.
        /// </summary>
        /// <param name="dimensionName">The dimension that we are trying to set</param>
        /// <param name="propertyName">The property name on the object to which we want to set the value</param>
        private void GetDimension(string dimensionName, string propertyName)
        {
            int dimension = GetUserInputAsInteger($"Please enter the package {dimensionName}");
            this.GetType().GetProperty(propertyName).SetValue(this, dimension);           
        }

        /// <summary>
        /// Validates that the dimensions are within the parameters specified
        /// </summary>
        /// <returns></returns>
        private bool ValidateDimensions()
        {
            if (PackageDimensions > MAX_DIMENSIONS)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validates that the weight is within the parameters specified.
        /// </summary>
        /// <returns></returns>
        private bool ValidateWeight()
        {
            if (PackageWeight > MAX_WEIGHT)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets the user input as an integer, looping until a valid input has been entered
        /// </summary>
        /// <param name="prompt">The prompt to which to display to the user</param>
        /// <returns>The number the user entered</returns>
        private int GetUserInputAsInteger(string prompt)
        {
            Console.WriteLine(prompt);
            // While we have an invalid input, continue looping.
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid input, please enter a valid number: ");
                    continue;
                }
            }
        }
    }
}
