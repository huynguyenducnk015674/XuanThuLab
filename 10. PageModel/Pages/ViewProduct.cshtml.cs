using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10._PageModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _10._PageModel.Pages
{
    public class ViewProductModel : PageModel
    {
        public String Thongbao;
        public Product product;
        public async Task<IActionResult> OnGetCallBackAsync(string returnUrl = null, string remoteError = null)
        {
            return NotFound();
        }
        public async Task<IActionResult> OnGetCallAsync()
        {
            return  NotFound();
        }
        public async Task<IActionResult> OnGet(string returnUrl = null, string remoteError = null)
        {
            int? ID = null;
            if (Request.RouteValues["id"] != null)
            {
                ID = Int32.Parse(Request.RouteValues["id"].ToString());
                product = ProductContext.FindProductByID(ID.Value);

            }
            return NotFound();
        }
        public void OnPostXoa(int id)
        {
            Thongbao = "Gọi OnPostXoa";
        }
        // Chạy truy cập post tới, url = /sanpham/2?handler=soanthao
        public void OnPostSoanthao(int id)
        {
            Thongbao = "Gọi OnPostSoanthao";
        }
        // Chạy truy cập post tới, url = /sanpham/2?handler=xemchitiet
        public void OnPostXemchitiet(int id)
        {
            Thongbao = "Gọi OnPostXemchitiet";
        }
    }
}
