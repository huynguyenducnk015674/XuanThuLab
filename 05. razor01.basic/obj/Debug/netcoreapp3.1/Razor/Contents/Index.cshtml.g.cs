#pragma checksum "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\05. razor01.basic\Contents\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "361d08a8e38d864f0b5184563fb5d048f30c5779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Contents_Index), @"mvc.1.0.razor-page", @"/Contents/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{name?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361d08a8e38d864f0b5184563fb5d048f30c5779", @"/Contents/Index.cshtml")]
    public class Contents_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\05. razor01.basic\Contents\Index.cshtml"
  
    string name = this.Request.RouteValues["name"] as string;
    ViewData["Title"] = name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "D:\04. NGUYEN DUC HUY\05. SOURCE CODE\LEARNING CODE\ASP NET CORE\03. Project Learning\XuanThuLab\05. razor01.basic\Contents\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_05._razor01.basic.Contents.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_05._razor01.basic.Contents.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<_05._razor01.basic.Contents.IndexModel>)PageContext?.ViewData;
        public _05._razor01.basic.Contents.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
