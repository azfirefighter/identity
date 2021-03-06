#pragma checksum "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c496a074e0f80fa87918257367519d282db66fa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Identity_RoleUsers), @"mvc.1.0.view", @"/Views/Identity/RoleUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Identity/RoleUsers.cshtml", typeof(AspNetCore.Views_Identity_RoleUsers))]
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
#line 1 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c496a074e0f80fa87918257367519d282db66fa5", @"/Views/Identity/RoleUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Identity_RoleUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUsersDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", "gravatar-image img-thumbnail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserRolesDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Skoruba.IdentityServer4.Admin.Helpers.TagHelpers.GravatarTagHelper __Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(243, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
  
    ViewBag.Title = Localizer["Title"];
    Layout = "_Layout";
    var roleId = Context.Request.Query["roleId"];

#line default
#line hidden
            BeginContext(363, 162, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-12\">\n        <nav aria-label=\"breadcrumb\">\n            <ol class=\"breadcrumb\">\n                <li class=\"breadcrumb-item\">");
            EndContext();
            BeginContext(525, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c496a074e0f80fa87918257367519d282db66fa56664", async() => {
                BeginContext(574, 28, false);
#line 16 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                                                       Write(Localizer["NavigationRoles"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 77, true);
            WriteLiteral("</li>\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
            EndContext();
            BeginContext(684, 20, false);
#line 17 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                                  Write(ViewData["RoleName"]);

#line default
#line hidden
            EndContext();
            BeginContext(704, 88, true);
            WriteLiteral("</li>\n            </ol>\n        </nav>\n    </div>\n\n    <div class=\"col-12\">\n        <h2>");
            EndContext();
            BeginContext(793, 18, false);
#line 23 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
       Write(Localizer["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(811, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(814, 20, false);
#line 23 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                            Write(ViewData["RoleName"]);

#line default
#line hidden
            EndContext();
            BeginContext(834, 77, true);
            WriteLiteral(")</h2>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-12\">\n        ");
            EndContext();
            BeginContext(911, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c496a074e0f80fa87918257367519d282db66fa59942", async() => {
                BeginContext(979, 118, true);
                WriteLiteral("\n            <div class=\"form-row\">\n                <div class=\"col-12 mb-3\">\n                    <input name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1097, "\"", 1112, 1);
#line 32 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
WriteAttributeValue("", 1105, roleId, 1105, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1113, 58, true);
                WriteLiteral(" type=\"hidden\" />\n                    <input name=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1171, "\"", 1194, 1);
#line 33 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
WriteAttributeValue("", 1179, ViewBag.Search, 1179, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1195, 12, true);
                WriteLiteral(" type=\"text\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1207, "\"", 1257, 1);
#line 33 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
WriteAttributeValue("", 1221, Localizer["InputSearchPlaceHolder"], 1221, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1258, 209, true);
                WriteLiteral(" class=\"form-control\" />\n                </div>\n            </div>\n\n            <div class=\"form-row\">\n                <div class=\"col-12 mb-3\">\n                    <input type=\"submit\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1467, "\"", 1501, 1);
#line 39 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
WriteAttributeValue("", 1475, Localizer["ButtonSearch"], 1475, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1502, 54, true);
                WriteLiteral(" />\n                </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1563, 261, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-12"">
        <div class=""table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th></th>
                        <th>");
            EndContext();
            BeginContext(1825, 19, false);
#line 53 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                       Write(Localizer["UserId"]);

#line default
#line hidden
            EndContext();
            BeginContext(1844, 34, true);
            WriteLiteral("</th>\n                        <th>");
            EndContext();
            BeginContext(1879, 21, false);
#line 54 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                       Write(Localizer["UserName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 34, true);
            WriteLiteral("</th>\n                        <th>");
            EndContext();
            BeginContext(1935, 18, false);
#line 55 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                       Write(Localizer["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(1953, 116, true);
            WriteLiteral("</th>\n                        <th></th>\n                    </tr>\n                </thead>\n\n                <tbody>\n");
            EndContext();
#line 61 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                     foreach (var user in Model.Users)
                    {

#line default
#line hidden
            BeginContext(2146, 115, true);
            WriteLiteral("                        <tr>\n                            <td class=\"align-middle\">\n                                ");
            EndContext();
            BeginContext(2261, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img-gravatar", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c496a074e0f80fa87918257367519d282db66fa516452", async() => {
            }
            );
            __Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper = CreateTagHelper<global::Skoruba.IdentityServer4.Admin.Helpers.TagHelpers.GravatarTagHelper>();
            __tagHelperExecutionContext.Add(__Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper);
            BeginWriteTagHelperAttribute();
#line 65 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                         WriteLiteral(user.Email);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper.Email = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("email", __Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper.Email, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Skoruba_IdentityServer4_Admin_Helpers_TagHelpers_GravatarTagHelper.Class = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2334, 88, true);
            WriteLiteral("\n                            </td>\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2423, 7, false);
#line 67 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2430, 59, true);
            WriteLiteral("</td>\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2490, 13, false);
#line 68 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2503, 59, true);
            WriteLiteral("</td>\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(2563, 10, false);
#line 69 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2573, 92, true);
            WriteLiteral("</td>\n                            <td class=\"align-middle\">\n                                ");
            EndContext();
            BeginContext(2665, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c496a074e0f80fa87918257367519d282db66fa519994", async() => {
                BeginContext(2771, 29, true);
                WriteLiteral("<span class=\"oi oi-x\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                                                         WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 71 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                                                                                                                     WriteLiteral(roleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-roleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["roleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2804, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 74 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
                    }

#line default
#line hidden
            BeginContext(2891, 131, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n<div class=\"row\">\n    <div class=\"col-12\">\n        ");
            EndContext();
            BeginContext(3023, 179, false);
#line 83 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Identity/RoleUsers.cshtml"
   Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "RoleUsers", PageSize = Model.PageSize, TotalCount = Model.TotalCount, EnableSearch = true, Search = ViewBag.Search }));

#line default
#line hidden
            EndContext();
            BeginContext(3202, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces.IUsersDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
