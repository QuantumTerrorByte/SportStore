#pragma checksum "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76359308e3156d468231c8344b5583eccb74e525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUsersRoles_Index), @"mvc.1.0.view", @"/Views/AdminUsersRoles/Index.cshtml")]
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
#line 1 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\_ViewImports.cshtml"
using Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\_ViewImports.cshtml"
using Auth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76359308e3156d468231c8344b5583eccb74e525", @"/Views/AdminUsersRoles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdff605acbcb8bcc0069ae35dde61334b188279d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUsersRoles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNetUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminUsersRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";
    UserManager<AspNetUser> manager = ViewBag.Manager;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <table class=""table table-striped table-bordered table-sm table"">
        <tr>
            <th class=""text-center"">Name</th>
            <th class=""text-center"">Email</th>
            <th class=""text-center"">Roles</th>
            <th class=""text-center"">Actions</th>
        </tr>
");
#nullable restore
#line 20 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
         foreach (var appUser in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76359308e3156d468231c8344b5583eccb74e5255428", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"userEmail\"");
                BeginWriteAttribute("value", " value=\"", 678, "\"", 700, 1);
#nullable restore
#line 23 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
WriteAttributeValue("", 686, appUser.Email, 686, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 25 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                   Write(appUser.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                   Write(appUser.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <th>\r\n                        <select");
                BeginWriteAttribute("name", " name=\"", 876, "\"", 883, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 29 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                             foreach (var role in await manager.GetRolesAsync(appUser))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76359308e3156d468231c8344b5583eccb74e5257302", async() => {
#nullable restore
#line 31 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                                                 Write(role);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                                   WriteLiteral(role);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                    </th>\r\n                    <th>\r\n                        <button type=\"submit\">Edit</button>\r\n                    </th>\r\n                </tr>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\Projects\BackUps\BFS Store failed try split auth\Auth\Views\AdminUsersRoles\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNetUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
