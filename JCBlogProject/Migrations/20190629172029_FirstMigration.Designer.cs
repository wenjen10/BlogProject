﻿// <auto-generated />
using System;
using JCBlogProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JCBlogProject.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20190629172029_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JCBlogProject.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new { Id = 1, Name = "Politics" },
                        new { Id = 2, Name = "Programming" }
                    );
                });

            modelBuilder.Entity("JCBlogProject.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<int>("GenreId");

                    b.Property<DateTime>("PostDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Posts");

                    b.HasData(
                        new { Id = 1, Author = "Jim", Content = "hello sally", GenreId = 1, PostDate = new DateTime(1984, 12, 16, 12, 32, 54, 0, DateTimeKind.Unspecified), Title = "hi" },
                        new { Id = 2, Author = "sally", Content = "goodby jim", GenreId = 2, PostDate = new DateTime(1600, 10, 16, 5, 32, 54, 0, DateTimeKind.Unspecified), Title = "bye" },
                        new { Id = 3, Author = "sally", Content = "goodby jim", GenreId = 2, PostDate = new DateTime(1492, 5, 13, 14, 26, 34, 0, DateTimeKind.Unspecified), Title = "bye" }
                    );
                });

            modelBuilder.Entity("JCBlogProject.Models.Post_Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("Post_Tags");

                    b.HasData(
                        new { Id = 1, PostId = 1, TagId = 1 },
                        new { Id = 2, PostId = 1, TagId = 2 },
                        new { Id = 3, PostId = 2, TagId = 2 },
                        new { Id = 4, PostId = 2, TagId = 3 },
                        new { Id = 5, PostId = 3, TagId = 1 },
                        new { Id = 6, PostId = 3, TagId = 3 }
                    );
                });

            modelBuilder.Entity("JCBlogProject.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "greeting" },
                        new { Id = 2, Name = "Bye" },
                        new { Id = 3, Name = "ye" }
                    );
                });

            modelBuilder.Entity("JCBlogProject.Models.Post", b =>
                {
                    b.HasOne("JCBlogProject.Models.Genre", "Genre")
                        .WithMany("Posts")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JCBlogProject.Models.Post_Tag", b =>
                {
                    b.HasOne("JCBlogProject.Models.Post", "Posts")
                        .WithMany("Post_Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JCBlogProject.Models.Tag", "Tags")
                        .WithMany("Post_Tags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}