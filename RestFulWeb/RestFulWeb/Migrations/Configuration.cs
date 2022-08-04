namespace RestFulWeb.Migrations
{
    using RestFulWeb.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RestFulWeb.Models.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestFulWeb.Models.UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var user = new User
            {            
                Uid = 2019302110218,
                Name = "xlf",
                Password = "123456",
                Tel = "13867541234",
                Address = "湖北省武汉市信息学部三舍"
             };
            context.Users.Add(user);
            user = new User
            {
                Uid = 2019302110423,
                Name = "gxl",
                Password = "654321",
                Tel = "1122344556",
                Address = "湖北省武汉市信息学部三舍"
            };
            context.Users.Add(user);
        }
    }
}
