#pragma checksum "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6166c073aeb2957166958d8e454895ece862c807"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrdersList), @"mvc.1.0.view", @"/Views/Order/OrdersList.cshtml")]
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
#line 1 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
using DAO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6166c073aeb2957166958d8e454895ece862c807", @"/Views/Order/OrdersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrdersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Linq.IOrderedQueryable<DAO.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkingDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
 foreach (Order order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"border: solid 2px rebeccapurple; margin: 30px;padding: 20px\">\r\n        <div style=\"font-size: 15px\">\r\n            <div>Id: ");
#nullable restore
#line 7 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>FirstName: ");
#nullable restore
#line 8 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                       Write(order.Costumer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>SecondName: ");
#nullable restore
#line 9 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                        Write(order.Costumer.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Address: ");
#nullable restore
#line 10 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                     Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Email: ");
#nullable restore
#line 11 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                   Write(order.Costumer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Phone: ");
#nullable restore
#line 12 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                   Write(order.Costumer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n                Cart:\r\n");
#nullable restore
#line 15 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                 foreach (var lines in @order.CartLines)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>");
#nullable restore
#line 17 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                    Write(lines.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 17 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                                        Write(lines.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div>\r\n");
#nullable restore
#line 23 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
             if (order.IsDone)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>Is done: ");
#nullable restore
#line 25 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                         Write(order.IsDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>Is done: ");
#nullable restore
#line 29 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                         Write(order.IsDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6166c073aeb2957166958d8e454895ece862c8077981", async() => {
                WriteLiteral("Done");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
                                                                          WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "D:\Projects\BFS Store main\BFS Store\Views\Order\OrdersList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Linq.IOrderedQueryable<DAO.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
