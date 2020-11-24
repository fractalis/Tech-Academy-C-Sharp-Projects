using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_168
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInsuranceCalculator carInsuranceCalculator = new CarInsuranceCalculator();
            carInsuranceCalculator.PromptUser();

            Console.WriteLine("Qualified?");
            Console.WriteLine(carInsuranceCalculator.IsQualified().ToString());

            Console.ReadLine();
        }
    }
}
