using ACME.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACME.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestMethod()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins, ";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = ", Bilbo";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // Act


            // Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void Validate()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                Email = "fbaggins@hobbiton.me"
            };

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                Email = "fbaggins@hobbiton.me"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingEmail()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
