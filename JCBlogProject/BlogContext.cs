using JCBlogProject.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Politics",
                },

                new Genre()
                {
                    Id = 2,
                    Name = "Programming",
                }
            );

            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    Title = "hi",
                    Author = "Jim",
                    Content = "hello sally",
                    PostDate = new DateTime(1984, 12, 16, 12, 32, 54, DateTimeKind.Unspecified),
                    GenreId = 1,
                },

                new Post()
                {
                    Id = 2,
                    Title = "bye",
                    Author = "sally",
                    Content = "goodby jim",
                    PostDate = new DateTime(1600, 10, 16, 05, 32, 54, DateTimeKind.Unspecified),
                    GenreId = 2,
                },

                new Post()
                {
                    Id = 3,
                    Title = "bye",
                    Author = "sally",
                    Content = "goodby jim",
                    PostDate = new DateTime(1492, 5, 13, 14, 26, 34, DateTimeKind.Unspecified),
                    GenreId = 2,
                }
            );

            modelBuilder.Entity<Post_Tag>().HasData(
                new Post_Tag()
                {
                    Id = 1,
                    PostId = 1,
                    TagId = 1
                },
                new Post_Tag()
                {
                    Id = 2,
                    PostId = 1,
                    TagId = 2
                },
                new Post_Tag()
                {
                    Id = 3,
                    PostId = 2,
                    TagId = 2
                },
                new Post_Tag()
                {
                    Id = 4,
                    PostId = 2,
                    TagId = 3
                },
                new Post_Tag()
                {
                    Id = 5,
                    PostId = 3,
                    TagId = 1
                },
                new Post_Tag()
                {
                    Id = 6,
                    PostId = 3,
                    TagId = 3
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    Id = 1,
                    Name = "greeting",
                },
                new Tag()
                {
                    Id = 2,
                    Name = "Bye",
                },
                new Tag()
                {
                    Id = 3,
                    Name = "ye",
                }

            );
        }
    }
}
