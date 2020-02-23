using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Saves product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        /// <summary>
        /// Retrieve product by id
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            return new Product();
        }
    }
}
