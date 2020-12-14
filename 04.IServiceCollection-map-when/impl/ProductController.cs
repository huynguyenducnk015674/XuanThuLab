using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.IServiceCollection_map_when.impl
{
    public class ProductController
    {
        readonly IListProductName lsPhone;
        readonly IListProductName lsLaptop;
        public ProductController(IListProductName lsPhone, IListProductName lsLaptop)
        {
            this.lsPhone = lsPhone;
            this.lsLaptop = lsLaptop;
        }
        public async Task List(HttpContext context)
        {
            var sb = new StringBuilder();
            var lsPhoneHtml = string.Join("", lsPhone.GetNames().Select(name => name.HtmlTag("li"))).HtmlTag("ul");
            var lsLaptopHtml = string.Join("", lsLaptop.GetNames().Select(name => name.HtmlTag("li"))).HtmlTag("ul");
            sb.Append("Danh sách điện thoại".HtmlTag("h2"));
            sb.Append(lsPhoneHtml);
            sb.Append("Danh sách laptop".HtmlTag("h2"));
            sb.Append(lsLaptopHtml);
            string menu = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
            string html = HtmlHelper.HtmlDocument("DS Sản phẩm", menu + sb.ToString().HtmlTag("div", "container"));

            context.Response.StatusCode = 200;
            await context.Response.WriteAsync(html);

        }
    }
}
