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
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    PostDate = new DateTime(1984, 12, 16, 12, 32, 54, DateTimeKind.Unspecified),
                    GenreId = 1,
                },

                new Post()
                {
                    Id = 2,
                    Title = "Lorem",
                    Author = "sally",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    PostDate = new DateTime(1600, 10, 16, 05, 32, 54, DateTimeKind.Unspecified),
                    GenreId = 2,
                },

                new Post()
                {
                    Id = 3,
                    Title = "Ipsum",
                    Author = "sally",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    PostDate = new DateTime(1492, 5, 13, 14, 26, 34, DateTimeKind.Unspecified),
                    GenreId = 2,
                }
            );

            modelBuilder.Entity<Post_Tag>().HasData(
                new Post_Tag()
                {
                    Post_TagId = 1,
                    PostId = 1,
                    TagId = 1
                },
                new Post_Tag()
                {
                    Post_TagId = 2,
                    PostId = 1,
                    TagId = 2
                },
                new Post_Tag()
                {
                    Post_TagId = 3,
                    PostId = 2,
                    TagId = 2
                },
                new Post_Tag()
                {
                    Post_TagId = 4,
                    PostId = 2,
                    TagId = 3
                },
                new Post_Tag()
                {
                    Post_TagId = 5,
                    PostId = 3,
                    TagId = 1
                },
                new Post_Tag()
                {
                    Post_TagId = 6,
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
                    Name = "Salutation",
                },
                new Tag()
                {
                    Id = 3,
                    Name = "yeet",
                }

            );
        }
    }
}
