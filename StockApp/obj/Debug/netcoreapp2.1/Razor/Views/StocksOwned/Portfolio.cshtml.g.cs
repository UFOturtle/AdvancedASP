#pragma checksum "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f15da26fb351437b419464f036d0cd895dfe89d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StocksOwned_Portfolio), @"mvc.1.0.view", @"/Views/StocksOwned/Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StocksOwned/Portfolio.cshtml", typeof(AspNetCore.Views_StocksOwned_Portfolio))]
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
#line 1 "E:\AdvancedAsp\StockApp\Views\_ViewImports.cshtml"
using StockApp;

#line default
#line hidden
#line 2 "E:\AdvancedAsp\StockApp\Views\_ViewImports.cshtml"
using StockApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f15da26fb351437b419464f036d0cd895dfe89d", @"/Views/StocksOwned/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e064a95c920ecbb361bad2442735e5ca9291d04", @"/Views/_ViewImports.cshtml")]
    public class Views_StocksOwned_Portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StockApp.Models.StockOwned>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 4, true);
            WriteLiteral("  \r\n");
            EndContext();
#line 3 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
    
    ViewData["Title"] = "Index";  

#line default
#line hidden
            BeginContext(101, 45, true);
            WriteLiteral("  \r\n<strong>Index</strong>  \r\n  \r\n<p>  \r\n    ");
            EndContext();
            BeginContext(146, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee89e47c12424ee1b72d93f2da779996", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(183, 104, true);
            WriteLiteral("  \r\n</p>  \r\n<table class=\"table\">  \r\n    <thead>  \r\n        <tr>  \r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(288, 44, false);
#line 16 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock_ID));

#line default
#line hidden
            EndContext();
            BeginContext(332, 61, true);
            WriteLiteral("  \r\n            </th>  \r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(394, 40, false);
#line 19 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(434, 61, true);
            WriteLiteral("  \r\n            </th>  \r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(496, 42, false);
#line 22 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.userID));

#line default
#line hidden
            EndContext();
            BeginContext(538, 61, true);
            WriteLiteral("  \r\n            </th>  \r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(600, 53, false);
#line 25 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.initialInvestment));

#line default
#line hidden
            EndContext();
            BeginContext(653, 59, true);
            WriteLiteral("  \r\n            </th>\r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(713, 48, false);
#line 28 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentValue));

#line default
#line hidden
            EndContext();
            BeginContext(761, 59, true);
            WriteLiteral("  \r\n            </th>\r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(821, 47, false);
#line 31 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.numOfStocks));

#line default
#line hidden
            EndContext();
            BeginContext(868, 60, true);
            WriteLiteral("  \r\n            </th> \r\n            <th>  \r\n                ");
            EndContext();
            BeginContext(929, 46, false);
#line 34 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayNameFor(model => model.dateBought));

#line default
#line hidden
            EndContext();
            BeginContext(975, 100, true);
            WriteLiteral("  \r\n            </th>    \r\n            <th></th>  \r\n        </tr>  \r\n    </thead>  \r\n    <tbody>  \r\n");
            EndContext();
#line 40 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
 foreach (var item in Model) {  

#line default
#line hidden
            BeginContext(1109, 52, true);
            WriteLiteral("        <tr>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1162, 43, false);
#line 43 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock_ID));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1267, 39, false);
#line 46 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1368, 41, false);
#line 49 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.userID));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1471, 52, false);
#line 52 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.initialInvestment));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1585, 47, false);
#line 55 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentValue));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1694, 46, false);
#line 58 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.numOfStocks));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1802, 45, false);
#line 61 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.DisplayFor(modelItem => item.dateBought));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 61, true);
            WriteLiteral("  \r\n            </td>  \r\n            <td>  \r\n                ");
            EndContext();
            BeginContext(1909, 59, false);
#line 64 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Stock_ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1968, 22, true);
            WriteLiteral(" |  \r\n                ");
            EndContext();
            BeginContext(1991, 136, false);
#line 65 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
           Write(Html.ActionLink("Delete", "DeleteStockOwned", new { id = item.Stock_ID }, new { onclick = "return confirm('Are you sure to delete?')" }));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 42, true);
            WriteLiteral("  \r\n            </td>  \r\n        </tr>  \r\n");
            EndContext();
#line 68 "E:\AdvancedAsp\StockApp\Views\StocksOwned\Portfolio.cshtml"
}  

#line default
#line hidden
            BeginContext(2174, 26, true);
            WriteLiteral("    </tbody>  \r\n</table>  ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StockApp.Models.StockOwned>> Html { get; private set; }
    }
}
#pragma warning restore 1591
