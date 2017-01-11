using PervasiveDAL.Model;

namespace PervasiveDAL.Repository
{
    public abstract class CustomerRepository
    {
        public abstract Customer SelectCustomerById(string customerId);
    }
}