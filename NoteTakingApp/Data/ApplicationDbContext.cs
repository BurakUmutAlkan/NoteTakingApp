using NoteTakingApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=MyConnection")
        {
        }

        // DbSet will be added below.

        public DbSet<Note> Notes => Set<Note>();
        public DbSet<Category> Categories => Set<Category>();
    }
}
