using Microsoft.EntityFrameworkCore;
namespace demoIdentity.Models
{
    public class ProductContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
    }
}