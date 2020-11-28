using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_310
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.2 Create a variable using the keyword "var"
            var productList = new List<Product>
            {
                new Product("ASP.NET Core 3.1 For Professionals"),
                new Product("C# 7 And the .NET Framework For Beginners", "Covers version 7 of the C# language as well as the .NET Framework, for beginners to programming."),
                new Product
                {
                    ProductName = "Beginning C# Programming",
                    ProductDescription = "Introductory guide to C# programming covering the fundamentals of the syntax of the language and the .NET Framework",
                    ProductManufacturer = "Wolf Arts",
                    ProductPrice = 49.99M,
                },
                new Product
                {
                    ProductName = "Electronic Component Assortment, Resistors, Capacitors, Inductors, Diodes, Transistors, 2000 Pcs",
                    ProductDescription = "Includes 2000 pcs of the most important and useful Electronic components such as resistors, transistors, diodes, zeners, inductors, ICs, crystal oscillators, and more.",
                    ProductManufacturer = "Jupiter Technologies",
                    ProductPrice = 99.99M
                },
                new Product
                {
                    ProductName = "Quasar",
                    ProductDescription = "Quasar is a top-down shoot-em-up game where you take control of an advanced space-ship battling an endless onslaught of aliens who are invading Earth.",
                    ProductManufacturer = "Dreamedia",
                    ProductPrice = 39.95M,
                },
                new Product
                {
                    ProductName = "JavaScript Tips And Tricks",
                    ProductDescription = "Advanced Tips and Tricks about JavaScript - covering all aspects of ES6.",
                    ProductManufacturer = "Wolf Arts",
                    ProductPrice = 45.95M
                }
            };

            var wolfArtsProducts = from product in productList
                           where product.ProductManufacturer == "Wolf Arts"
                           select product;

            Console.WriteLine("==> Products by 'Wolf Arts'");
            foreach( Product product in wolfArtsProducts )
            {
                Console.WriteLine($"Product Name: {product.ProductName} - Product Price: {product.ProductPrice}");
            }

            Console.WriteLine();

            var noPriceProducts = from product in productList
                                  where product.ProductPrice == 0.0M
                                  select product;

            Console.WriteLine("==> Products without a price set");
            foreach( Product product in noPriceProducts)
            {
                Console.WriteLine($"Product Name: {product.ProductName} - Proudct Price: {product.ProductPrice}");
            }


            Console.ReadLine();
        }
    }
}
