using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ExpressoUrbano.Infrastructure.Models;
using ExpressoUrbano.Infrastructure.Context;
using MySql.Data.Entity;

namespace ExpressoUrbano.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ExpressoUrbanoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
            CodeGenerator = new MySqlMigrationCodeGenerator();
        }

        protected override void Seed(ExpressoUrbanoContext context)
        {
            if (!(context.Users.Any(u => u.UserName == "administrador")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "administrador", Email = "robertomartins.m.jr@gmail.com" };
                userManager.Create(userToInsert, "roberto@123");
            }

        }
    }
}
