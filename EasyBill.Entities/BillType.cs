namespace EasyBill.Entities
{
    public class BillType : BaseEntity
    {
        private readonly List<Provider> _providers;

        public BillType()
        {
            _providers = new List<Provider>();
        }

        public string Name { get; set; } = string.Empty; // Tür adı (ör. Su, Elektrik)

        // İlişki
        public ICollection<Provider> Providers => _providers;
    }
}
