using JCBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }

        public Tag GetById(int id)
        {
            return db.Tags.Single(c => c.Id == id);
        }
    }
}
