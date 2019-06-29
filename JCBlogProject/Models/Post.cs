using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Models
{
    public class Post
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }

        public DateTime PostDate { get; set; }
        
        public virtual int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual List<Post_Tag> Post_Tags { get; set; }
    }
}
