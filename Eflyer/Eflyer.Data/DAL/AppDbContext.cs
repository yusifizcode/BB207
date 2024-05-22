using Eflyer.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eflyer.Data.DAL;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Electronic> Electronics { get; set; }
    public DbSet<AppUser> Users { get; set; }
}
