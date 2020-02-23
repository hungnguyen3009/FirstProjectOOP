using ACME.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACME.BLTest
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepo = new CustomerRepository();

            var expected = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepo.Retrieve(1);

            // Assert
            Assert.Equal(expected.Id, actual.Id);
            Assert.Equal(expected.Email, actual.Email);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }
    }
}
