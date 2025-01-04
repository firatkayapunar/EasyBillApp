using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class PaymentMethodRepository : Repository<PaymentMethod>, IPaymentMethodRepository
    {
        private readonly EasyBillDBContext _context;

        public PaymentMethodRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public PaymentMethod GetByName(string name)
        {
            return _context.PaymentMethods.FirstOrDefault(pm => pm.Name == name);
        }
    }
}
