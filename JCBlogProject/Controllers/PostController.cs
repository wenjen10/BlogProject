using JCBlogProject.Models;
using JCBlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;

        }
        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }
    }
}
