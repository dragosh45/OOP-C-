using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM2.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "pipi";
            customer.LastName = "popo";
            string expected = "popo, pipi";
            // -- Act
            string actual = customer.FullName;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "pipi";

            string expected = "pipi";
            // -- Act
            string actual = customer.FullName;
            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            Customer customer1 = new Customer();
            Customer.InstanceCount += 1;
            Customer customer2 = new Customer();
            Customer.InstanceCount += 1;
            Customer customer3 = new Customer();
            Customer.InstanceCount += 1;
            // -- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
