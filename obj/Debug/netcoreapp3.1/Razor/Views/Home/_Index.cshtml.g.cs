#pragma checksum "C:\Users\Martin Závodný\Desktop\example\Views\Home\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "619647d26718baccf9b3c76e319befd155f61cdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Index), @"mvc.1.0.view", @"/Views/Home/_Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"619647d26718baccf9b3c76e319befd155f61cdf", @"/Views/Home/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88456c80b3cf7d272ed0aac1b127e06d47b47042", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Martin Závodný\Desktop\example\Views\Home\_Index.cshtml"
Write(Html
    .Grid(Model)
    .Build(columns =>
    {
        columns.Add(model => model.FirstName).Titled("Firstname");
        columns.Add(model => model.LastName).Titled("Lastname");
        columns.Add(model => model.Age).Titled("Age");
    })
    .Empty("No data found")
    .Sortable()
    .Filterable()
);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
