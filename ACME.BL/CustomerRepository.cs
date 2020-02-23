using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Retrieves customer by id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.Email = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }
    }
}
