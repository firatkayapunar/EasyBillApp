using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        private readonly EasyBillDBContext _context;

        public PaymentRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Payment> GetPaymentsByInvoiceId(int invoiceId)
        {
            return _context.Payments.Where(p => p.InvoiceID == invoiceId).ToList();
        }
    }
}
