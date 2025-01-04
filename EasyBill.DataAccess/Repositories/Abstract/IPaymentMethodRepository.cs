using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IPaymentMethodRepository : IRepository<PaymentMethod>
    {
        PaymentMethod GetByName(string name);
    }
}
