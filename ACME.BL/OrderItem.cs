using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class OrderItem
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderItem()
        {

        }

        /// <summary>
        /// Constructor with id parameter
        /// </summary>
        public OrderItem(int orderItemId)
        {
            Id = orderItemId;
        }

        public int Id { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        // Methods for class
        /// <summary>
        /// Retrieve order item by id
        /// </summary>
        /// <param name="orderItemId"></param>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
