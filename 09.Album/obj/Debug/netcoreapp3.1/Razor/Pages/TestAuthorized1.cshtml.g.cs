#pragma checksum "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\TestAuthorized1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e45ee603dba8b4dcd9865d4006a8bb64d469f85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_09.Album.Pages.Pages_TestAuthorized1), @"mvc.1.0.razor-page", @"/Pages/TestAuthorized1.cshtml")]
namespace _09.Album.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e45ee603dba8b4dcd9865d4006a8bb64d469f85", @"/Pages/TestAuthorized1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7680a5d2b7654b756981644844a75f01605f7b62", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TestAuthorized1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p class=\"alert alert-danger\">");
#nullable restore
#line 6 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\09.Album\Pages\TestAuthorized1.cshtml"
                         Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  Bạn đang truy cập TestAuthorize1</p>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.UserManager<Album.Models.AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_09.Album.Pages.TestAuthorized1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_09.Album.Pages.TestAuthorized1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_09.Album.Pages.TestAuthorized1Model>)PageContext?.ViewData;
        public _09.Album.Pages.TestAuthorized1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
