#pragma checksum "D:\Last\sharp\SportStore\SportStore\Views\Shared\_LeftNavBarLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf98535152cb0622967bd89d806146d8766f3c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LeftNavBarLayout), @"mvc.1.0.view", @"/Views/Shared/_LeftNavBarLayout.cshtml")]
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
#nullable restore
#line 1 "D:\Last\sharp\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Last\sharp\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf98535152cb0622967bd89d806146d8766f3c4", @"/Views/Shared/_LeftNavBarLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a42bdf20d4eedfbac7a0258d0ed0f0fb63967b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LeftNavBarLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Last\sharp\SportStore\SportStore\Views\Shared\_LeftNavBarLayout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""/css/MainLayout.css"">
<div class=""leftBar"">
    <div class=""leftBarButton"">First</div>
    <div class=""leftBarButton"">Second</div>
    <div class=""leftBarButton"">Third</div>
    <div class=""leftBarButton"">Fourth</div>
</div>
<div class=""contentBlock"">
    ");
#nullable restore
#line 12 "D:\Last\sharp\SportStore\SportStore\Views\Shared\_LeftNavBarLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
