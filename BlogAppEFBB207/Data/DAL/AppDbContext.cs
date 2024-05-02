using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-L6JGBQE\\SQLEXPRESS;Database=ProductAppBB207;Trusted_Connection=true;Integrated Security=true;Encrypt=false;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}
