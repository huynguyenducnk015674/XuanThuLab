using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06.razor02.layout.Pages.Shared.Components.ViewProduct
{
    [ViewComponent]
    public class ViewProduct:ViewComponent
    {
        dynamic product;
        public ViewProduct()
        {

        }
        public IViewComponentResult Invoke(dynamic product)
        {
            this.product = product;
            return View("ViewProduct",product);
        }
    }
}
