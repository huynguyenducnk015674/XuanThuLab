using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _04.IServiceCollection_map_when.impl
{
    public class ProductController
    {
        readonly IListProductName lsPhone;
        readonly IListProductName lsLaptop;
        readonly IOptions<TestOptions> lvOption;
        public ProductController(IListProductName lsPhone, IListProductName lsLaptop,IOptions<TestOptions> options)
        {
            this.lsPhone = lsPhone;
            this.lsLaptop = lsLaptop;
            this.lvOption = options;
        }
        public async Task List(HttpContext context)
        {
            CountAccess(context);
            var sb = new StringBuilder();
            var lsPhoneHtml = string.Join("", lsPhone.GetNames().Select(name => name.HtmlTag("li"))).HtmlTag("ul");
            var lsLaptopHtml = string.Join("", lsLaptop.GetNames().Select(name => name.HtmlTag("li"))).HtmlTag("ul");
            sb.Append(lvOption.Value.opt_key1.HtmlTag("h2"));
            sb.Append(lsPhoneHtml);
            sb.Append(lvOption.Value.opt_key2.K1.HtmlTag("h2"));
            sb.Append(lsLaptopHtml);
            string menu = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
            string html = HtmlHelper.HtmlDocument("DS Sản phẩm", menu + sb.ToString().HtmlTag("div", "container"));

            context.Response.StatusCode = 200;
            await context.Response.WriteAsync(html);

        }
        public void CountAccess(HttpContext context)
        {
            var _session = context.Session;
            string key_Access = "info_access";
            var accessInfoType = new
            {
                count = 0,
                lasttime = DateTime.Now
            };
            //Đọc chuỗi trong session 
            string json = _session.GetString(key_Access);
            dynamic lastAccessInfo;
            if (json != null)
            {
                lastAccessInfo = JsonConvert.DeserializeObject(json, accessInfoType.GetType());
            }
            else
            {
                lastAccessInfo = accessInfoType;
            }
            var accessInfoSave = new
            {
                count = lastAccessInfo.count + 1,
                lasttime = DateTime.Now
            };
            string jsonSave = JsonConvert.SerializeObject(accessInfoSave);
            _session.SetString(key_Access, jsonSave);
            Console.WriteLine(accessInfoSave);
        }
        public static string  CountAccessInfo(HttpContext context)
        {
            var _session = context.Session;
            string key_access = "info_access";
            var accessInfoType = new
            {
                count = 0,
                lasttime = DateTime.Now
            };
            _session.GetString(key_access);           
            dynamic lastAccessInfo;
            string json = _session.GetString(key_access);
            if (json!=null){
                lastAccessInfo = JsonConvert.DeserializeObject(json, accessInfoType.GetType());
            }
            else
            {
                lastAccessInfo = accessInfoType;
            }
            if (lastAccessInfo.count == 0)
            {
                return $"Chưa truy cập trang Product lần nào".HtmlTag("p");
            }
            string thongtin = $"Số lần truy cập trang product: {lastAccessInfo.count} - " +
                $"lần cuối vào lúc {lastAccessInfo.lasttime.ToLongTimeString()}";
            return thongtin;
        }
    }
}
