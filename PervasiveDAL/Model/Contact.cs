namespace PervasiveDAL.Model
{
    public class Contact
    {
        public Contact(string name, int telephoneType, string telephone,
                       int faxType, string fax, string email)
        {
            Name = name;
            TelephoneType = telephoneType;
            Telephone = telephone;
            FaxType = faxType;
            Fax = fax;
            Email = email;
        }

        public string Name { get; set; }
        public int TelephoneType { get; set; }
        public string Telephone { get; set; }
        public int FaxType { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}