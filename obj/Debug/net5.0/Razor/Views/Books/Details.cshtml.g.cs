#pragma checksum "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26fa09255ccf619a443bb78b579b76028183aede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\_ViewImports.cshtml"
using LibraryApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\_ViewImports.cshtml"
using LibraryApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fa09255ccf619a443bb78b579b76028183aede", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9bdf1d125f678c601b2c2246e2b4f49f85bf8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryApi.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Details</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Author
            </th>
            <th>
                Release Date
            </th>
            <th>
                Count
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                ");
#nullable restore
#line 29 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml"
           Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml"
           Write(Model.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\Details.cshtml"
           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryApi.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
