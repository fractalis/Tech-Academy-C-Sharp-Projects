using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_153
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage = "System Error: Network device is not connected.";
            string errorHelpLink = "\nhttp://example.com/error-messages/network-device-not-connected";

            string errorOutput = errorMessage + errorHelpLink;

            Console.WriteLine(errorOutput);
            Console.ReadLine();

        }
    }
}
