#pragma checksum "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20208d18ca0469a122331149c5fc4044e116a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Configuration_Clients), @"mvc.1.0.view", @"/Views/Configuration/Clients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Configuration/Clients.cshtml", typeof(AspNetCore.Views_Configuration_Clients))]
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
#line 1 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
using Skoruba.IdentityServer4.Admin.BusinessLogic.Shared.Dtos.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20208d18ca0469a122331149c5fc4044e116a57", @"/Views/Configuration/Clients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0c9e2904c50fcb45af80d4002c5716cb46aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Configuration_Clients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClientDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(229, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
  
	ViewBag.Title = Localizer["PageTitle"];
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(297, 47, true);
            WriteLiteral("\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t<h2>");
            EndContext();
            BeginContext(345, 22, false);
#line 13 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
       Write(Localizer["PageTitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(367, 39, true);
            WriteLiteral("</h2>\n\t</div>\n\n\t<div class=\"col-12\">\n\t\t");
            EndContext();
            BeginContext(406, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20208d18ca0469a122331149c5fc4044e116a575996", async() => {
                BeginContext(466, 33, true);
                WriteLiteral("<span class=\"oi oi-plus\"></span> ");
                EndContext();
                BeginContext(500, 31, false);
#line 17 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                                                                                                Write(Localizer["ButtonAddNewClient"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(535, 34, true);
            WriteLiteral("\n\t</div>\n\n\t<div class=\"col-12\">\n\t\t");
            EndContext();
            BeginContext(570, 107, false);
#line 21 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
   Write(await Html.PartialAsync("Common/Search", new Search() { Action = "Clients", Controller = "Configuration" }));

#line default
#line hidden
            EndContext();
            BeginContext(677, 176, true);
            WriteLiteral("\n\t</div>\n</div>\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t<div class=\"table-responsive\">\n\t\t\t<table class=\"table table-striped\">\n\t\t\t\t<thead>\n\t\t\t\t\t<tr>\n\t\t\t\t\t\t<th></th>\n\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(854, 26, false);
#line 31 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                       Write(Localizer["TableClientId"]);

#line default
#line hidden
            EndContext();
            BeginContext(880, 16, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(897, 28, false);
#line 32 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                       Write(Localizer["TableClientName"]);

#line default
#line hidden
            EndContext();
            BeginContext(925, 58, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t<th></th>\n\t\t\t\t\t</tr>\n\t\t\t\t</thead>\n\t\t\t\t<tbody>\n");
            EndContext();
#line 37 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                     foreach (var client in Model.Clients)
					{

#line default
#line hidden
            BeginContext(1034, 22, true);
            WriteLiteral("\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t<th>");
            EndContext();
            BeginContext(1056, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20208d18ca0469a122331149c5fc4044e116a579856", async() => {
                BeginContext(1130, 28, false);
#line 40 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                                                                                                    Write(Localizer["TableButtonEdit"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                                                                                 WriteLiteral(client.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1162, 17, true);
            WriteLiteral("</th>\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1180, 15, false);
#line 41 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                           Write(client.ClientId);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 17, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(1213, 17, false);
#line 42 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                           Write(client.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(1230, 26, true);
            WriteLiteral("</td>\n\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1256, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20208d18ca0469a122331149c5fc4044e116a5713492", async() => {
                BeginContext(1334, 29, true);
                WriteLiteral("<span class=\"oi oi-x\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
                                                                                      WriteLiteral(client.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 26, true);
            WriteLiteral("\n\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t</tr>\n");
            EndContext();
#line 47 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
					}

#line default
#line hidden
            BeginContext(1400, 92, true);
            WriteLiteral("\t\t\t\t</tbody>\n\t\t\t</table>\n\t\t</div>\n\t</div>\n</div>\n\n<div class=\"row\">\n\t<div class=\"col-12\">\n\t\t");
            EndContext();
            BeginContext(1493, 177, false);
#line 56 "/mnt/405A884F5A88441E/desenvolvimento/identity/IdentityServer4.Admin/src/Skoruba.IdentityServer4.Admin/Views/Configuration/Clients.cshtml"
   Write(await Html.PartialAsync("Common/Pager", new Pager { Action = "Clients", PageSize = Model.PageSize, TotalCount = Model.TotalCount, Search = ViewBag.Search, EnableSearch = true }));

#line default
#line hidden
            EndContext();
            BeginContext(1670, 15, true);
            WriteLiteral("\n\t</div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Skoruba.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration.ClientsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
