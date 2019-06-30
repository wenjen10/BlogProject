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

        public void Create(Post_Tag post_Tag)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
