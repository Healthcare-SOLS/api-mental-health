using Microsoft.EntityFrameworkCore;

namespace Calm_Healing.DAL.Models
{
    public class TenantDbContext : DbContext
    {
        public TenantDbContext(DbContextOptions<TenantDbContext> options)
            : base(options)
        {
        }

        // ✅ Fixed "public" schema tables
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProviderGroup> ProviderGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Soft deletes: filter out deleted records globally
            modelBuilder.Entity<User>().HasQueryFilter(u => u.DeletedAt == null);
   //         modelBuilder.Entity<Role>().HasQueryFilter(r => r.DeletedAt == null);
            modelBuilder.Entity<Country>().HasQueryFilter(c => c.DeletedAt == null);
            modelBuilder.Entity<State>().HasQueryFilter(s => s.DeletedAt == null);
            modelBuilder.Entity<Address>().HasQueryFilter(a => a.DeletedAt == null);
            modelBuilder.Entity<ProviderGroup>().HasQueryFilter(p => p.DeletedAt == null);
        }
    }
}
