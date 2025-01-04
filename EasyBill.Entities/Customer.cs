namespace EasyBill.Entities
{
    public class Customer : BaseEntity
    {
        private List<Subscription> _subscriptions;

        public Customer()
        {
            _subscriptions = new List<Subscription>();
        }

        public string Name { get; set; } = string.Empty; // Müşteri adı
        public string Email { get; set; } = string.Empty; // Müşteri e-posta adresi
        public string Phone { get; set; } = string.Empty;  // Müşteri telefon numarası
        public string Address { get; set; } = string.Empty;  // Müşteri adresi
        public bool IsActive { get; set; } // Aktiflik durumu

        // İlişki (Navigation Property)
        public int CustomerTypeID { get; set; } // Müşteri türü kimliği
        public CustomerType CustomerType { get; set; } = null!;

        public ICollection<Subscription> Subscriptions => _subscriptions;
    }
}
