#pragma checksum "C:\Users\ibrah\Source\Repos\cali\Views\Shared\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc73fdf898e5499fe5ba7996e406b23886b8e239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc73fdf898e5499fe5ba7996e406b23886b8e239", @"/Views/Shared/_Post.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cali.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<article class=\"blog-post\">\r\n    <h1>\r\n        ");
#nullable restore
#line 7 "C:\Users\ibrah\Source\Repos\cali\Views\Shared\_Post.cshtml"
   Write(Html.ActionLink(Model.Title, "Post", "Blog",
       new { year = Model.Posted.Year, month = Model.Posted.Month, key = Model.Key }
       ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"details\">\r\n        Posted <span>");
#nullable restore
#line 12 "C:\Users\ibrah\Source\Repos\cali\Views\Shared\_Post.cshtml"
                Write(Format.AsReadableDate(Model.Posted));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> by <span>");
#nullable restore
#line 12 "C:\Users\ibrah\Source\Repos\cali\Views\Shared\_Post.cshtml"
                                                                    Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 15 "C:\Users\ibrah\Source\Repos\cali\Views\Shared\_Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</article>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public cali.Models.FormattingService Format { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cali.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
