#pragma checksum "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1a1cd09c763187310fa671f37960c32c24b694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Readers_ReaderSearch), @"mvc.1.0.view", @"/Views/Readers/ReaderSearch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1a1cd09c763187310fa671f37960c32c24b694", @"/Views/Readers/ReaderSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab9bdf1d125f678c601b2c2246e2b4f49f85bf8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Readers_ReaderSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LibraryApi.Models.Reader>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml"
  
    ViewData["Title"] = "ReaderSearch";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ReaderSearch</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Full Name
            </th>
            <th>
                Birthday
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml"
               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml"
               Write(item.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Игорь Алмазов\OneDrive\Документы\Visual Studio 2019\LibraryApi\Views\Readers\ReaderSearch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LibraryApi.Models.Reader>> Html { get; private set; }
    }
}
#pragma warning restore 1591
