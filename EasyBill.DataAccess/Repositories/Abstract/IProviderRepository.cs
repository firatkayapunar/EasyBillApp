using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IProviderRepository : IRepository<Provider>
    {
        IEnumerable<Provider> GetProvidersByBillTypeId(int billTypeId);
    }
}
