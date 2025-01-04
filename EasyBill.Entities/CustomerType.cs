namespace EasyBill.Entities
{
    public class CustomerType : BaseEntity
    {
        private readonly List<Customer> _customers;

        public CustomerType()
        {
            _customers = new List<Customer>();
        }

        public string Name { get; set; } = string.Empty; // Tür adı (ör. Individual, Corporate)

        // İlişki
        public ICollection<Customer> Customers => _customers;
    }
}
