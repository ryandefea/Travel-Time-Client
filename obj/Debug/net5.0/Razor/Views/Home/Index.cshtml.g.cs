#pragma checksum "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e1c07a0b0546f2af601ce36c91f47c760a104c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\_ViewImports.cshtml"
using TravelClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e1c07a0b0546f2af601ce36c91f47c760a104c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881156204694621735159ac2183c5559087d93d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelClient.Models.Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
   
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>All Destinations:</h1>\r\n\r\n<ol>\r\n");
#nullable restore
#line 11 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
 foreach (Destination destination in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>ID: ");
#nullable restore
#line 14 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
           Write(destination.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Name: ");
#nullable restore
#line 15 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
             Write(destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Species: ");
#nullable restore
#line 16 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
                Write(destination.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Age: ");
#nullable restore
#line 17 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
            Write(destination.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Rating: ");
#nullable restore
#line 18 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
               Write(destination.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <br>\r\n");
#nullable restore
#line 21 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol> \r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelClient.Models.Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
