#pragma checksum "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4021cbaa65443036981d55db534e6c7ad4320d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_06.razor02.layout.Pages.Shared.Components.MessagePage.Pages_Shared_Components_MessagePage_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
namespace _06.razor02.layout.Pages.Shared.Components.MessagePage
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4021cbaa65443036981d55db534e6c7ad4320d7", @"/Pages/Shared/Components/MessagePage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e6c6dcf32420f8d361d5981a440d40abcab1e3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_MessagePage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessagePage.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = @Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card m-4\">\r\n    <div class=\"card-header bg-danger text-light\">\r\n        <h4>");
#nullable restore
#line 9 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 12 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml"
   Write(Html.Raw(Model.htmlcontent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        Chuyển đến - <a");
            BeginWriteAttribute("href", " href=\"", 354, "\"", 379, 1);
#nullable restore
#line 15 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml"
WriteAttributeValue("", 361, Model.urlredirect, 361, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\06.razor02.layout\Pages\Shared\Components\MessagePage\Default.cshtml"
                                             Write(Model.urlredirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessagePage.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
