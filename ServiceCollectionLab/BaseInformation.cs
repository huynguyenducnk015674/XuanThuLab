using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    abstract class BaseInformation
    {
        public void ShowInfo() => Console.WriteLine($"{this.GetType().Name}-{this.GetHashCode()}");
        //Thông báo khi object được tạo
        public void NotifyCreate() => Console.WriteLine($"{this.GetType().Name} Created !!!");
    }
}
