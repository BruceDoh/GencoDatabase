using System.Collections.Generic;
using PervasiveDAL.Model;

namespace PervasiveDAL.Repository
{
    public abstract class AddressRepository
    {
        public abstract IList<Address> SelectAddressesByEntity(string entityId);
    }
}