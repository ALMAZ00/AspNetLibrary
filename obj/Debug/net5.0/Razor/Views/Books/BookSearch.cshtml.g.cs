#pragma checksum "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a09744e8746fce1f043ef070980747b369ea1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_BookSearch), @"mvc.1.0.view", @"/Views/Books/BookSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a09744e8746fce1f043ef070980747b369ea1b", @"/Views/Books/BookSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9bdf1d125f678c601b2c2246e2b4f49f85bf8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_BookSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryApi.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
  
    ViewData["Title"] = "BookSearch";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>BookSearch</h1>

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
");
#nullable restore
#line 28 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
               Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
               Write(item.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Books\BookSearch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryApi.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591