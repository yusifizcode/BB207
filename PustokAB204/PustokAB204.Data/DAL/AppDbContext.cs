using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PustokAB204.Core.Models;

namespace PustokAB204.Data.DAL;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Tag> Tags { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<AppUser> Users { get; set; }
}
