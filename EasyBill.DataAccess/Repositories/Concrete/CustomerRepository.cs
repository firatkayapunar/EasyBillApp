using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly EasyBillDBContext _context;

        public CustomerRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetActiveCustomers()
        {
            return _context.Customers.Where(c => c.IsActive).ToList();
        }
    }
}
