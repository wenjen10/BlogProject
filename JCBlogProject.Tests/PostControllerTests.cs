using JCBlogProject.Controllers;
using JCBlogProject.Models;
using JCBlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JCBlogProject.Tests
{
    public class PostControllerTests
    {
        PostController underTest;
        IRepository<Post> postRepo;

        public PostControllerTests()
        {
            postRepo = Substitute.For<IRepository<Post>>();
            underTest = new PostController(postRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Returns_A_View()
        {
            var result = underTest.Create(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Delete_Returns_A_View()
        {
            var result = underTest.Delete(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Edit_Returns_A_View()
        {
            var result = underTest.Edit(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Edit_Passes_Review_To_View()
        {
            var expectedPost = new Post();
            postRepo.GetById(5).Returns(expectedPost);

            var result = underTest.Edit(5);

            Assert.Equal(expectedPost, result.Model);
        }
    }
}
