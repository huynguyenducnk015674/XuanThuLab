#pragma checksum "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318c57b409255143a750a2864fdeaf8f53c56a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_09.Album.Pages.Shared.Pages_Shared__Pagging), @"mvc.1.0.view", @"/Pages/Shared/_Pagging.cshtml")]
namespace _09.Album.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\_ViewImports.cshtml"
using _09.Album;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318c57b409255143a750a2864fdeaf8f53c56a9b", @"/Pages/Shared/_Pagging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7680a5d2b7654b756981644844a75f01605f7b62", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Pagging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
  
    int currentPage = Model.currentPage;
    int countPages = Model.countPages;
    var generateUrl = Model.generateUrl;
    if (currentPage > countPages) currentPage = countPages;
    if (countPages < 1) return;
    int? preview = null;
    int? next = null;
    if (currentPage > 1) preview = currentPage - 1;
    if (currentPage < countPages) next = currentPage + 1;
    // Các trang hiện thị trong điều hướng
    List<int> pagesRanges = new List<int>();
    int delta = 5;             // Số trang mở rộng về mỗi bên trang hiện tại
    int remain = delta * 2;      // Số trang hai bên trang hiện tại
    pagesRanges.Add(currentPage);
    // Các trang phát triển về hai bên trang hiện tại
    for (int i = 1; i <= delta; i++)
    {
        if (currentPage + i <= countPages)
        {
            pagesRanges.Add(currentPage + i);
            remain--;
        }

        if (currentPage - i >= 1)
        {
            pagesRanges.Insert(0, currentPage - i);
            remain--;
        }

    }
    // Xử lý thêm vào các trang cho đủ remain (xảy ra ở đầu mút của khoảng trang không đủ
    // trang chèn  vào)
    if (remain > 0)
    {
        if (pagesRanges[0] == 1)
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.Last() + 1 <= countPages)
                {
                    pagesRanges.Add(pagesRanges.Last() + 1);
                }
            }
        }
        else
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.First() - 1 > 1)
                {
                    pagesRanges.Insert(0, pagesRanges.First() - 1);
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n        <!-- Previous page link -->\r\n");
#nullable restore
#line 60 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
         if (preview != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1944, "\"", 1972, 1);
#nullable restore
#line 63 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
WriteAttributeValue("", 1951, generateUrl(preview), 1951, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang trước</a>\r\n            </li>\r\n");
#nullable restore
#line 65 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang trước</a>\r\n            </li>\r\n");
#nullable restore
#line 71 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- Numbered page links -->\r\n");
#nullable restore
#line 74 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
         foreach (var pageitem in pagesRanges)
        {
            if (pageitem != currentPage)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2455, "\"", 2484, 1);
#nullable restore
#line 79 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
WriteAttributeValue("", 2462, generateUrl(pageitem), 2462, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 80 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
                   Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 83 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\" aria-current=\"page\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 87 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
                                             Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 89 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <!-- Next page link -->\r\n");
#nullable restore
#line 94 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
         if (next != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2988, "\"", 3013, 1);
#nullable restore
#line 97 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
WriteAttributeValue("", 2995, generateUrl(next), 2995, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang sau</a>\r\n            </li>\r\n");
#nullable restore
#line 99 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang sau</a>\r\n            </li>\r\n");
#nullable restore
#line 105 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\Shared\_Pagging.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591