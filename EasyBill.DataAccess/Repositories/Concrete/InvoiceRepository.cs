using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        private readonly EasyBillDBContext _context;

        public InvoiceRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Invoice> GetPendingInvoices()
        {
            return _context.Invoices.Where(i => i.Status == "Pending").ToList();
        }
    }
}
