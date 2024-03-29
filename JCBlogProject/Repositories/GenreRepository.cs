﻿using JCBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        private BlogContext db;

        public GenreRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Genre obj)
        {
            throw new NotImplementedException();
        }
        
        public void Edit(Genre obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genre obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            return db.Genres.Single(c => c.Id == id);
        }
    }
}
