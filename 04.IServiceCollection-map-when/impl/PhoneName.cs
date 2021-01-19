using System.Collections.Generic;

namespace _04.IServiceCollection_map_when.impl
{
    public class PhoneName : IListProductName
    {
        public PhoneName() => System.Console.WriteLine("PhoneName created");
        // Mảng tên các điện thoại
        private List<string> phone_names = new List<string> {
        "Iphone 7", "Samsung Galaxy", "Nokia 123"
    };
        public IEnumerable<string> GetNames()
        {
            return phone_names;
        }
    }
}
