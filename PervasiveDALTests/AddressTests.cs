using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PervasiveDAL.Repository;
using PervasiveDAL.SqlRepository;

namespace PervasiveDALTests
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void SelectAddressesByEntityTest()
        {
            // Arrange
            AddressRepository sqlAddressRepository = new SqlAddressRepository();

            string entityId = "LUBELE01";

            // Act
            var address = sqlAddressRepository.SelectAddressesByEntity(entityId);

            // Assert
            Assert.IsNotNull(address);
            Assert.AreEqual(3, address.Count);

            Assert.AreEqual("CUST", address[0].RecordType);
            Assert.AreEqual("S", address[1].AddressType);
            Assert.AreEqual("BHLUBELE01-02", address[2].AddressId);
            Assert.AreEqual("Lubek Electric Inc.", address[0].AddressName);
            Assert.AreEqual("1987 Chiefswood Road", address[1].AddressLine1);
            Assert.AreEqual("", address[2].AddressLine2);
            Assert.AreEqual("", address[0].AddressLine3);
            Assert.AreEqual("", address[1].AddressLine4);
            Assert.AreEqual("Ohsweken", address[2].City);
            Assert.AreEqual("ON", address[0].Province);
            Assert.AreEqual("N0A 1M0", address[1].PostalCode);

            Assert.IsNotNull(address[0].Contact1);
            Assert.IsNotNull(address[1].Contact2);
            Assert.IsNotNull(address[2].Contact3);

            Assert.AreEqual("Marty Lubek", address[2].Contact1.Name);
            Assert.AreEqual("5197321128", address[0].Contact2.Fax);
            Assert.AreEqual("lubekelectric@xplornet.com", address[0].Contact3.Email);
        }
    }
}
