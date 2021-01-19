using System;

namespace _10._PageModel.Models
{
    public class Product
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public String Desciption { set; get; }
        public Decimal Price { set; get; } = 0;
    }
}
