#pragma checksum "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6789364e09dfe33d3f2a7bb393763a53eb04b1ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LeapYears.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace LeapYears.Pages
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
#line 1 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\_ViewImports.cshtml"
using LeapYears;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6789364e09dfe33d3f2a7bb393763a53eb04b1ea", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd5a5ebe6f347c6bcbd2b4a2f1c1a70151ecf3f", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Dzisiejsze wyszukiwania (");
#nullable restore
#line 6 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
                            Write(Model.records.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n");
            WriteLiteral(@"    <table class=""table table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Użytkownik</th>
                <th scope=""col"">Wyszukiwany wynik</th>
                <th scope=""col"">Czas</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 18 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
             foreach (var item in Model.records.History)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 21 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "D:\Dokumenty\Studia\06.SEMESTR VI\.NET\zad6 - wstrzykiwanie serwisów\LeapYears\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>      \r\n    </table>\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
