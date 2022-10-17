namespace NoteTakingApp.Migrations
{
    using NoteTakingApp.Data;
    using NoteTakingApp.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Categories.Any())
            {
                var personal = new Category() { Name = "Personal" };
                var school = new Category() { Name = "School" };
                var work = new Category() { Name = "Work" };

                context.Categories.Add(personal);
                context.Categories.Add(school);
                context.Categories.Add(work);
            }

            if (!context.Notes.Any())
            {
                var exampleNote1 = new Note()
                {
                    Title = "Example Note 1",
                    Description = "This is the first example note."
                };
                var exampleNote2 = new Note()
                {
                    Title = "Example Note 2",
                    Description = "This is the second example note."
                };
                var exampleNote3 = new Note()
                {
                    Title = "Example Note 3",
                    Description = "This is the third example note."
                };

                context.Notes.Add(exampleNote1);
                context.Notes.Add(exampleNote2);
                context.Notes.Add(exampleNote3);
            }

            context.SaveChanges();
        }
    }
}
