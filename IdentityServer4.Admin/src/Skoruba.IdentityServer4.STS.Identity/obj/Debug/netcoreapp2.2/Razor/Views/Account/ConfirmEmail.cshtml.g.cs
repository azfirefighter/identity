#pragma checksum "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity/Views/Account/ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "708edd888fbc2d37104ca3a392be9f3d6b3cc568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ConfirmEmail.cshtml", typeof(AspNetCore.Views_Account_ConfirmEmail))]
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
#line 1 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity/Views/Account/ConfirmEmail.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708edd888fbc2d37104ca3a392be9f3d6b3cc568", @"/Views/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28e5beff1cf1bbea99515e61bb4d8266ea1e24ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity/Views/Account/ConfirmEmail.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
            BeginContext(127, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(133, 17, false);
#line 7 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity/Views/Account/ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(150, 28, true);
            WriteLiteral("</h1>\n<div>\n    <p>\n        ");
            EndContext();
            BeginContext(179, 27, false);
#line 10 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.STS.Identity/Views/Account/ConfirmEmail.cshtml"
   Write(Localizer["ConfirmMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(206, 17, true);
            WriteLiteral("\n    </p>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
