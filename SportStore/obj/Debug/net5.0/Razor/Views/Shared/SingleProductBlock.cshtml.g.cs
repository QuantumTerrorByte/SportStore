#pragma checksum "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ec4c342931cbc8345122467e49c719e6885e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SingleProductBlock), @"mvc.1.0.view", @"/Views/Shared/SingleProductBlock.cshtml")]
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
#nullable restore
#line 3 "D:\Last\sharp\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ec4c342931cbc8345122467e49c719e6885e2b", @"/Views/Shared/SingleProductBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3e9c6c6f28dec4a0cc7ab7d6e1ee4f654de9e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SingleProductBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-block\">\r\n    <div class=\"product-block-Left\">\r\n        <div class=\"product-img-holder\"></div>\r\n        <div class=\"product-category\">\r\n            Category:<br>\r\n            ");
#nullable restore
#line 8 "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml"
       Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"product-block-right\">\r\n        <div>\r\n            <div class=\"product-id\">Id: ");
#nullable restore
#line 13 "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"product-name\">Name: ");
#nullable restore
#line 14 "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"product-description\">");
#nullable restore
#line 16 "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"product-price\">Price is ");
#nullable restore
#line 17 "D:\Last\sharp\SportStore\SportStore\Views\Shared\SingleProductBlock.cshtml"
                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
