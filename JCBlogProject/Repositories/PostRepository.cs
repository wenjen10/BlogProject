git using JCBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(c => c.Id == id);
        }

        //public void Create(Post post)
        //{
        //    db.Posts.Add(post);
        //    db.SaveChanges();
        //}

        //public void Delete(Post post)
        //{
        //    db.Posts.Delete(post)
        //    db.SaveChanges();
        //}

        //public void Edit(Post post)
        //{
        //    db.Posts.Update(post);
        //    db.SaveChanges();
        //}
    }
}
