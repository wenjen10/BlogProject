using JCBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Repositories
{
    public class Post_TagRepository : IRepository<Post_Tag>
    {
        private BlogContext db;

        public Post_TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Post_Tag post_Tag)
        {
            db.Post_Tags.Add(post_Tag);
            db.SaveChanges();
        }

        public void Edit(Post_Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post_Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post_Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post_Tag GetById(int id)
        {
            return db.Post_Tags.Single(c => c.Post_TagId == id);
        }
    }
}
