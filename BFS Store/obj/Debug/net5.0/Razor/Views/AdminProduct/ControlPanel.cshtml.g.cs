#pragma checksum "D:\Projects\BFS Store main\BFS Store\Views\AdminProduct\ControlPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f7eafd74bd1fff3db6683ce11ebaf994807bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProduct_ControlPanel), @"mvc.1.0.view", @"/Views/AdminProduct/ControlPanel.cshtml")]
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
#line 1 "D:\Projects\BFS Store main\BFS Store\Views\_ViewImports.cshtml"
using SportStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BFS Store main\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BFS Store main\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f7eafd74bd1fff3db6683ce11ebaf994807bac", @"/Views/AdminProduct/ControlPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProduct_ControlPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAO.Models.ProductModel.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\BFS Store main\BFS Store\Views\AdminProduct\ControlPanel.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.min.css\">\r\n<div>\r\n    ");
#nullable restore
#line 7 "D:\Projects\BFS Store main\BFS Store\Views\AdminProduct\ControlPanel.cshtml"
Write(await Component.InvokeAsync("EditableProduct", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAO.Models.ProductModel.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
