using System;
using System.Collections.Generic;
using Pervasive.Data.SqlClient;
using PervasiveDAL.Model;
using PervasiveDAL.Repository;

namespace PervasiveDAL.SqlRepository
{
    public class SqlAddressRepository : AddressRepository
    {
        private readonly string _connectionString = PervasiveDAL.Properties.Settings.Default.ConnectionString;

        private string _fields = "RECORD_TYPE, " +
                                 "CEV_NO, " +
                                 "ADDR_TYPE, " +
                                 "ID, " +
                                 "NAME, " +
                                 "BVADDR1, " +
                                 "BVADDR2, " +
                                 "BVADDR3, " +
                                 "BVADDR4, " +
                                 "BVCITY, " +
                                 "BVPROVSTATE, " +
                                 "BVPOSTALCODE, " +
                                 "BVCOUNTRYCODE, " +
                                 "BVADDRTELNO1TYPE, " +
                                 "BVADDRTELNO1, " +
                                 "BVADDRTELNO2TYPE, " +
                                 "BVADDRTELNO2, " +
                                 "BVADDREMAIL, " +
                                 "BVCOWEBPAGE, " +
                                 "BVCOCONTACT1NAME, " +
                                 "BVCOCONTACT1TEL1TYPE, " +
                                 "BVCOCONTACT1TEL1, " +
                                 "BVCOCONTACT1TEL2TYPE, " +
                                 "BVCOCONTACT1TEL2, " +
                                 "BVCOCONTACT1EMAIL, " +
                                 "BVCOCONTACT2NAME, " +
                                 "BVCOCONTACT2TEL1TYPE, " +
                                 "BVCOCONTACT2TEL1, " +
                                 "BVCOCONTACT2TEL2TYPE, " +
                                 "BVCOCONTACT2TEL2, " +
                                 "BVCOCONTACT2EMAIL, " +
                                 "BVCOCONTACT3NAME, " +
                                 "BVCOCONTACT3TEL1TYPE, " +
                                 "BVCOCONTACT3TEL1, " +
                                 "BVCOCONTACT3TEL2TYPE, " +
                                 "BVCOCONTACT3TEL2, " +
                                 "BVCOCONTACT3EMAIL, " +
                                 "HOLD, " +
                                 "SALES_TERR, " +
                                 "SALES_TERR_DESC, " +
                                 "SALES_PERSON, " +
                                 "SLSPSN_NAME, " +
                                 "SHIP_CODE, " +
                                 "SHIP_DESC, " +
                                 "DFLT_WHSE, " +
                                 "RV_ACCOUNT, " +
                                 "BVSLSTAXNO1, " +
                                 "BVSLSTAXNO2, " +
                                 "BVSLSTAXNO3, " +
                                 "BVSLSTAXNO4, " +
                                 "BVSLSTAXEXEMPT1, " +
                                 "BVSLSTAXEXEMPT2, " +
                                 "BVRVMODDATE, " +
                                 "BVRVMODTIME, " +
                                 "BVRVUSERINIT, " +
                                 "BVRVADDDATE, " +
                                 "BVRVADDTIME, " +
                                 "BVRVADDUSERINIT";

        public override IList<Address> SelectAddressesByEntity(string entityId)
        {
            var selectedAddresses = new List<Address>();

            using (PsqlConnection con = new PsqlConnection(_connectionString))
            {
                con.Open();

                string commandString = "SELECT " +
                                       _fields +
                                       " FROM ADDRESS" +
                                       " WHERE " +
                                       "CEV_NO = '" + entityId + "'";

                Console.WriteLine(commandString);

                using (
                    PsqlCommand command =
                        new PsqlCommand(commandString, con))
                {
                    using (PsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            selectedAddresses.Add(ConstructAddress(reader));
                        }
                    }
                }
            }

            return selectedAddresses;
        }

        private Address ConstructAddress(PsqlDataReader reader)
        {
            //for (int x = 0; x < 58; x++)
            //{
            //    Console.WriteLine(x + ": " + reader.GetFieldType(x));
            //}
            

            return new Address(reader.GetString(0).Trim(),
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
                               reader.GetString(11).Trim(),
                               reader.GetString(12).Trim(),
                               reader.GetInt32(13),
                               reader.GetString(14).Trim(),
                               reader.GetInt32(15),
                               reader.GetString(16).Trim(),
                               reader.GetString(17).Trim(),
                               reader.GetString(18).Trim(),
                               new Contact(reader.GetString(19).Trim(), 
                                           reader.GetInt32(20), 
                                           reader.GetString(21).Trim(), 
                                           reader.GetInt32(22),
                                           reader.GetString(23).Trim(),
                                           reader.GetString(24).Trim()),
                               new Contact(reader.GetString(25).Trim(), 
                                           reader.GetInt32(26), 
                                           reader.GetString(27).Trim(), 
                                           reader.GetInt32(28),
                                           reader.GetString(29).Trim(),
                                           reader.GetString(30).Trim()),
                               new Contact(reader.GetString(31).Trim(),
                                           reader.GetInt32(32),
                                           reader.GetString(33).Trim(),
                                           reader.GetInt32(34),
                                           reader.GetString(35).Trim(),
                                           reader.GetString(36).Trim()),
                               reader.GetByte(37)>0 ? true : false,
                               reader.GetString(38).Trim(),
                               reader.GetString(39).Trim(),
                               reader.GetString(40).Trim(),
                               reader.GetString(41).Trim(),
                               reader.GetString(42).Trim(),
                               reader.GetString(43).Trim(),
                               reader.GetString(44).Trim(),
                               reader.GetString(45).Trim(),
                               reader.GetInt32(46),
                               reader.GetInt32(47),
                               reader.GetInt32(48),
                               reader.GetInt32(49),
                               reader.GetString(50).Trim(),
                               reader.GetString(51).Trim(),
                               reader.GetString(52).Trim(),
                               reader.GetString(53).Trim(),
                               reader.GetString(54).Trim(),
                               reader.GetString(55).Trim(),
                               reader.GetString(56).Trim(),
                               reader.GetString(57).Trim());
        }
    }
}