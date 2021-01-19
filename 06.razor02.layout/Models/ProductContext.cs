using System.Collections.Generic;
using System.Linq;

namespace _06.razor02.layout.Models
{
    public static class ProductContext
    {
        public static List<Product> products;
        static ProductContext()
        {
            products = new List<Product>()
            {
                new Product
                {
                    ID = 1,
                    Name = "Iphone",
                    Price = 900,
                    Description = "Điện thoại Iphone abc, xyz ..."
                },
                new Product
                {
                    ID = 2,
                    Name = "Samsung",
                    Price = 800,
                    Description = "Điện thoại Samsung, samsung điện thoại ..."
                },
                new Product
                {
                    ID = 3,
                    Name = "Nokia",
                    Price = 700,
                    Description = "Điện thoại Nokia, điện thoại Android"
                }

            };
        }
        public static Product FindProductByID(int id)
        {
            var p = from product in products where product.ID == id select product;
            return p.FirstOrDefault();

        }
    }
}
