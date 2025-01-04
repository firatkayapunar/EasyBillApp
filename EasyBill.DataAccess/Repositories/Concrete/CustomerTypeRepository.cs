using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class CustomerTypeRepository : Repository<CustomerType>, ICustomerTypeRepository
    {
        private readonly EasyBillDBContext _context;

        public CustomerTypeRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public CustomerType GetByName(string name)
        {
            return _context.CustomerTypes.FirstOrDefault(ct => ct.Name == name);
        }
    }
}
