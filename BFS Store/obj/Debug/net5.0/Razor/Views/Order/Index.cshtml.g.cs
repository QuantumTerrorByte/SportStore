#pragma checksum "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee02e2502176978a201e4bdc068a0cd504e63aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
using SportStore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
using DAO.Migrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
using DAO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
using SportStore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee02e2502176978a201e4bdc068a0cd504e63aa", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAO.Models.DataTransferModel.OrderIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("order-block-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetApproved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::SportStore.Infrastructure.PageLinksTagHelper __SportStore_Infrastructure_PageLinksTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link rel=\"stylesheet\" href=\"/css/OrderAdmin.css\">\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
  
    int mainIndex = 0;
    int prodFormIndex = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
 foreach (var order in Model.Orders) //single order block
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee02e2502176978a201e4bdc068a0cd504e63aa8256", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
           ++mainIndex; 

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h2>Order id:");
#nullable restore
#line 22 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                Write(order.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <div class=\"order-block__products-holder\">\r\n");
#nullable restore
#line 24 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
             for (int i = 0; i < order.Cart.CartLines.Count; i++) //single product line in order block
            {
                var cartLine = order.Cart.CartLines[i];

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""product-line-block"">
                    <div class=""product-line-block__img"">
                    </div>
                    <div class=""product-line-block__lorem"">
                        Lorem ipsum.
                    </div>
                    <div class=""product-line-block__product-id"">
                        <h3>Id: ");
#nullable restore
#line 34 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                           Write(cartLine.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"product-line-block__product-name\">\r\n                        <h4>");
#nullable restore
#line 37 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                       Write(cartLine.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    </div>\r\n                    <div class=\"product-line-block__in-stock\">\r\n                        <h6>In stock: ");
#nullable restore
#line 40 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                                 Write(cartLine.Product.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1541, "\"", 1566, 3);
                WriteAttributeValue("", 1548, "pLines[", 1548, 7, true);
#nullable restore
#line 41 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 1555, i, 1555, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1557, "].orderId", 1557, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1567, "\"", 1594, 1);
#nullable restore
#line 41 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 1575, cartLine.ProductId, 1575, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>
                    <div class=""product-line-block__costumer-need"">
                        <label style=""display: flex; align-items: center"">
                            <h6>rder need: </h6>
                            <input class=""product-line-block__orderQuantityInput""
                                   type=""number""");
                BeginWriteAttribute("name", "\r\n                                   name=\"", 1953, "\"", 2013, 3);
                WriteAttributeValue("", 1996, "pLines[", 1996, 7, true);
#nullable restore
#line 48 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2003, i, 2003, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2005, "].Amount", 2005, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                   value=\"", 2014, "\"", 2074, 1);
#nullable restore
#line 49 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2058, cartLine.Amount, 2058, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        </label>\r\n                    </div>\r\n                    <div class=\"product-line-block__button-block\">\r\n                        <button type=\"submit\"");
                BeginWriteAttribute("form", " form=\"", 2254, "\"", 2283, 3);
#nullable restore
#line 53 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2261, i, 2261, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2263, "+form+", 2263, 6, true);
#nullable restore
#line 53 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2269, prodFormIndex, 2269, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\">Delete</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"buttons-holder\">\r\n        <button class=\" btn btn-primary btn-margins\" data-bs-toggle=\"collapse\"");
            BeginWriteAttribute("href", "\r\n                href=\"", 2533, "\"", 2584, 2);
            WriteAttributeValue("", 2557, "#collapseAddress-", 2557, 17, true);
#nullable restore
#line 61 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2574, mainIndex, 2574, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\"\r\n                aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2638, "\"", 2680, 2);
            WriteAttributeValue("", 2654, "collapseAddress-", 2654, 16, true);
#nullable restore
#line 62 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2670, mainIndex, 2670, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Shipment info\r\n        </button>\r\n        <button");
            BeginWriteAttribute("class", " class=\"", 2745, "\"", 2855, 1);
#nullable restore
#line 65 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 2753, string.IsNullOrEmpty(order.Comment) ? " btn btn-light btn-margins" : " btn btn-primary btn-margins", 2753, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                type=\"button\" data-bs-toggle=\"collapse\"\r\n                data-bs-target=\"#collapseComment-");
#nullable restore
#line 67 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                                            Write(mainIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", "\r\n                aria-controls=\"", 2997, "\"", 3056, 2);
            WriteAttributeValue("", 3030, "collapseComment-", 3030, 16, true);
#nullable restore
#line 68 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3046, mainIndex, 3046, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Comment\r\n        </button>\r\n        <button type=\"button\" class=\"btn btn-success\">Success</button>\r\n        <button class=\" btn btn-primary btn-margins\" data-bs-toggle=\"collapse\"");
            BeginWriteAttribute("href", "\r\n                href=\"", 3250, "\"", 3301, 2);
            WriteAttributeValue("", 3274, "#collapseOptions-", 3274, 17, true);
#nullable restore
#line 73 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3291, mainIndex, 3291, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\"\r\n                aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3355, "\"", 3397, 2);
            WriteAttributeValue("", 3371, "collapseOptions-", 3371, 16, true);
#nullable restore
#line 74 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3387, mainIndex, 3387, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Options\r\n        </button>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee02e2502176978a201e4bdc068a0cd504e63aa19293", async() => {
                WriteLiteral("Add product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee02e2502176978a201e4bdc068a0cd504e63aa20834", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 3676, "\"", 3693, 1);
#nullable restore
#line 79 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3684, order.Id, 3684, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 3746, "\"", 3801, 1);
#nullable restore
#line 80 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3754, ViewContext.HttpContext.Request.PathAndQuery(), 3754, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"btn btn-danger\">Delete order</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 3927, "\"", 3958, 2);
            WriteAttributeValue("", 3932, "collapseAddress-", 3932, 16, true);
#nullable restore
#line 85 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 3948, mainIndex, 3948, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <h3>Email: ");
#nullable restore
#line 87 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                  Write(order.Costumer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Phone: ");
#nullable restore
#line 88 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                  Write(order.Costumer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>FirstName: ");
#nullable restore
#line 89 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                      Write(order.Costumer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>SecondName: ");
#nullable restore
#line 90 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                       Write(order.Costumer.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Patronymic: ");
#nullable restore
#line 91 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                       Write(order.Costumer.Patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>PostalOffice: ");
#nullable restore
#line 92 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                         Write(order.Costumer.Address.PostalOffice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>City: ");
#nullable restore
#line 93 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                 Write(order.Costumer.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Street: ");
#nullable restore
#line 94 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                   Write(order.Costumer.Address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>House: ");
#nullable restore
#line 95 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                  Write(order.Costumer.Address.House);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h3>Apartment: ");
#nullable restore
#line 96 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
                      Write(order.Costumer.Address.Apartment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 4653, "\"", 4684, 2);
            WriteAttributeValue("", 4658, "collapseComment-", 4658, 16, true);
#nullable restore
#line 99 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 4674, mainIndex, 4674, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"card card-body\">\r\n            <h3>");
#nullable restore
#line 101 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
           Write(order.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 4816, "\"", 4847, 2);
            WriteAttributeValue("", 4821, "collapseOptions-", 4821, 16, true);
#nullable restore
#line 104 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 4837, mainIndex, 4837, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""card card-body"">
            <button type=""button"" class=""btn btn-dark"">Add product</button>
            <button type=""button"" class=""btn btn-success"">Save order</button>
            <button type=""button"" form=""deleteOrder"" class=""btn btn-danger"">Delete order</button>
        </div>
    </div>
");
#nullable restore
#line 111 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
     for (int j = 0; j < order.Cart.CartLines.Count; j++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee02e2502176978a201e4bdc068a0cd504e63aa28605", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 5395, "\"", 5438, 1);
#nullable restore
#line 114 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 5403, order.Cart.CartLines[j].Product.Id, 5403, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 5489, "\"", 5506, 1);
#nullable restore
#line 115 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 5497, order.Id, 5497, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 5559, "\"", 5614, 1);
#nullable restore
#line 116 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
WriteAttributeValue("", 5567, ViewContext.HttpContext.Request.PathAndQuery(), 5567, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 113 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 5256, j, 5256, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5258, "+form+", 5258, 6, true);
#nullable restore
#line 113 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 5264, prodFormIndex, 5264, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 118 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
     
    {prodFormIndex += order.Cart.CartLines.Count;}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ee02e2502176978a201e4bdc068a0cd504e63aa32823", async() => {
            }
            );
            __SportStore_Infrastructure_PageLinksTagHelper = CreateTagHelper<global::SportStore.Infrastructure.PageLinksTagHelper>();
            __tagHelperExecutionContext.Add(__SportStore_Infrastructure_PageLinksTagHelper);
#nullable restore
#line 121 "D:\Projects\BFS Store main\BFS Store\Views\Order\Index.cshtml"
__SportStore_Infrastructure_PageLinksTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __SportStore_Infrastructure_PageLinksTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __SportStore_Infrastructure_PageLinksTagHelper.PageAction = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAO.Models.DataTransferModel.OrderIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
