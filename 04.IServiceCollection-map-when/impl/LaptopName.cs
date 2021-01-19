using System;
using System.Collections.Generic;

namespace _04.IServiceCollection_map_when.impl
{
    public class LaptopName : IListProductName
    {
        string[] laptops = new string[]
       {
            "Apple MacBook Pro 13 inch", "HP Spectre X360", "Samsung Chromebook Pro"
       };
        public LaptopName() => Console.WriteLine($"{this.GetType().Name} is created !!!");
        public IEnumerable<string> GetNames()
        {
            return laptops;
        }
    }
}
