#pragma checksum "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf0ba0e017fe2d5d40e06cba52017213983ba34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/_ViewImports.cshtml"
using TruyenOnl.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/_ViewImports.cshtml"
using TruyenOnl.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using TruyenOnl.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml"
using TruyenOnl.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0ba0e017fe2d5d40e06cba52017213983ba34", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927529059f632fabaf0e846b24849b376d430bb8", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96ce4b3bf0d43af3c17e433568edb78f13db9c1", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ab2c7633b67581b6e90b99bc7c6622d07ba84d", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
#line 6 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 8 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "/Users/apple/Downloads/IT_CNPM/C#/Web_Developer_C7/TeamWork/FullProject/EndProject/BackEnd/TruyenOnl/TruyenOnl/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
