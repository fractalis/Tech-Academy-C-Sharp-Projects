using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_140
{
    class Program
    {
        static void InitializeDisplay()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void Main(string[] args)
        {
            // Initialize our display
            InitializeDisplay();

            // Create a new instance of our DailyReport
            DailyReport dr = new DailyReport();

            // Run the report
            dr.RunReport();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
