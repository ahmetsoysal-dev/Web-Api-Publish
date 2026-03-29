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

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:iakademi46Connection"]);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
