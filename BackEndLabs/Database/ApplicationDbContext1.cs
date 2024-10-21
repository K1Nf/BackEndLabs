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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new RolesAndPermissionsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersAndRolesConfiguration());

            
            base.OnModelCreating(modelBuilder);
        }

    }
}
