using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PervasiveDAL;
using PervasiveDAL.Repository;
using PervasiveDAL.SqlRepository;

namespace PervasiveDALTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void SelectCustomerByIdTest()
        {
            // Arrange
            CustomerRepository customerRepository = new SqlCustomerRepository();

            string customerId = "METCLA01";

            // Act
            var customer = customerRepository.SelectCustomerById(customerId);

            // Assert
            Assert.IsNotNull(customer);

            Assert.IsNotNull(customer.CustomerId);
            Assert.AreEqual("METCLA01", customer.CustomerId);

            Assert.AreEqual(2, customer.CustomerAddresses.Count);
            Assert.AreEqual("7741 4th Line", customer.CustomerAddresses[0].AddressLine1);

            Assert.AreEqual(1, customer.CustomerEquipment.Count);
        }
    }
}
