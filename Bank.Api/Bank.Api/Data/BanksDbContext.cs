using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bank.Api.Data
{
    public class BanksDbContext : IdentityDbContext<ApplicationUser>
    {
        public BanksDbContext(DbContextOptions<BanksDbContext> options):base(options) { }

        public DbSet<Banks> Banks { get; set; }
    }
}
