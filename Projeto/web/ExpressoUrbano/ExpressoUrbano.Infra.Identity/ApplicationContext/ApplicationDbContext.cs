using System.Data.Entity;
using ExpressoUrbano.Infra.Identity.Migrations;
using ExpressoUrbano.Infra.Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;

namespace ExpressoUrbano.Infra.Identity.ApplicationContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
                : base("ConnDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        static ApplicationDbContext()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>()
                .Property(c => c.Name).HasMaxLength(128).IsRequired();

            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers")
                .Property(c => c.UserName).HasMaxLength(128).IsRequired();
        }

        public DbSet<AplicationUserIdentity> AplicationUserIdentity { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
