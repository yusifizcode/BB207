using Microsoft.EntityFrameworkCore;
using ProniaBB207.Core.Models;

namespace ProniaBB207.Data.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Category> Categories { get; set; }
}
