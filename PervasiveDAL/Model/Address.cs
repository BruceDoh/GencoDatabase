namespace PervasiveDAL.Model
{
    public class Address
    {
        public Address(string recordType, string entityId, string addressType, string addressId, string addressName,
            string addressLine1, string addressLine2, string addressLine3, string addressLine4, string city,
            string province, string postalCode, string countryCode, int telephoneType, string telephone, int faxType,
            string fax, string email, string website, Contact contact1, Contact contact2, Contact contact3, bool hold,
            string territoryId, string territoryName, string salesPersonId, string salesPersonName, string shipCode,
            string shipDescription, string defaultWarehouse, string accountId, int salesTax1, int salesTax2,
            int salesTax3, int salesTax4, string salesTaxExempt1, string salesTaxExempt2, string modifiedDate,
            string modifiedTime, string modifiedBy, string addedDate, string addedTime, string addedBy)
        {
            RecordType = recordType;
            EntityId = entityId;
            AddressType = addressType;
            AddressId = addressId;
            AddressName = addressName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            City = city;
            Province = province;
            PostalCode = postalCode;
            CountryCode = countryCode;
            TelephoneType = telephoneType;
            Telephone = telephone;
            FaxType = faxType;
            Fax = fax;
            Email = email;
            Website = website;
            Contact1 = contact1;
            Contact2 = contact2;
            Contact3 = contact3;
            Hold = hold;
            TerritoryId = territoryId;
            TerritoryName = territoryName;
            SalesPersonId = salesPersonId;
            SalesPersonName = salesPersonName;
            ShipCode = shipCode;
            ShipDescription = shipDescription;
            DefaultWarehouse = defaultWarehouse;
            AccountId = accountId;
            SalesTax1 = salesTax1;
            SalesTax2 = salesTax2;
            SalesTax3 = salesTax3;
            SalesTax4 = salesTax4;
            SalesTaxExempt1 = salesTaxExempt1;
            SalesTaxExempt2 = salesTaxExempt2;
            ModifiedDate = modifiedDate;
            ModifiedTime = modifiedTime;
            ModifiedBy = modifiedBy;
            AddedDate = addedDate;
            AddedTime = addedTime;
            AddedBy = addedBy;
        }

        public string RecordType { get; set; }
        public string EntityId { get; set; }
        public string AddressType { get; set; }
        public string AddressId { get; set; }
        public string AddressName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public int TelephoneType { get; set; }
        public string Telephone { get; set; }
        public int FaxType { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public Contact Contact1 { get; set; }
        public Contact Contact2 { get; set; }
        public Contact Contact3 { get; set; }
        public bool Hold { get; set; }
        public string TerritoryId { get; set; }
        public string TerritoryName { get; set; }
        public string SalesPersonId { get; set; }
        public string SalesPersonName { get; set; }
        public string ShipCode { get; set; }
        public string ShipDescription { get; set; }
        public string DefaultWarehouse { get; set; }
        public string AccountId { get; set; }
        public int SalesTax1 { get; set; }
        public int SalesTax2 { get; set; }
        public int SalesTax3 { get; set; }
        public int SalesTax4 { get; set; }
        public string SalesTaxExempt1 { get; set; }
        public string SalesTaxExempt2 { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedTime { get; set; }
        public string ModifiedBy { get; set; }
        public string AddedDate { get; set; }
        public string AddedTime { get; set; }
        public string AddedBy { get; set; }
    }
}