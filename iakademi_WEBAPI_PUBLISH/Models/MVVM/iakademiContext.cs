using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace iakademi_WEBAPI_PUBLISH.Models.MVVM
{
    public class iakademiContext :DbContext
    {
        //bağlantı ayarı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  var builder = new ConfigurationBuilder() = Konfigürasyon (ayar) okuyacak bir nesne oluşturuyor.
            // SetBasePath(Directory.GetCurrentDirectory()) = Ayar dosyalarını nerede arayacağını söylüyor.
            // AddJsonFile("appsettings.json");     =  Ayar kaynağı olarak appsettings.json dosyasını ekliyor.

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            // Okuyacağın ayarları derleyip kullanılabilir hale getiriyor.
            var configuration = builder.Build();

            // SQL Server kullanacaksın ve bağlantın bu olacak.
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:iakademi46Connection"]);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
