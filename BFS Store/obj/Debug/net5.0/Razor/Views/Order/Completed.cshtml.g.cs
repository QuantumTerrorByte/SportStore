#pragma checksum "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd25f7148353b66d09570b746f730fd9376a7179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Completed), @"mvc.1.0.view", @"/Views/Order/Completed.cshtml")]
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
#nullable restore
#line 1 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
using DAO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd25f7148353b66d09570b746f730fd9376a7179", @"/Views/Order/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Completed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DAO.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
 foreach (Order order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Id: ");
#nullable restore
#line 6 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>FirstName: ");
#nullable restore
#line 7 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
               Write(order.Costumer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>SecondName: ");
#nullable restore
#line 8 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
                Write(order.Costumer.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Email: ");
#nullable restore
#line 9 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
           Write(order.Costumer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>Phone: ");
#nullable restore
#line 10 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
           Write(order.Costumer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>\r\n        Cart:\r\n");
#nullable restore
#line 13 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
         foreach (var lines in @order.Cart.CartLines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 15 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
            Write(lines.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 15 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
                                Write(lines.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 18 "D:\Projects\BFS Store main\BFS Store\Views\Order\Completed.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("Thx for order O_O");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DAO.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
