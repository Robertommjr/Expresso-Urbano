using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;
using ExpressoUrbano.Infra.Identity.Models;
using System.Linq;

namespace ExpressoUrbano.Infra.Identity.Migrations
{
    using ApplicationContext;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            CodeGenerator = new MySqlMigrationCodeGenerator();
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!(context.Users.Any(u => u.UserName == "administrador")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "administrador"};
                userManager.Create(userToInsert, "tcc@123");
            }
        }
    }
}
