using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Models
{
    public class Post_Tag
    {
        public int Post_TagId { get; set; }
        public virtual int PostId { get; set; }
        public virtual Post Posts { get; set; }

        public virtual int TagId { get; set; }
        public virtual Tag Tags { get; set; }
    }
}
