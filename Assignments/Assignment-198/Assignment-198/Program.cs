using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_198
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListHelper arrayListHelper = new ArrayListHelper();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Displaying String Array");
            arrayListHelper.DisplayStringArray();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Displaying Int Array");
            arrayListHelper.DisplayIntArray();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Displaying List of Strings");
            arrayListHelper.DisplayListOfStrings();
            Console.ReadLine();
        }
    }
}
