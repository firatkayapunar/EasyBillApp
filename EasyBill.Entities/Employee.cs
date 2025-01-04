namespace EasyBill.Entities
{
    public class Employee : BaseEntity
    {
        private readonly List<Payment> _payments;

        public Employee()
        {
            _payments = new List<Payment>();
        }

        public string Name { get; set; } = string.Empty;// Çalışan adı
        public string Email { get; set; } = string.Empty; // Çalışan e-posta adresi
        public string Phone { get; set; } = string.Empty; // Çalışan telefon numarası
        public string Role { get; set; } = string.Empty;// Çalışan rolü (ör. Clerk, Manager)

        // İlişki
        public ICollection<Payment> Payments => _payments;
    }
}
