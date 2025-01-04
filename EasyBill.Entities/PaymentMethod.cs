namespace EasyBill.Entities
{
    public class PaymentMethod : BaseEntity
    {
        private readonly List<Payment> _paymentList;

        public PaymentMethod()
        {
            _paymentList = new List<Payment>();
        }

        public string Name { get; set; } = string.Empty; // Ödeme yöntemi adı (ör. Nakit, Kart)

        // İlişki
        public ICollection<Payment> Payments => _paymentList;
    }
}
