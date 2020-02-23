using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class Order
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Constructor with id parameter
        /// </summary>
        public Order(int orderId)
        {
            Id = orderId;
        }

        // DateTimeOffSet: tracks the Date, Time and Time zone offset.
        // Use this type when date can be set in different time zones
        public DateTimeOffset? OrderDate { get; set; }
        public int Id { get; private set; }

        // Methods for class

        /// <summary>
        /// Validates data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
