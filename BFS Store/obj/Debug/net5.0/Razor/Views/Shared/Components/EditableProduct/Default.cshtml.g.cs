#pragma checksum "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EditableProduct_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EditableProduct/Default.cshtml")]
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
#line 1 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
using SportStore.Models.ProductModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f5", @"/Views/Shared/Components/EditableProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f10aea2aaa12c37e552d5f504213ded5667fd2e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EditableProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportStore.Components.EditableProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Lang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/css/EditableProductBlock.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f56077", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 6 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
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
            WriteLiteral(@"
<table class=""table table-striped table-bordered table-sm table"">
    <tr>
        <th class=""text-center"">ID</th>
        <th class=""text-center"">Name</th>
        <th class=""text-center"">Amount</th>
        <th class=""text-center"">Price</th>
        <th class=""text-center"">BrandUsd</th>
        <th class=""text-center"">Category1</th>
        <th class=""text-center"">Category2</th>
        <th class=""text-center"">Actions</th>
    </tr>
    <tr>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f58086", async() => {
                WriteLiteral("\r\n            <td>\r\n                <input name=\"Product.Id\" type=\"text\" placeholder=\"id\"");
                BeginWriteAttribute("value", " value=\"", 815, "\"", 823, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <input name=\"Product.Name\" type=\"text\" placeholder=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 937, "\"", 945, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <input name=\"Product.Amount\" type=\"text\" placeholder=\"Amount\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1071, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <input name=\"Product.Price\" type=\"text\" placeholder=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 1187, "\"", 1195, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <input name=\"Product.Brand\" type=\"text\" placeholder=\"Brand\"");
                BeginWriteAttribute("value", " value=\"", 1311, "\"", 1319, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <select name=\"Product.NavCategoryFirstLvlId\">\r\n");
#nullable restore
#line 37 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                     foreach (var modelCategory in Model.CategoriesLvl1) //todo by id
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f510163", async() => {
#nullable restore
#line 39 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                     Write(modelCategory.ValueEn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                           WriteLiteral(modelCategory.Id);

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
#line 40 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </td>\r\n            <td>\r\n                <select name=\"Product.NavCategorySecondLvlId\">\r\n");
#nullable restore
#line 45 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                     foreach (var modelCategory in Model.CategoriesLvl2) //todo by id
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f512772", async() => {
#nullable restore
#line 47 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                     Write(modelCategory.ValueEn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                           WriteLiteral(modelCategory.Id);

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
#line 48 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </td>\r\n            <td class=\"text-center tablePadding\">\r\n                <button type=\"submit\" class=\"btn btn-sm btn-warning\">Create</button>\r\n            </td>\r\n        ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </tr>\r\n\r\n");
#nullable restore
#line 57 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
     foreach (Product product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f516790", async() => {
                WriteLiteral("\r\n            <tr>\r\n                <td>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 2423, "\"", 2430, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2431, "\"", 2450, 1);
#nullable restore
#line 62 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
WriteAttributeValue("", 2439, product.Id, 2439, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2537, "\"", 2558, 1);
#nullable restore
#line 65 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
WriteAttributeValue("", 2545, product.Name, 2545, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2645, "\"", 2668, 1);
#nullable restore
#line 68 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
WriteAttributeValue("", 2653, product.Amount, 2653, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2755, "\"", 2780, 1);
#nullable restore
#line 71 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
WriteAttributeValue("", 2763, product.PriceUsd, 2763, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2867, "\"", 2889, 1);
#nullable restore
#line 74 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
WriteAttributeValue("", 2875, product.Brand, 2875, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <select name=\"Product.NavCategoryFirstLvlId\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f519705", async() => {
#nullable restore
#line 78 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                                   Write(product.NavCategoryFirstLvl.ValueEn);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n");
#nullable restore
#line 79 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                              
                                Console.WriteLine(product.NavCategoryFirstLvl.ValueEn);
                            

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                           WriteLiteral(product.NavCategoryFirstLvl.Id);

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
#line 83 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                         foreach (var modelCategory in Model.CategoriesLvl1) //todo by id
                        {
                            if (product.NavCategoryFirstLvl.Id != modelCategory.Id)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f522549", async() => {
#nullable restore
#line 87 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                             Write(modelCategory.ValueEn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                   WriteLiteral(modelCategory.Id);

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
#line 88 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </td>\r\n                <td>\r\n                    <select name=\"Product.NavCategorySecondLvlId\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f524912", async() => {
#nullable restore
#line 94 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                                    Write(product.NavCategorySecondLvl.ValueEn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                           WriteLiteral(product.NavCategorySecondLvl.Id);

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
#line 95 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                         foreach (var modelCategory in Model.CategoriesLvl2) //todo by id
                        {
                            if (product.NavCategorySecondLvl.Id != modelCategory.Id)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f527335", async() => {
#nullable restore
#line 99 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                             Write(modelCategory.ValueEn);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                   WriteLiteral(modelCategory.Id);

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
#line 100 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </td>
                <td class=""text-center tablePadding"">
                    <div class=""btn btn-danger btn-sm"">More</div>
                </td>

            </tr>
            <tr class=""action-panel text-center"">
                <td class=""action-panel-column"">
                    <button type=""submit"" class=""btn btn-sm btn-warning"">Save</button>
                </td>
                <td>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f530008", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
                                                                    WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"info-edit-holder\">\r\n                        <select>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f532764", async() => {
                    WriteLiteral("ru");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f534012", async() => {
                    WriteLiteral("en");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d3f4e09ca1d7ebb44b5a5e2d64deced7f0a5f535260", async() => {
                    WriteLiteral("uk");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                        <button class=\"btn btn-sm btn-warning\">Edit info</button>\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5469, "\"", 5476, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger btn-sm\">Add in isolation</a>\r\n                </td>\r\n            </tr>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
#line 131 "D:\Projects\BFS Store\BFS Store\Views\Shared\Components\EditableProduct\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportStore.Components.EditableProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
