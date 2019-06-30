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
        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.Post_TagId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post post)
        {
            postRepo.Edit(post);
            return RedirectToAction("Index/");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            postRepo.Delete(post);
            return RedirectToAction("Index");
        }
    }
}
