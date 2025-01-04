using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface ISubscriptionRepository : IRepository<Subscription>
    {
        IEnumerable<Subscription> GetActiveSubscriptions(); // Aktif abonelikleri getir
        IEnumerable<Subscription> GetSubscriptionsByCustomerId(int customerId); // Belirli bir müşteriye ait abonelikleri getir
        IEnumerable<Subscription> GetSubscriptionsByProviderId(int providerId); // Belirli bir sağlayıcıya ait abonelikleri getir
    }
}
