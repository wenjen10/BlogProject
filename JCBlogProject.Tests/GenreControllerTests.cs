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
    public class GenreControllerTests
    {
        GenreController underTest;
        IRepository<Genre> genreRepo;

        public GenreControllerTests()
        {
            genreRepo = Substitute.For<IRepository<Genre>>();
            underTest = new GenreController(genreRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }
    }
}
