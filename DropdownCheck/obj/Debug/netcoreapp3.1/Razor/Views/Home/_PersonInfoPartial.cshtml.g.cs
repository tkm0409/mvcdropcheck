#pragma checksum "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fa71de36ba4414a9e78283cc74bd879d5a392f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PersonInfoPartial), @"mvc.1.0.view", @"/Views/Home/_PersonInfoPartial.cshtml")]
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
#line 1 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\_ViewImports.cshtml"
using DropdownCheck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\_ViewImports.cshtml"
using DropdownCheck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fa71de36ba4414a9e78283cc74bd879d5a392f", @"/Views/Home/_PersonInfoPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b13000bd78a7603b20bb1cee9ca13d3e600bdb8f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__PersonInfoPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Information for ");
#nullable restore
#line 5 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h4>\r\n    <p>");
#nullable restore
#line 6 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml"
  Write(Model.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No information available.</p>\r\n");
#nullable restore
#line 11 "D:\Projects\.net MVC\DropdownCheck\DropdownCheck\Views\Home\_PersonInfoPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591