#pragma checksum "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077dd5de26591ebb6a2cbf75f2245480cf6fb2a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_06.razor02.layout.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace _06.razor02.layout.Pages
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
#line 1 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\_ViewImports.cshtml"
using _06.razor02.layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\_ViewImports.cshtml"
using _06.razor02.layout.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/order/{productid:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"077dd5de26591ebb6a2cbf75f2245480cf6fb2a5", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e6c6dcf32420f8d361d5981a440d40abcab1e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var menus = new List<string> { "Menu01", "Menu02" };
    dynamic products = new
    {
        Name = "Sản phẩm ABC",
        Description = "Thông tin chi tiết...",
        Price = "1000"
    };
    // HttpContext.Response.Headers.Add("REFRESH", "5;/privacy");

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table-bordered\">\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 17 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
       Write(await Html.PartialAsync("CustomPartial/_LeftMenu", menus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>");
#nullable restore
#line 19 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
       Write(await Component.InvokeAsync("ViewProduct", products));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            ");
#nullable restore
#line 21 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
       Write(await Html.PartialAsync("CustomPartial/_RightMenu", menus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "077dd5de26591ebb6a2cbf75f2245480cf6fb2a55505", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"username\" placeholder=\"Nhập tên\" />\r\n    <input type=\"email\" name=\"email\" placeholder=\"Nhập email\" />\r\n    <button class=\"btn btn-danger\" type=\"submit\">Gửi</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"card bg-success\">\r\n    <div class=\"card-body text-white\">\r\n        <p>Dữ liệu trong Model:</p>\r\n        <ul>\r\n            <li>ProductID: ");
#nullable restore
#line 34 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                      Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>UserName: ");
#nullable restore
#line 35 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                     Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Email: ");
#nullable restore
#line 36 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Color: ");
#nullable restore
#line 37 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                  Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>desscription: ");
#nullable restore
#line 38 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                         Write(Model.product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>productID: ");
#nullable restore
#line 39 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Index.cshtml"
                      Write(Model.product.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
