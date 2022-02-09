namespace Northwind.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Northwind.DataAccess.Concrete.EntityFramework.NorthwindContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Northwind.DataAccess.Concrete.EntityFramework.NorthwindContext";
        }

        protected override void Seed(Northwind.DataAccess.Concrete.EntityFramework.NorthwindContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
