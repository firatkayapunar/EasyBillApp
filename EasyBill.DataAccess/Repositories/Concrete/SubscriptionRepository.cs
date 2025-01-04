using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Concrete
{
    public class SubscriptionRepository : Repository<Subscription>, ISubscriptionRepository
    {
        private readonly EasyBillDBContext _context;

        public SubscriptionRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        // Aktif abonelikleri getir
        public IEnumerable<Subscription> GetActiveSubscriptions()
        {
            return _context.Subscriptions
                .Where(s => s.IsActive)
                .ToList();
        }

        // Belirli bir müşteriye ait abonelikleri getir
        public IEnumerable<Subscription> GetSubscriptionsByCustomerId(int customerId)
        {
            return _context.Subscriptions
                .Where(s => s.CustomerID == customerId)
                .ToList();
        }

        // Belirli bir sağlayıcıya ait abonelikleri getir
        public IEnumerable<Subscription> GetSubscriptionsByProviderId(int providerId)
        {
            return _context.Subscriptions
                .Where(s => s.ProviderID == providerId)
                .ToList();
        }
    }
}
