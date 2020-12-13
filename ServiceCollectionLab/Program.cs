using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace ServiceCollectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ////Tạo Service collection 
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<A>();
            serviceCollection.AddTransient<B>();
            serviceCollection.AddScoped<C>();
            serviceCollection.AddTransient<D>((serviceProvider) =>
            {
                return new D(serviceProvider.GetService<A>(), 123);
            });
            // Tạo service Provider
            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
           
            B b1 = serviceProvider.GetService<B>();
            B b2 = serviceProvider.GetService<B>();
            b1.ShowInfo();
            b2.ShowInfo();
            A a1 = serviceProvider.GetService<A>();
            /////////////////////////////////////////////////
            C c1 = serviceProvider.GetService<C>();
            C c2 = serviceProvider.GetService<C>();
            c1.ShowInfo();
            c2.ShowInfo();
            /////////////////////////////////////////////////////
            //Tạo scope mới 
            var scope = serviceProvider.CreateScope();
            C c3 = scope.ServiceProvider.GetService<C>();
            /////////////////////////////////////////////////////////
            var d = serviceProvider.GetService<D>();
            d.Display();
            ////////////////////////////////////////////////////////
            //Use option
            serviceCollection.AddOptions();
            //Register option and init value
            serviceCollection.Configure<MyServiceOptions>((option) =>
            {
                option.data1 = "This is value of option service";
                option.data2 = 10;
                option.objA = serviceProvider.GetService<A>();
            });
            serviceCollection.AddTransient<MyService>();
            serviceProvider = serviceCollection.BuildServiceProvider();
            MyService _service = serviceProvider.GetService<MyService>();
            _service.ShowData();
            ////////////////////////////////////////////////////////////
            var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var root=configBuilder.Build();
            var key = root.GetSection("option1").GetSection("key1").Value;
            Console.ReadLine();

        }
    }
}
