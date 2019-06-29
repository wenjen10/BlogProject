using JCBlogProject.Models;
using JCBlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> tagRepo;

        public TagController(IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        public ViewResult Index()
        {
            var model = tagRepo.GetAll();
            return View(model);
        }

    }
}
