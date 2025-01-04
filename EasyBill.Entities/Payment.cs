namespace EasyBill.Entities
{
    public class Payment : BaseEntity
    {
        public DateTime PaymentDate { get; set; } // Ödeme tarihi
        public decimal PaymentAmount { get; set; } // Ödenen tutar

        // İlişkiler
        public int InvoiceID { get; set; } // Fatura kimliği
        public Invoice Invoice { get; set; } = null!;
        public int PaymentMethodID { get; set; } // Ödeme yöntemi kimliği
        public PaymentMethod PaymentMethod { get; set; } = null!;
        public int ProcessedBy { get; set; } // İşlemi yapan çalışan kimliği
        public Employee Employee { get; set; } = null!;
    }
}
