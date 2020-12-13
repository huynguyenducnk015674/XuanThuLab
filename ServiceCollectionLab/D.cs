using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    class D:BaseInformation
    {
        A dependency;
        int number = 0;
        public D(A dependency, int number)
        {
            this.dependency = dependency;
            this.number = number;
            NotifyCreate();
        }
        public  void Display()
        {
            Console.WriteLine($"This is function of D with number ={number}");
        }
    }
}
