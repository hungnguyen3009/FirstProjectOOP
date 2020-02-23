using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class Product
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Product() { }

        /// <summary>
        /// Constructor with id parameter
        /// </summary>
        public Product(int productId)
        {
            Id = productId;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        // Methods for class

        /// <summary>
        /// Validates data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
