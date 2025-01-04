namespace EasyBill.Entities
{
    public class Subscription : BaseEntity
    {
        private readonly List<Invoice> _invoices;

        public Subscription()
        {
            _invoices = new List<Invoice>();
        }

        public string AccountNumber { get; set; } = string.Empty; // Hesap numarası
        public DateTime StartDate { get; set; } // Başlangıç tarihi
        public DateTime? EndDate { get; set; } // Bitiş tarihi
        public bool IsActive { get; set; } // Aktiflik durumu

        // İlişkiler
        public int CustomerID { get; set; } // Müşteri kimliği
        public Customer Customer { get; set; } = null!;
        public int ProviderID { get; set; } // Şirket kimliği
        public Provider Provider { get; set; } = null!;

        public ICollection<Invoice> Invoices  => _invoices;
    }
}
