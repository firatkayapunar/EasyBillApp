namespace EasyBill.Business.Dtos.BillType
{
    public class BillTypeUpdateDto
    {
        public int ID { get; set; } // Güncelleme için gerekli
        public string Name { get; set; } = string.Empty; // Güncellenecek fatura türü adı
    }
}
