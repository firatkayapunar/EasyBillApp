using EasyBill.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyBill.DataAccess.Context
{
    public class EasyBillDBContext : DbContext
    {

        // .NET Core ve üzeri uygulamalarda, Dependency Injection varsayılan olarak desteklenir.
        // DbContextOptions değeri, genellikle Startup.cs veya Program.cs dosyasında tanımlanır ve uygulama başlatılırken DI konteynerine eklenir.

        //Örnek:

        // Program.cs (ASP.NET Core için)

        // var builder = WebApplication.CreateBuilder(args);
        // builder.Services.AddDbContext<EasyBillDBContext>(options =>
        // options.UseSqlServer(builder.Configuration.GetConnectionString("EasyBillDB")));
        // var app = builder.Build();

        // Açıklama:

        // AddDbContext<EasyBillDBContext> çağrısı, EasyBillDBContext sınıfını DI konteynerine ekler.
        // options.UseSqlServer ile, kullanılacak veritabanı sağlayıcısı ve bağlantı dizesi belirtilir.
        // builder.Configuration.GetConnectionString("EasyBillDB"), appsettings.json dosyasındaki bağlantı dizesini okur.

        // appsettings.json Örneği:

        // {
        //  "ConnectionStrings": {
        //    "EasyBillDB": "Server=.;Database=EasyBill;Trusted_Connection=True;"
        //  }
        // }

        // DbContextOptions nesnesi, bu ayarlara göre DI konteyneri tarafından otomatik olarak oluşturulur ve  EasyBillDBContext sınıfına enjekte edilir.

        public EasyBillDBContext(DbContextOptions<EasyBillDBContext> options)
          : base(options)
        { }

        // DbSet Tanımları
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //DbSet             Tablo Adı          Açıklama
        //Customers         Customer           Müşterileri temsil eder.
        //CustomerTypes     CustomerType       Müşteri türlerini (örneğin: bireysel, kurumsal) saklar.
        //Providers         Provider           Hizmet sağlayıcılarını temsil eder. (örneğin: elektrik, su şirketleri).
        //BillTypes         BillType           Fatura türlerini ifade eder. (örneğin: elektrik faturası, su faturası).
        //Subscriptions     Subscription       Abonelik bilgilerini tutar.
        //Invoices          Invoice            Faturaları temsil eder.
        //Payments          Payment            Ödemeleri saklar.
        //PaymentMethods    PaymentMethod      Ödeme yöntemlerini belirtir (örneğin: kredi kartı, nakit).
        //Employees         Employee           Çalışan bilgilerini içerir.
    }
}
