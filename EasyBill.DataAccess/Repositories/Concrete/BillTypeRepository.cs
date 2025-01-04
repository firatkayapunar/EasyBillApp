using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class BillTypeRepository : Repository<BillType>, IBillTypeRepository
    {
        private readonly EasyBillDBContext _context;

        public BillTypeRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public BillType GetByName(string name)
        {
            return _context.BillTypes.FirstOrDefault(bt => bt.Name == name);
        }

        public IEnumerable<Provider> GetProvidersByBillTypeId(int billTypeId)
        {
            return _context.Providers
                .Where(p => p.BillTypeID == billTypeId)
                .ToList();
        }
    }
}
