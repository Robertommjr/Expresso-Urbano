using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpressoUrbano.Infrastructure.Migrations;

namespace ExpressoUrbano.Infrastructure.Context
{
    public class ExpressoUrbanoContext : DbContext
    {
        public ExpressoUrbanoContext() : base("ConnDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ExpressoUrbanoContext, Configuration>());
        }
    }
}
