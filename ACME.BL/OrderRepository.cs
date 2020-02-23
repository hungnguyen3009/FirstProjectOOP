using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        /// <summary>
        /// Saves data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
