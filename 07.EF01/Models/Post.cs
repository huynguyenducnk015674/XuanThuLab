namespace _07.EF01.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        ////reference
        public Blog Blog { get; set; }
        public int BlogId { get; set; }

    }
}
