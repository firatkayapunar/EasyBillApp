using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IInvoiceRepository : IRepository<Invoice>
    {
        IEnumerable<Invoice> GetPendingInvoices();
    }
}
