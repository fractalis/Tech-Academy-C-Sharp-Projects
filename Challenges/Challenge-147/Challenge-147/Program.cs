using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_147
{
    class Program
    {
        static void AddNumbers()
        {
            int monsterStrength = 10;
            int strModifier = 2;

            int totalStrength = monsterStrength + strModifier;

            Console.WriteLine("Monster Total strength: " + totalStrength.ToString());
        }

        static void SubtractNumbers()
        {
            int customersGained = 10;
            int customersLost = 5;
            int netCustomers = customersGained - customersLost;

            Console.WriteLine("Net Customers: " + netCustomers.ToString());
        }

        static void MultiplyNumbers()
        {
            float gravityModifier = 0.9f;
            float gravityScale = -9.81f;
            float totalGravity = gravityModifier * gravityScale;
            Console.WriteLine("Total Gravity: " + totalGravity.ToString());
        }

        static void DivideNumbers()
        {
            int gradesTotal = 290;
            int testsTotal = 3;

            float average = (float)gradesTotal / testsTotal;
            Console.WriteLine("Average: " + average.ToString());
        }

        static void Main(string[] args)
        {
            AddNumbers();
            SubtractNumbers();
            MultiplyNumbers();
            DivideNumbers();
            Console.ReadLine();
        }
    }
}
