#pragma checksum "F:\AdvancedAsp\lab4\Lab2Phase1\Views\Home\Languages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd9163dd38103237d71d8324d28d170e6e14ec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Languages), @"mvc.1.0.view", @"/Views/Home/Languages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Languages.cshtml", typeof(AspNetCore.Views_Home_Languages))]
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
#line 1 "F:\AdvancedAsp\lab4\Lab2Phase1\Views\_ViewImports.cshtml"
using Lab2Phase1;

#line default
#line hidden
#line 2 "F:\AdvancedAsp\lab4\Lab2Phase1\Views\_ViewImports.cshtml"
using Lab2Phase1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd9163dd38103237d71d8324d28d170e6e14ec3", @"/Views/Home/Languages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006d63b88dc2f10cb06c6d792c7d60c9747a8e69", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Languages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab2Phase1.ViewModels.Home.ShowLanguagesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 90, true);
            WriteLiteral("\r\n<h2>Available Langugages</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-xs-6\">\r\n        ");
            EndContext();
            BeginContext(149, 40, false);
#line 7 "F:\AdvancedAsp\lab4\Lab2Phase1\Views\Home\Languages.cshtml"
   Write(Html.ListBox("lang", Model.CulturesList));

#line default
#line hidden
            EndContext();
            BeginContext(189, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-xs-6\">\r\n        ");
            EndContext();
            BeginContext(240, 46, false);
#line 10 "F:\AdvancedAsp\lab4\Lab2Phase1\Views\Home\Languages.cshtml"
   Write(Html.DropDownList("lang2", Model.CulturesList));

#line default
#line hidden
            EndContext();
            BeginContext(286, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab2Phase1.ViewModels.Home.ShowLanguagesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
