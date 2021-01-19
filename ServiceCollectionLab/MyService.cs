using Microsoft.Extensions.Options;
using System;

namespace ServiceCollectionLab
{
    class MyService
    {
        readonly string data1;
        readonly int data2;
        readonly A data3;

        public MyService(IOptions<MyServiceOptions> options)
        {
            this.data1 = options.Value.data1;
            this.data2 = options.Value.data2;
            this.data3 = options.Value.objA;
            Console.WriteLine($"{this.GetType().Name} is created !!!");

        }
        public void ShowData()
        {
            Console.WriteLine($"{data1} -  {data2}");
            data3.ShowInfo();
        }
    }
}
