namespace EasyBill.Entities
{
    public class Invoice : BaseEntity
    {
        public decimal Amount { get; set; } // Fatura tutarı
        public DateTime DueDate { get; set; } // Son ödeme tarihi
        public DateTime? PaymentDate { get; set; } // Ödeme tarihi
        public string Status { get; set; } = string.Empty;// Durum (Pending, Paid)

        // İlişkiler
        public int SubscriptionID { get; set; } // Abonelik kimliği
        public Subscription Subscription { get; set; } = null!;
        public int PaymentID { get; set; } // Abonelik kimliği
        public Payment Payment { get; set; } = null!;
    }
}
