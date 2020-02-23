using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class Customer
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Customer(int customerId)
        {
            Id = customerId;
        }

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        // Share this InstanceCount property to all Customer objects
        // Using static modifier for property means that this property
        // belongs to the class itself, not objects.
        public static int InstanceCount { get; set; }


        // Methods for this class
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Retrieves all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Retrieves customer by id
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }


        /// <summary>
        /// Validates the customer data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }
    }
}
