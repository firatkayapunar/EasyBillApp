using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IBillTypeRepository : IRepository<BillType>
    {
        BillType GetByName(string name);
        IEnumerable<Provider> GetProvidersByBillTypeId(int billTypeId);
    }
}
