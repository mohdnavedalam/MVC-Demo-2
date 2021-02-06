namespace MVC_Demo_2.Migrations
{
    using MVC_Demo_2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Demo_2.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //to enable migrations for this application
        }

        protected override void Seed(MVC_Demo_2.Models.VideoDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Videos.AddOrUpdate(v => v.Title, 
                new Video() { Title = "MVC 4", Length = 120, Category = "Basic", Format = "WMV" },
                new Video() { Title = "MVC 5", Length = 80, Category = "Advanced", Format = "AVI" },
                new Video() { Title = "JQuery", Length = 130, Category = "Advanced", Format = "WMV" },
                new Video() { Title = "LINQ", Length = 100, Category = "Basic", Format = "WMV" }
                );
        }
    }
}
