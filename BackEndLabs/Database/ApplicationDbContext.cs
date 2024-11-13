using BackEndLabs.Configuration;
using BackEndLabs.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolesAndPermissions> RolesAndPermissions { get; set; }
        public DbSet<UsersAndRoles> UsersAndRoles { get; set; }
        public DbSet<ChangeLogs> ChangeLogs { get; set; }
        public DbSet<LogsRequests> LogsRequests { get; set; }
        public DbSet<Models.File> Files { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new RolesAndPermissionsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersAndRolesConfiguration());
            modelBuilder.ApplyConfiguration(new TokenConfiguration());

            //modelBuilder.Entity<LogsRequests>()
            //    .HasQueryFilter();
                
            base.OnModelCreating(modelBuilder);
        }

    }
}
