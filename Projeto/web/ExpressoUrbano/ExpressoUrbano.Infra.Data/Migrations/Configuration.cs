using ExpressoUrbano.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace ExpressoUrbano.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ExpressoUrbanoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExpressoUrbanoContext context)
        {
            
        }
    }
}
