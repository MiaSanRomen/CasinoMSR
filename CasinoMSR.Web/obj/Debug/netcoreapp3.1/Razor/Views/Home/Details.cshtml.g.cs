#pragma checksum "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9617a47032ea2cb5858a5ddc923de26f73e23189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\_ViewImports.cshtml"
using HistoryPedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\_ViewImports.cshtml"
using HistoryPedia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9617a47032ea2cb5858a5ddc923de26f73e23189", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75f1945c141de4f0670d1a90025721e81fd5d54", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistoryPedia.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateGame", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- main-area -->
<main>

    <!-- movie-details-area -->
    <section class=""movie-details-area"" data-background=""/img/bg/movie_details_bg.jpg"">
        <div class=""container"">
            <div class=""row align-items-center position-relative"">
                <div class=""col-xl-3 col-lg-4"">
                    <div class=""movie-details-img"">
");
#nullable restore
#line 17 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                         if (string.IsNullOrEmpty(Model.Image.Path))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 580, "\"", 653, 2);
            WriteAttributeValue("", 586, "data:image/jpeg;base64,", 586, 23, true);
#nullable restore
#line 19 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
WriteAttributeValue("", 609, Convert.ToBase64String(Model.Image.Image), 609, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 20 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 773, "\"", 796, 1);
#nullable restore
#line 23 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
WriteAttributeValue("", 779, Model.Image.Path, 779, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"col-xl-6 col-lg-8\">\r\n                    <div class=\"movie-details-content\">\r\n                        <h5>New game</h5>\r\n                        <h2>");
#nullable restore
#line 30 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 30 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                                         Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                        <div class=\"banner-meta\">\r\n                            <ul>\r\n                                <li class=\"quality\">\r\n                                    <span>");
#nullable restore
#line 34 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                                     Write(Model.Recommendations);

#line default
#line hidden
#nullable disable
            WriteLiteral(" recommend</span>\r\n                                    <span>");
#nullable restore
#line 35 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                                     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                                <li class=\"release-time\">\r\n                                    <span><i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 38 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                                                                         Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                        <p>\r\n                            ");
#nullable restore
#line 43 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                       Write(Model.Info);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                        <div class=""movie-details-prime"">
                            <ul>
                                <li class=""share""><a href=""#""><i class=""fas fa-share-alt""></i> Share</a></li>
                                <li class=""streaming"">
                                    <h6>Online Game</h6>
                                    <span>Streaming Channels</span>
                                </li>
                                <li class=""watch"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9617a47032ea2cb5858a5ddc923de26f73e231899112", async() => {
                WriteLiteral("<i class=\"fas fa-play\"></i> Play Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\Diplom.Git\Casino\CasinoMSR.Web\Views\Home\Details.cshtml"
                                                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- movie-details-area-end -->\r\n</main>\r\n<!-- main-area-end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistoryPedia.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
