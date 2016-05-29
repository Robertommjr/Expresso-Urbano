using System.Data.Entity;
using ExpressoUrbano.Infrastructure.Migrations;
using ExpressoUrbano.Infrastructure.Models;
using MySql.Data.Entity;

namespace ExpressoUrbano.Infrastructure.AplicationContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
                : base("ConnDB", throwIfV1Schema: false)
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
