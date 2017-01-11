using System.Collections.Generic;

namespace PervasiveDAL.Model
{
    public class Customer
    {
        public Customer (string customerId, string approvedBy, string approvedDate, string status, IList<Equipment> customerEquipment, IList<Address> customerAddresses  )
        {
            CustomerId = customerId;
            ApprovedBy = approvedBy;
            ApprovedDate = approvedDate;
            Status = status;
            CustomerEquipment = customerEquipment;
            CustomerAddresses = customerAddresses;
        }

        public string CustomerId { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
        public string Status { get; set; }

        public IList<Equipment> CustomerEquipment { get; }
        public IList<Address> CustomerAddresses { get; }
    }
}