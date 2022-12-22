using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<DetailActivity> DetailActivities { get; set; }
        public DbSet<PaceActivity> PaceActivities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // You don't actually ever need to call this
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-MK0KDOG\SQLEXPRESS; Database = MyAppDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder) { }

    }
}
