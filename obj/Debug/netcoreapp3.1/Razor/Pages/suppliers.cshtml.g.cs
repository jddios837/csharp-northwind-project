#pragma checksum "/media/dev/Courses/Net Core 3/Code/PracticalApps/NorthwindWeb/Pages/suppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e099113e7e6cb22d7d18ff03caa862e0ae6491d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_suppliers), @"mvc.1.0.razor-page", @"/Pages/suppliers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e099113e7e6cb22d7d18ff03caa862e0ae6491d", @"/Pages/suppliers.cshtml")]
    public class Pages_suppliers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n  <h1 class=\"display-2\">Suppliers</h1>\n  <table class=\"table\">\n    <thead class=\"thead-inverse\">\n      <tr><th>Company Name</th></tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 10 "/media/dev/Courses/Net Core 3/Code/PracticalApps/NorthwindWeb/Pages/suppliers.cshtml"
       foreach(string name in Model.Suppliers)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n          <td>\n            ");
#nullable restore
#line 14 "/media/dev/Courses/Net Core 3/Code/PracticalApps/NorthwindWeb/Pages/suppliers.cshtml"
       Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          </td>\n        </tr>\n");
#nullable restore
#line 17 "/media/dev/Courses/Net Core 3/Code/PracticalApps/NorthwindWeb/Pages/suppliers.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n  </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindWeb.Pages.SuppliersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.SuppliersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindWeb.Pages.SuppliersModel>)PageContext?.ViewData;
        public NorthwindWeb.Pages.SuppliersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
