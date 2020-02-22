using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class Customer
    {
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
    }
}
