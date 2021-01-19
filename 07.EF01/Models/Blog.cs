using System.Collections.Generic;

namespace _07.EF01.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        // reference
        public List<Post> Posts { get; set; }
    }
}
