using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCBlogProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Post_Tag> Post_Tags { get; set; }
    }
}
