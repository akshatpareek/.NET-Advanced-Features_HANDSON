#pragma checksum "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38cb6e09d46e861c07faf4a0200ed47a8b87cd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ITOrganizations), @"mvc.1.0.view", @"/Views/Home/ITOrganizations.cshtml")]
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
#line 1 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\_ViewImports.cshtml"
using Handson_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\_ViewImports.cshtml"
using Handson_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38cb6e09d46e861c07faf4a0200ed47a8b87cd6e", @"/Views/Home/ITOrganizations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d64a82dfd3d536c167f0eaef6fc8c719a776a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ITOrganizations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
  
    ViewBag.Title = "Organisations";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
 foreach (var item in ViewBag.Oranisation)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <ul>\r\n            <li>\r\n");
#nullable restore
#line 12 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
                 if (item == "Amazon")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <b> ");
#nullable restore
#line 14 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n");
#nullable restore
#line 15 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n\r\n            </ul>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Tarun\Desktop\Cogni\Training\Core\Handson_Core\Views\Home\ITOrganizations.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
