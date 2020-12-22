using _07.EF01.Context;
using _07.EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace _07.EF01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Blog Entity Framework");
            using ( BloggingContext context = new BloggingContext())
            {
                Addobject(context);
            }
                Console.ReadLine();
        }
        static void Addobject(BloggingContext context)
        {
            var blog = new Blog()
            {
                Rating = 5,
                Url = "xxx.com"
            };
            context.Add<Blog>(blog);
            context.SaveChanges();
            var post = new Post()
            {
                Blog = blog,
                Content = $"This is post of Blog {blog.BlogId}",
                Title = "Demo"

            };
            context.Add<Post>(post);
            context.SaveChanges();
        }
    }
}
