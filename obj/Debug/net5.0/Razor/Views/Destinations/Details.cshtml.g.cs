#pragma checksum "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e60308d4dcdad8a08d89602524fd2814273fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinations_Details), @"mvc.1.0.view", @"/Views/Destinations/Details.cshtml")]
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
#line 2 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\_ViewImports.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e60308d4dcdad8a08d89602524fd2814273fa8", @"/Views/Destinations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881156204694621735159ac2183c5559087d93d3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destinations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Destination Info:</h1>\r\n<ul>\r\n    <li>ID: ");
#nullable restore
#line 7 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
       Write(Model.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>City: ");
#nullable restore
#line 8 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
         Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Country: ");
#nullable restore
#line 9 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
            Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Review: ");
#nullable restore
#line 10 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
           Write(Model.Review);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Rating: ");
#nullable restore
#line 11 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
           Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n<br>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 277, "\"", 325, 2);
            WriteAttributeValue("", 284, "/Destinations/Edit/", 284, 19, true);
#nullable restore
#line 15 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
WriteAttributeValue("", 303, Model.DestinationId, 303, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p>Edit</p></a>\r\n<br>\r\n\r\n<a href=\"/Destinations\"><p>Return</p></a>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 399, "\"", 449, 2);
            WriteAttributeValue("", 406, "/Destinations/Delete/", 406, 21, true);
#nullable restore
#line 20 "C:\Users\Ryan\Desktop\TravelClient.Solution\TravelClient\Views\Destinations\Details.cshtml"
WriteAttributeValue("", 427, Model.DestinationId, 427, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p>DELETE Destination</p></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591