#pragma checksum "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd662557335139fe53abf69c526fea53c133bf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOfrawmaterials_Index), @"mvc.1.0.view", @"/Views/PurchaseOfrawmaterials/Index.cshtml")]
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
#line 1 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\_ViewImports.cshtml"
using Enterprises_manufacturing_goods;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\_ViewImports.cshtml"
using Enterprises_manufacturing_goods.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd662557335139fe53abf69c526fea53c133bf4", @"/Views/PurchaseOfrawmaterials/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2707e6c6d16808444c382aecc4015d88140ae9d2", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOfrawmaterials_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Enterprises_manufacturing_goods.PurchaseOfrawmaterials>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
  
    ViewData["Title"] = "Закупка";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    a {
        text-decoration: none;
        color: green;
    }

    h1 {
        font-weight: bold;
        font-family: 'Times New Roman', Times, serif;
    }
</style>
<div class=""text-center"">
    <h1 class=""display-4"">Предприятия по производству кондитерских изделий</h1>
</div>
<br />
<h1>");
#nullable restore
#line 22 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Закупка сырья</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd662557335139fe53abf69c526fea53c133bf45361", async() => {
                WriteLiteral("Добавить новую запись");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CountPur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Employee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RawMaterials));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CountPur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeNavigation.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RawMaterialsNavigation.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd662557335139fe53abf69c526fea53c133bf411200", async() => {
                WriteLiteral("Обновить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bd662557335139fe53abf69c526fea53c133bf413464", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\zenis\Рабочий стол\3-курс\6-сем\СУБД\Рабочая копия\Enterprises_manufacturing_goods\Enterprises_manufacturing_goods\Views\PurchaseOfrawmaterials\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Enterprises_manufacturing_goods.PurchaseOfrawmaterials>> Html { get; private set; }
    }
}
#pragma warning restore 1591
