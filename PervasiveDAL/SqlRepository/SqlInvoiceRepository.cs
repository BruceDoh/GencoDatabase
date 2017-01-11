using System;
using System.Collections.Generic;
using Pervasive.Data.SqlClient;
using PervasiveDAL.Repository;

namespace PervasiveDAL.SqlRepository
{
    public class SqlInvoiceRepository : InvoiceRepository
    {
        private string _fields = "VH_INVOICE_NO, " +
                                "VH_CUST_NO, " +
                                "VH_VEHICLE_NO, " +
                                "VH_PREVIOUS_ODO, " +
                                "VH_ODOMETER, " +
                                "VH_ORDER_NO, " +
                                "VH_CUST_PO_NO, " +
                                "VH_INVOICE_DATE, " +
                                "VH_TOTAL_NET, " +
                                "BVCURRENTCOST, " +
                                "BVAVERAGECOST, " +
                                "VH_FOLLOWUP_DATE";
        public override Invoice SelectInvoiceById(int invoiceId)
        {
            string connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

            using (PsqlConnection con = new PsqlConnection(connectionString))
            {
                con.Open();

                string commandString = "SELECT " +                                       
                                       _fields + 
                                       " FROM BVE_VEHICLE_HISTORY" +
                                       " WHERE " +
                                       "VH_INVOICE_NO = '1" + invoiceId.ToString("D9") + "'";

                Console.WriteLine(commandString);

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return ConstructInvoice(reader);            
                        }
                    }
                }
            }

            return null;
        }

        public override IList<Invoice> SelectInvoicesByEquipmentId(int equipmentId)
        {
            var selectedInvoices = new List<Invoice>();

            string connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

            using (PsqlConnection con = new PsqlConnection(connectionString))
            {
                con.Open();

                string commandString = "SELECT " +
                                       _fields +
                                       " FROM BVE_VEHICLE_HISTORY" +
                                       " WHERE " +
                                       "VH_VEHICLE_NO = '" + equipmentId.ToString("D10") + "'";

                Console.WriteLine(commandString);

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            selectedInvoices.Add(ConstructInvoice(reader));
                        }
                    }
                }
            }

            return selectedInvoices;
        }

        private Invoice ConstructInvoice(PsqlDataReader reader)
        {
            return new Invoice(
                Convert.ToInt32(reader.GetString(0).TrimStart('1')),
                reader.GetString(1).Trim(),
                reader.GetInt32(2),
                reader.GetInt32(3),
                reader.GetInt32(4),
                Convert.ToInt32(reader.GetString(5).TrimStart('5')),
                reader.GetString(6).Trim(),
                reader.GetString(7).Trim(),
                reader.GetDecimal(8),
                reader.GetDecimal(9),
                reader.GetDecimal(10),
                reader.GetString(11).Trim());

        }
    }
}