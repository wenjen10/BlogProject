using JCBlogProject.Models;
using JCBlogProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Controllers
{
    public class Post_TagController : Controller
    {
        IRepository<Post_Tag> post_tagRepo;

        public Post_TagController(IRepository<Post_Tag> post_tagRepo)
        {
            this.post_tagRepo = post_tagRepo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
           
            ViewBag.PostId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post_Tag post_tag)
        {
            post_tagRepo.Create(post_tag);
            return RedirectToAction("../Post/Index/");
        }
    }
}
