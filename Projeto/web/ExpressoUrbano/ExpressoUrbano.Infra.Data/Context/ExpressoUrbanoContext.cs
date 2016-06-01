using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ExpressoUrbano.Infra.Data.Migrations;
using ExpressoUrbano.Infra.Data.EntityConfig;
using MySql.Data.Entity;

namespace ExpressoUrbano.Infra.Data.Context
{
    public class ExpressoUrbanoContext : DbContext
    {
        public ExpressoUrbanoContext() : base("ConnDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ExpressoUrbanoContext, Configuration>());
        }

        static ExpressoUrbanoContext()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Prefix table names
            //modelBuilder.Types().Configure(entity => entity.ToTable("rcsadmin_" + entity.ClrType.Name));

            modelBuilder.Properties()
                .Where(
                    properties =>
                        properties.ReflectedType != null && properties.Name == properties.ReflectedType.Name + "Id")
                .Configure(properties => properties.IsKey());
            modelBuilder.Properties<string>().Configure(properties => properties.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(properties => properties.HasMaxLength(250));

            modelBuilder.Configurations.Add(new RotaConfig());
        }

        public override int SaveChanges()
        {
            #region data de registro - insercao

            foreach (
                var entry in
                    ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DtRegistro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DtRegistro").CurrentValue = DateTime.Now;
                }
            }

            #endregion

            #region data de modificação - alteração

            foreach (
                var entry in
                    ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DtModificacao") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DtModificacao").CurrentValue = DateTime.Now;
                }
            }

            #endregion

            #region status - inserção

            foreach (
                var entry in
                    ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Status") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Status").CurrentValue = true;
                }
            }

            #endregion

            return base.SaveChanges();
        }
    }
}
