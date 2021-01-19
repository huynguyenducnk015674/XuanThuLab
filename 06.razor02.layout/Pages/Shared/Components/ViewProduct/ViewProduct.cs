using Microsoft.AspNetCore.Mvc;

namespace _06.razor02.layout.Pages.Shared.Components.ViewProduct
{
    [ViewComponent]
    public class ViewProduct : ViewComponent
    {
        dynamic product;
        public ViewProduct()
        {

        }
        public IViewComponentResult Invoke(dynamic product)
        {
            this.product = product;
            return View("ViewProduct", product);
        }
    }
}
