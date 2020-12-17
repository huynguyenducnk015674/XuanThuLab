using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _06.razor02.layout.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _06.razor02.layout.Pages
{
    public class ViewProductModel : PageModel
    {
        public Product product;
        public string thongbao;
        public IActionResult OnGet(int id)
        {
            int? ID = null;
            if (Request.RouteValues["id"] != null)
            {
                ID = Int32.Parse(Request.RouteValues["id"].ToString());
                product = ProductContext.FindProductByID(ID.Value);
                if (product == null) return RedirectToPage("ViewProduct", new { id = "" });

            }
            return Page();
        }
        public void OnPostXoa(int i)
        {
            thongbao = $"goi OnPost xoá {i}";
            ViewData["mydata"] = "My data!!!!";
        }
        public void OnPutcapnhat(int i)
        {
            thongbao = $"goi OnPost xoá {i}";
            ViewData["mydata"] = "My data!!!!";
        }
    }
}
