using LHBOL;
using Microsoft.EntityFrameworkCore;
using System;

namespace LHDAL
{
    public class LHDBContext : DbContext
    {
        public LHDBContext(DbContextOptions<LHDBContext> options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source = MPC\SQLEXPRESS; Initial Catalog = LinksHub; User ID = sa; Password = ssemkd");
        //}

        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<URLs> LHUrls { get; set; }
    }
}