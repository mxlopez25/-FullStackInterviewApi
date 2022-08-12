using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.Helpers {
    public class DataContext: DbContext {
        protected readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration) => _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(_configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}