#pragma checksum "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b913b2608eaea56840ca4c37144f1bca117c298f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StockInfo), @"mvc.1.0.view", @"/Views/Home/StockInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StockInfo.cshtml", typeof(AspNetCore.Views_Home_StockInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b913b2608eaea56840ca4c37144f1bca117c298f", @"/Views/Home/StockInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e064a95c920ecbb361bad2442735e5ca9291d04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StockInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml"
  
    ViewBag.Title = "StocksUsed";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 461, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

<h1>Our Advanced Algorithims To Buy and Sell These Stocks</h1>

<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">Symbol</th>
            <th scope=""col"">Name</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml"
         foreach (var stock in ViewBag.Records)
        {

#line default
#line hidden
            BeginContext(610, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(649, 12, false);
#line 20 "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml"
               Write(stock.Symbol);

#line default
#line hidden
            EndContext();
            BeginContext(661, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(689, 10, false);
#line 21 "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml"
               Write(stock.Name);

#line default
#line hidden
            EndContext();
            BeginContext(699, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 23 "E:\AdvancedAsp\StockApp\Views\Home\StockInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(736, 29, true);
            WriteLiteral("     \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
