using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_267
{
    // Step 1.1 Create a struct Called Number and Given it the property "Amount" and have it be of data type decimal
    public struct Number
    {
        // Declare our property, we want this to be immutable once we declare
        // it so we are just declaring a getter and a private set.
        public decimal Amount { get; private set; }

        /// <summary>
        /// Constructor that allows us to create an instance of the struct with the given amount.
        /// </summary>
        /// <param name="amount"></param>
        public Number(decimal amount)
        {
            Amount = amount;
        }
    }
}
