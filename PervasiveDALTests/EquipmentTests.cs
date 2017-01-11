using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PervasiveDAL;
using PervasiveDAL.Repository;
using PervasiveDAL.SqlRepository;

namespace PervasiveDALTests
{
    [TestClass]
    public class EquipmentTests
    {
        [TestMethod]
        public void SelectEquipmentByIdTest()
        {
            // Arrange
            EquipmentRepository sqlEquipmentRepository = new SqlEquipmentRepository();

            int equipmentId = 944;

            // Act
            var equipment = sqlEquipmentRepository.SelectEquipmentById(equipmentId);

            // Assert
            Assert.IsNotNull(equipment);

            Assert.IsNotNull(equipment.CustomerId);
            Assert.AreEqual("METCLA01", equipment.CustomerId);

            Assert.IsNotNull(equipment.UnitId);
            Assert.AreEqual("BHMETCLA01-01", equipment.UnitId);

            Assert.IsNotNull(equipment.Year);
            Assert.AreEqual("", equipment.Year);

            Assert.IsNotNull(equipment.EngineMake);
            Assert.AreEqual("Cummins", equipment.EngineMake);

            Assert.IsNotNull(equipment.EngineModel);
            Assert.AreEqual("", equipment.EngineModel);

            Assert.IsNotNull(equipment.Territory);
            Assert.AreEqual("WE", equipment.Territory);

            Assert.IsNotNull(equipment.GensetSerialNumber);
            Assert.AreEqual("3622-0367", equipment.GensetSerialNumber);

            Assert.IsNotNull(equipment.GensetMakeModel);
            Assert.AreEqual("", equipment.GensetMakeModel);

            Assert.IsNotNull(equipment.KwVoltage);
            Assert.AreEqual("75/240", equipment.KwVoltage);

            Assert.IsNotNull(equipment.LocationCode);
            Assert.AreEqual("N0B 2S0", equipment.LocationCode);

            Assert.IsNotNull(equipment.UnitHours);
            Assert.AreEqual(202, equipment.UnitHours);

            Assert.IsNotNull(equipment.NextServiceDate);
            Assert.AreEqual("20170201", equipment.NextServiceDate);

            Assert.IsNotNull(equipment.Notes);
            Assert.AreEqual("LF408; AF2038; FF832; 10 Litres 15w40; Generator model 1D075CMACU  s/n3622-0367; Display Master 4   MX-150 ATS  400a 120/240v; Contact: Clare Metzger 519-698-2616", equipment.Notes);

            Assert.IsNotNull(equipment.Invoices);
            Assert.AreEqual(1, equipment.Invoices.Count);
        }

        [TestMethod]
        public void SelectEquipmentByIdTest_Invoices()
        {
            EquipmentRepository sqlEquipmentRepository = new SqlEquipmentRepository();

            int equipmentId = 47;

            var equipment = sqlEquipmentRepository.SelectEquipmentById(equipmentId);

            Assert.IsNotNull(equipment);

            Assert.IsNotNull(equipment.CustomerId);
            Assert.AreEqual("BONAPA01", equipment.CustomerId);

            Assert.IsNotNull(equipment.UnitId);
            Assert.AreEqual("WTBONAPA01-01", equipment.UnitId);

            Assert.IsNotNull(equipment.Year);
            Assert.AreEqual("1", equipment.Year);

            Assert.IsNotNull(equipment.EngineMake);
            Assert.AreEqual("PERKINS", equipment.EngineMake);

            Assert.IsNotNull(equipment.EngineModel);
            Assert.AreEqual("TV854", equipment.EngineModel);

            Assert.IsNotNull(equipment.Territory);
            Assert.AreEqual("ON", equipment.Territory);

            Assert.IsNotNull(equipment.GensetSerialNumber);
            Assert.AreEqual("6494572", equipment.GensetSerialNumber);

            Assert.IsNotNull(equipment.GensetMakeModel);
            Assert.AreEqual("Leroy Somer LSA46M1", equipment.GensetMakeModel);

            Assert.IsNotNull(equipment.KwVoltage);
            Assert.AreEqual("125kW - 208 VAC", equipment.KwVoltage);

            Assert.IsNotNull(equipment.LocationCode);
            Assert.AreEqual("M6K 3G2", equipment.LocationCode);

            Assert.IsNotNull(equipment.UnitHours);
            Assert.AreEqual(932, equipment.UnitHours);

            Assert.IsNotNull(equipment.NextServiceDate);
            Assert.AreEqual("", equipment.NextServiceDate);

            Assert.IsNotNull(equipment.Invoices);
            Assert.AreEqual(3, equipment.Invoices.Count);

            Assert.IsNotNull(equipment.Invoices);
            Assert.AreEqual(3, equipment.Invoices.Count);

            Assert.IsNotNull(equipment.Invoices[0].InvoiceId);
            Assert.AreEqual(6317, equipment.Invoices[0].InvoiceId);

            Assert.IsNotNull(equipment.Invoices[1].CustomerId);
            Assert.AreEqual("BONAPA01", equipment.Invoices[1].CustomerId);

            Assert.IsNotNull(equipment.Invoices[2].EquipmentId);
            Assert.AreEqual(47, equipment.Invoices[2].EquipmentId);

            Assert.IsNotNull(equipment.Invoices[0].PreviousOdometerReading);
            Assert.AreEqual(0, equipment.Invoices[0].PreviousOdometerReading);

            Assert.IsNotNull(equipment.Invoices[1].OdometerReading);
            Assert.AreEqual(932, equipment.Invoices[1].OdometerReading);

            Assert.IsNotNull(equipment.Invoices[2].WorkorderId);
            Assert.AreEqual(8345, equipment.Invoices[2].WorkorderId);

            Assert.IsNotNull(equipment.Invoices[0].CustomerPoNumber);
            Assert.AreEqual("", equipment.Invoices[0].CustomerPoNumber);

            Assert.IsNotNull(equipment.Invoices[1].InvoiceDate);
            Assert.AreEqual("20160630", equipment.Invoices[1].InvoiceDate);

            Assert.IsNotNull(equipment.Invoices[2].TotalNet);
            Assert.AreEqual(0m, equipment.Invoices[2].TotalNet);

            Assert.IsNotNull(equipment.Invoices[0].CurrentCost);
            Assert.AreEqual(347.84m, equipment.Invoices[0].CurrentCost);

            Assert.IsNotNull(equipment.Invoices[1].AverageCost);
            Assert.AreEqual(13.23m, equipment.Invoices[1].AverageCost);

            Assert.IsNotNull(equipment.Invoices[2].NextServiceDate);
            Assert.AreEqual("", equipment.Invoices[2].NextServiceDate);
        }
    }
}
