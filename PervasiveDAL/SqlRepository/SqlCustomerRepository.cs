using System.Collections.Generic;
using Pervasive.Data.SqlClient;
using PervasiveDAL.Model;
using PervasiveDAL.Repository;

namespace PervasiveDAL.SqlRepository
{
    public class SqlCustomerRepository : CustomerRepository
    {
        private string _fields = "CUST_NO, " +
                                 "CUST_APPROVED_BY, " +
                                 "CUST_APPROVED_DATE, " +
                                 "STATUS";

        public override Customer SelectCustomerById(string customerId)
        {
            string connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

            using (PsqlConnection con = new PsqlConnection(connectionString))
            {
                con.Open();

                string commandString = "SELECT " +
                                       _fields +
                                       " FROM " +
                                       "BVE_CUSTOMER" +
                                       " WHERE " +
                                       "CUST_NO" +
                                       " = " + 
                                       "'" + customerId + "'";

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return ConstructCustomer(reader);
                        }
                    }
                }
            }

            return null;
        }


        private Customer ConstructCustomer(PsqlDataReader reader)
        {
            string customerId = reader.GetString(0).Trim();

            return new Customer(customerId,
                                reader.GetString(1).Trim(),
                                reader.GetString(2).Trim(),
                                reader.GetString(3).Trim(),
                                GetEquipment(customerId),
                                GetAddresses(customerId));
        }

        private IList<Equipment> GetEquipment(string customerId)
        {
            EquipmentRepository invoiceRepository = new SqlEquipmentRepository();

            return invoiceRepository.SelectEquipmentByCustomerId(customerId);
        }

        private IList<Address> GetAddresses(string customerId)
        {
            AddressRepository addressRepository = new SqlAddressRepository();

            return addressRepository.SelectAddressesByEntity(customerId);
        }
    }
}