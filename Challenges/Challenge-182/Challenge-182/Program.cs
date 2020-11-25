using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_182
{
    class Program
    {
        static void Main(string[] args)
        {
            string userRole = "admin";
            int userSecurityLevel = 3;

            // Challenge: Use the Ternary Operator and Display output to the Console
            string authMessage = (userRole == "admin" && userSecurityLevel >= 3) ? "You are authorized for this area" : "You are an unauthorized user";
            Console.WriteLine(authMessage);

            Console.ReadLine();
        }
    }
}
