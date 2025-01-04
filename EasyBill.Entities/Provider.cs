namespace EasyBill.Entities
{
    public class Provider : BaseEntity
    {
        private List<Subscription> _subscriptions;

        public Provider()
        {
            _subscriptions = new List<Subscription>();
        }

        public string Name { get; set; } = string.Empty;// Şirket adı

        // İlişki
        public int BillTypeID { get; set; } // İlgili fatura türü kimliği
        public BillType BillType { get; set; } = null!;

        public ICollection<Subscription> Subscriptions => _subscriptions;
    }
}
