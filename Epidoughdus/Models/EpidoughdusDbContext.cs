using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Epidoughdus.Models
{
    public class EpidoughdusContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavor> Flavors { get; set; }
        public DbSet<Treat> Treats { get; set; }
        public DbSet<FlavorTreat> FlavorTreats { get; set; }

        public EpidoughdusContext(DbContextOptions options) : base(options) { }
    }
}