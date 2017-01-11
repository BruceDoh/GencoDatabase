using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PervasiveDAL;
using PervasiveDAL.Repository;
using PervasiveDAL.SqlRepository;

namespace PervasiveDALTests
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void SelectInvoiceByIdTest()
        {
            // Arrange
            InvoiceRepository sqlInvoiceRepository = new SqlInvoiceRepository();

            int invoiceId = 4903;

            // Act
            var invoice = sqlInvoiceRepository.SelectInvoiceById(invoiceId);

            // Assert
            Assert.IsNotNull(invoice);

            Assert.IsNotNull(invoice.InvoiceId);
            Assert.AreEqual(4903, invoice.InvoiceId);

            Assert.IsNotNull(invoice.CustomerId);
            Assert.AreEqual("CITBRA02", invoice.CustomerId);

            Assert.IsNotNull(invoice.EquipmentId);
            Assert.AreEqual(93, invoice.EquipmentId);

            Assert.IsNotNull(invoice.PreviousOdometerReading);
            Assert.AreEqual(0, invoice.PreviousOdometerReading);

            Assert.IsNotNull(invoice.OdometerReading);
            Assert.AreEqual(0, invoice.OdometerReading);

            Assert.IsNotNull(invoice.WorkorderId);
            Assert.AreEqual(4850, invoice.WorkorderId);

            Assert.IsNotNull(invoice.CustomerPoNumber);
            Assert.AreEqual("0000812947", invoice.CustomerPoNumber);

            Assert.IsNotNull(invoice.InvoiceDate);
            Assert.AreEqual("20151030", invoice.InvoiceDate);

            Assert.IsNotNull(invoice.TotalNet);
            Assert.AreEqual(1622.5m, invoice.TotalNet);

            Assert.IsNotNull(invoice.CurrentCost);
            Assert.AreEqual(86.34m, invoice.CurrentCost);

            Assert.IsNotNull(invoice.AverageCost);
            Assert.AreEqual(84.74m, invoice.AverageCost);

            Assert.IsNotNull(invoice.NextServiceDate);
            Assert.AreEqual("", invoice.NextServiceDate);
        }

        [TestMethod]
        public void SelectInvoicesByEquipmentIdTest()
        {
            InvoiceRepository sqlInvoiceRepository = new SqlInvoiceRepository();

            int equipmentId = 47;

            var invoices = sqlInvoiceRepository.SelectInvoicesByEquipmentId(equipmentId);

            Assert.IsNotNull(invoices);
            Assert.AreEqual(3, invoices.Count);

            Assert.IsNotNull(invoices[0].InvoiceId);
            Assert.AreEqual(6317, invoices[0].InvoiceId);

            Assert.IsNotNull(invoices[1].CustomerId);
            Assert.AreEqual("BONAPA01", invoices[1].CustomerId);

            Assert.IsNotNull(invoices[2].EquipmentId);
            Assert.AreEqual(47, invoices[2].EquipmentId);

            Assert.IsNotNull(invoices[0].PreviousOdometerReading);
            Assert.AreEqual(0, invoices[0].PreviousOdometerReading);

            Assert.IsNotNull(invoices[1].OdometerReading);
            Assert.AreEqual(932, invoices[1].OdometerReading);

            Assert.IsNotNull(invoices[2].WorkorderId);
            Assert.AreEqual(8345, invoices[2].WorkorderId);

            Assert.IsNotNull(invoices[0].CustomerPoNumber);
            Assert.AreEqual("", invoices[0].CustomerPoNumber);

            Assert.IsNotNull(invoices[1].InvoiceDate);
            Assert.AreEqual("20160630", invoices[1].InvoiceDate);

            Assert.IsNotNull(invoices[2].TotalNet);
            Assert.AreEqual(0m, invoices[2].TotalNet);

            Assert.IsNotNull(invoices[0].CurrentCost);
            Assert.AreEqual(347.84m, invoices[0].CurrentCost);

            Assert.IsNotNull(invoices[1].AverageCost);
            Assert.AreEqual(13.23m, invoices[1].AverageCost);

            Assert.IsNotNull(invoices[2].NextServiceDate);
            Assert.AreEqual("", invoices[2].NextServiceDate);
        }
    }
}
