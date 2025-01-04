using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        private readonly EasyBillDBContext _context;

        public ProviderRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Provider> GetProvidersByBillTypeId(int billTypeId)
        {
            return _context.Providers.Where(p => p.BillTypeID == billTypeId).ToList();
        }
    }
}
