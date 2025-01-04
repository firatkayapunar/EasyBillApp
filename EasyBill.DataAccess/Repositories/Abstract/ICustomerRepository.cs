using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetActiveCustomers();
    }
}
