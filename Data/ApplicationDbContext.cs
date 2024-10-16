using Lemoo_pos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lemoo_pos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserBranch> UserBranches { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<CreateStoreTmp> CreateStoreTmps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                  .HasIndex(u => u.Email)
                  .IsUnique();

            modelBuilder.Entity<UserBranch>()
                .HasOne(u => u.User)
                .WithMany(user => user.Branchs)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<UserBranch>()
              .HasOne(u => u.Branch)
              .WithMany(branch => branch.Users)
              .HasForeignKey(u => u.BranchId);

            modelBuilder.Entity<UserBranch>()
                .HasKey(u => new { u.UserId, u.BranchId });

            modelBuilder.Entity<CreateStoreTmp>()
                .HasIndex(c => c.Code)
                .IsUnique();
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        //public override async Task<int> SaveChangesAsync()
        //{
        //    AddTimestamps();
        //    return await base.SaveChangesAsync();
        //}

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    BaseEntity e = (BaseEntity)entity.Entity;

                    e.CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
