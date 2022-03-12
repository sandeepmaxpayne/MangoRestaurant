using Mango.Services.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
