#pragma checksum "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279dcc4c52d156a21df146c334b9c2a1b46fe11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProduct_Edit), @"mvc.1.0.view", @"/Views/AdminProduct/Edit.cshtml")]
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
#line 1 "D:\Projects\SportStore\BFS Store\Views\_ViewImports.cshtml"
using SportStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\SportStore\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\SportStore\BFS Store\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279dcc4c52d156a21df146c334b9c2a1b46fe11a", @"/Views/AdminProduct/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProduct_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAO.Models.ProductModel.Product[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "279dcc4c52d156a21df146c334b9c2a1b46fe11a4652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 7 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "279dcc4c52d156a21df146c334b9c2a1b46fe11a6157", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
     for (int i = 0; i < Model.Length; i++)
    {
        string target = $"Products[{i}].";
        var temp = Model[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"product-block\">\r\n            <div class=\"product-block-right\">\r\n                <div>\r\n                    <div class=\"product-id\">Id: ");
#nullable restore
#line 17 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
                                           Write(Model[i].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <input class=\"hiddenInput\" type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 553, "\"", 575, 3);
                WriteAttributeValue("", 560, "Products[", 560, 9, true);
#nullable restore
#line 18 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 569, i, 569, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 571, "].Id", 571, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 576, "\"", 596, 1);
#nullable restore
#line 18 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 584, Model[i].Id, 584, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    <div class=\"product-name\">\r\n                        Name: <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 705, "\"", 729, 3);
                WriteAttributeValue("", 712, "Products[", 712, 9, true);
#nullable restore
#line 20 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 721, i, 721, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 723, "].Name", 723, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 730, "\"", 752, 1);
#nullable restore
#line 20 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 738, Model[i].Name, 738, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"product-description\">\r\n                    <div style=\"position:relative;z-index:3;background: black;\">\r\n                        <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 992, "\"", 1023, 3);
                WriteAttributeValue("", 999, "Products[", 999, 9, true);
#nullable restore
#line 25 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1008, i, 1008, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1010, "].Description", 1010, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1024, "\"", 1080, 1);
#nullable restore
#line 25 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1032, Model[i].ProductInfos[0].ShortDescription.Value, 1032, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n                <div class=\"product-price\">Price is <input class=\"hiddenInput\"");
                BeginWriteAttribute("name", " name=\"", 1215, "\"", 1240, 3);
                WriteAttributeValue("", 1222, "Products[", 1222, 9, true);
#nullable restore
#line 28 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1231, i, 1231, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1233, "].Price", 1233, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1241, "\"", 1267, 1);
#nullable restore
#line 28 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1249, Model[i].PriceUsd, 1249, 18, false);

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
                BeginWriteAttribute("name", " name=\"", 1529, "\"", 1557, 3);
                WriteAttributeValue("", 1536, "Products[", 1536, 9, true);
#nullable restore
#line 34 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1545, i, 1545, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1547, "].Category", 1547, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1558, "\"", 1595, 1);
#nullable restore
#line 34 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
WriteAttributeValue("", 1566, Model[i].NavCategoryFirstLvl, 1566, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "D:\Projects\SportStore\BFS Store\Views\AdminProduct\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAO.Models.ProductModel.Product[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
