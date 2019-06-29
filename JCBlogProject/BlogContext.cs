using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject
{
    public class BlogContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post_Tag> Post_Tags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=JCBlogProjectDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
