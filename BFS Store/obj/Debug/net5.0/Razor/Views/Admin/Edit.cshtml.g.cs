#pragma checksum "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8291a5a91fdd5087d1ca0821eadb71f17bf6a287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Edit), @"mvc.1.0.view", @"/Views/Admin/Edit.cshtml")]
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
#line 1 "D:\Projects\BFS Store\BFS Store\Views\_ViewImports.cshtml"
using SportStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BFS Store\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BFS Store\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
using SportStore.Models.ProductModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8291a5a91fdd5087d1ca0821eadb71f17bf6a287", @"/Views/Admin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportStore.Models.ProductModel.Product[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8291a5a91fdd5087d1ca0821eadb71f17bf6a2874785", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 8 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8291a5a91fdd5087d1ca0821eadb71f17bf6a2876282", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
     for (int i = 0; i < Model.Length; i++)
    {
        string target = $"Products[{i}].";
        Product temp = Model[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"product-block\">\r\n            <div class=\"product-block-right\">\r\n                <div>\r\n                    <div class=\"product-id\">Id: ");
#nullable restore
#line 18 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
                                           Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <input class=\"hiddenInput\" type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 601, "\"", 623, 3);
                WriteAttributeValue("", 608, "Products[", 608, 9, true);
#nullable restore
#line 19 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 617, i, 617, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 619, "].Id", 619, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 624, "\"", 644, 1);
#nullable restore
#line 19 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 632, Model[i].Id, 632, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <div class=\"product-name\">\r\n                        Name: <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 753, "\"", 777, 3);
                WriteAttributeValue("", 760, "Products[", 760, 9, true);
#nullable restore
#line 21 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 769, i, 769, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 771, "].Name", 771, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 778, "\"", 800, 1);
#nullable restore
#line 21 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 786, Model[i].Name, 786, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"product-description\">\r\n                    <div style=\"position:relative;z-index:3;background: black;\">\r\n                        <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 1040, "\"", 1071, 3);
                WriteAttributeValue("", 1047, "Products[", 1047, 9, true);
#nullable restore
#line 26 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1056, i, 1056, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1058, "].Description", 1058, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1072, "\"", 1128, 1);
#nullable restore
#line 26 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1080, Model[i].ProductInfos[0].ShortDescription.Value, 1080, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"product-price\">Price is <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 1263, "\"", 1288, 3);
                WriteAttributeValue("", 1270, "Products[", 1270, 9, true);
#nullable restore
#line 29 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1279, i, 1279, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1281, "].Price", 1281, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1289, "\"", 1315, 1);
#nullable restore
#line 29 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1297, Model[i].PriceUSD, 1297, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/></div>
            </div>
            <div class=""product-block-Left"">
                <div class=""product-img-holder""></div>
                <div class=""product-category"">
                    Category:<br>
                    <input class=""hiddenInput""");
                BeginWriteAttribute("name", " name=\"", 1577, "\"", 1605, 3);
                WriteAttributeValue("", 1584, "Products[", 1584, 9, true);
#nullable restore
#line 35 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1593, i, 1593, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1595, "].Category", 1595, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1606, "\"", 1643, 1);
#nullable restore
#line 35 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
WriteAttributeValue("", 1614, Model[i].NavCategoryFirstLvl, 1614, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "D:\Projects\BFS Store\BFS Store\Views\Admin\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <bottun type=\"submit\">Submit</bottun>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"/lib/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n<script src=\"/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportStore.Models.ProductModel.Product[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
