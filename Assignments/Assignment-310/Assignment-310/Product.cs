using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_310
{
    class Product
    {
        // Step 1.1 Create a const variable
        const string DEFAULT_MANUFACTURER_NAME = "ACME Incorporated.";

        // Step 1.3 Chain two Constructors together
        /// <summary>
        /// Default constructor for Product that initializes an empty Product with a default Manufacturer.
        /// </summary>
        public Product() : this("", "", DEFAULT_MANUFACTURER_NAME, 0.0M)
        {

        }

        /// <summary>
        /// Constructor that takes a Product Name only and initializes with the Default Manufacturuer Name.
        /// </summary>
        /// <param name="productName">Name of the Product</param>
        public Product(string productName) : this(productName, "", DEFAULT_MANUFACTURER_NAME, 0.0M)
        {

        }

        /// <summary>
        /// Constructor that takes a Product Name and Product Description
        /// </summary>
        /// <param name="productName">Name of the Product</param>
        /// <param name="productDescription">Description of the Product</param>
        public Product(string productName, string productDescription) : this(productName, productDescription, DEFAULT_MANUFACTURER_NAME, 0.0M)
        {

        }

        /// <summary>
        /// Constructor that takes Product Name, Description, and Manufacturer
        /// </summary>
        /// <param name="productName">Name of the Product</param>
        /// <param name="productDescription">Description of the Product</param>
        /// <param name="productManufacturer">Manufacturer of the Product</param>
        public Product(string productName, string productDescription, string productManufacturer) : this(productName, productDescription, productManufacturer, 0.0M)
        {

        }

        /// <summary>
        /// Constructor that takes Product Name, Description, Manufacturer and Price.
        /// </summary>
        /// <param name="productName">Name of the Product</param>
        /// <param name="productDescription">Description of the Product</param>
        /// <param name="productManufacturer">Manufacturer of the Product</param>
        /// <param name="productPrice">Price of the Product</param>
        public Product(string productName, string productDescription, string productManufacturer, decimal productPrice)
        {
            Id = Guid.NewGuid();
            ProductName = productName;
            ProductDescription = productDescription;
            ProductManufacturer = productManufacturer;
            ProductPrice = productPrice;
        }

        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductManufacturer { get; set; }
        public decimal ProductPrice { get; set; }



    }
}
