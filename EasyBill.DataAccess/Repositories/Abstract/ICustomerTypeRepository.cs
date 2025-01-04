using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface ICustomerTypeRepository : IRepository<CustomerType>
    {
        CustomerType GetByName(string name);
    }
}
