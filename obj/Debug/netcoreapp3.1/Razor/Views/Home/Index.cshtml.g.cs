#pragma checksum "C:\Users\Martin Závodný\Desktop\example\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8e88efb6d15977c08f5c27a7a414164aa57fb7"
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
#line 1 "C:\Users\Martin Závodný\Desktop\example\Views\_ViewImports.cshtml"
using grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Martin Závodný\Desktop\example\Views\_ViewImports.cshtml"
using grid.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Martin Závodný\Desktop\example\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8e88efb6d15977c08f5c27a7a414164aa57fb7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88456c80b3cf7d272ed0aac1b127e06d47b47042", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Martin Závodný\Desktop\example\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n\n    <h1>Grid</h1>\n\n  \n    <input id=\"GridSearch\" />\n\n    ");
#nullable restore
#line 14 "C:\Users\Martin Závodný\Desktop\example\Views\Home\Index.cshtml"
Write(Html.AjaxGrid(Url.Action("Index")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <a");
            BeginWriteAttribute("href", " href=\"", 346, "\"", 427, 1);
#nullable restore
#line 16 "C:\Users\Martin Závodný\Desktop\example\Views\Home\Index.cshtml"
WriteAttributeValue("", 353, Url.Action("ExportIndex") + ViewContext.HttpContext.Request.QueryString, 353, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Export</a>

    <script>
    document.getElementById('GridSearch').addEventListener('input', function () {
            var grid = new MvcGrid(document.querySelector('.mvc-grid'));
            grid.query.set('search', this.value);

            grid.reload();
        });</script>



</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
