using System;
using System.Collections.Generic;
using Pervasive.Data.SqlClient;
using PervasiveDAL.Model;
using PervasiveDAL.Repository;

namespace PervasiveDAL.SqlRepository
{
    public class SqlEquipmentRepository : EquipmentRepository
    {
        private string _fields = "V_VEHICLE_NO, " +
                                 "V_CUST_NO, " +
                                 "V_UNIT_NO, " +
                                 "V_YEAR, " +
                                 "V_MAKE, " +
                                 "V_MODEL, " +
                                 "V_TERRITORY, " +
                                 "V_LICENSE_NO, " +
                                 "V_VIN01, " +
                                 "V_VIN02, " +
                                 "V_VIN03, " +
                                 "V_MILEAGE, " +
                                 "V_FOLLOWUP_DATE, " +
                                 "V_NOTES";

        public override Equipment SelectEquipmentById(int vehicleId)
        {
            string connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

            using (PsqlConnection con = new PsqlConnection(connectionString))
            {
                con.Open();

                string commandString = "SELECT " +
                                       _fields +
                                       " FROM BVE_VEHICLE" +
                                       " WHERE " +
                                       "V_VEHICLE_NO = '" + vehicleId.ToString("D10") + "'";

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return ConstructEquipment(reader);
                        }
                    }
                }
            }

            return null;
        }

        public override IList<Equipment> SelectEquipmentByCustomerId(string customerId)
        {
            var selectedEquipment = new List<Equipment>();

            string connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

            using (PsqlConnection con = new PsqlConnection(connectionString))
            {
                con.Open();

                string commandString = "SELECT " +
                                       _fields +
                                       " FROM BVE_VEHICLE" +
                                       " WHERE " +
                                       "V_CUST_NO = '" + customerId + "'";

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            selectedEquipment.Add(ConstructEquipment(reader));
                        }
                    }
                }
            }
            return selectedEquipment;
        }

        private Equipment ConstructEquipment(PsqlDataReader reader)
        {
            int equipmentId = reader.GetInt32(0);

            return new Equipment(equipmentId, 
                                 reader.GetString(1).Trim(), 
                                 reader.GetString(2).Trim(), 
                                 reader.GetString(3).Trim(), 
                                 reader.GetString(4).Trim(),
                                 reader.GetString(5).Trim(), 
                                 reader.GetString(6).Trim(), 
                                 reader.GetString(7).Trim(), 
                                 reader.GetString(8).Trim(), 
                                 reader.GetString(9).Trim(),
                                 reader.GetString(10).Trim(), 
                                 reader.GetInt32(11), 
                                 reader.GetString(12).Trim(), 
                                 reader.GetString(13).Trim(),
                                 GetInvoices(equipmentId));
        }

        private IList<Invoice> GetInvoices(int equipmentId)
        {
            SqlInvoiceRepository sqlInvoiceRepository = new SqlInvoiceRepository();

            return sqlInvoiceRepository.SelectInvoicesByEquipmentId(equipmentId);
        } 
    }
}