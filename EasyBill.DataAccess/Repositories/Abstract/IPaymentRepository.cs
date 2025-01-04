using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        IEnumerable<Payment> GetPaymentsByInvoiceId(int invoiceId);
    }
}
