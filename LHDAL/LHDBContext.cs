using LHBOL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace LHDAL
{
    //public class LHDBContext : DbContext
    public class LHDBContext : IdentityDbContext
    {
        public LHDBContext(DbContextOptions<LHDBContext> options)
            : base(options)
        {
            /*
            Database.EnsureDeleted();//Deletes the existing DB//This is not used at runtime//Avoid it as it is dangerous//Use only Database.EnsureCreated at runtime
            Database.Migrate();//Create new if doesn't exist already and/or applies latest updates(pending updates)
            */
            //Database.EnsureCreated();

            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            //    optionsBuilder.UseSqlServer(@"Data Source = MPC\SQLEXPRESS; Initial Catalog = LinksHub; User ID = sa; Password = ssemkd");
            //}
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<URLs> LHUrls { get; set; }
    }
}