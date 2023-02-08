#pragma checksum "E:\Source\ServiceChannel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64ca1053e62fd0f93e6348d39028df9cd5994cb"
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
#line 1 "E:\Source\ServiceChannel\Views\_ViewImports.cshtml"
using Covid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
using Covid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64ca1053e62fd0f93e6348d39028df9cd5994cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b07ee603adbad415e99d0bf33789ef23f0f722", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var i = 1;

    List<NewsItemViewModel> articleList = (List<NewsItemViewModel>)ViewData["News"];
    NewsItemViewModel featuredNewsItem = articleList[0];
    var articleCount = articleList.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"hero is-halfheight has-background is-bold is-dark\">\r\n    <img class=\"hero-background is-transparent\"");
            BeginWriteAttribute("src", " src=\"", 387, "\"", 438, 2);
#nullable restore
#line 13 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 393, featuredNewsItem.Image.Thumbnail.ContentUrl, 393, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 437, "?", 437, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 439, "\"", 467, 1);
#nullable restore
#line 13 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 445, featuredNewsItem.Name, 445, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"hero-body\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 16 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
             if (ViewBag.Message == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"title\">\r\n                ");
#nullable restore
#line 19 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n");
#nullable restore
#line 21 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"title\">\r\n                ");
#nullable restore
#line 23 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
           Write(featuredNewsItem.DatePublished.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 23 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                                                    Write(featuredNewsItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n            <h3 class=\"subtitle\">\r\n                ");
#nullable restore
#line 26 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
           Write(featuredNewsItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 956, "\"", 987, 1);
#nullable restore
#line 28 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 963, featuredNewsItem.AmpUrl, 963, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"button\">Read More</a>\r\n            <div class=\"level-right\">\r\n                <p class=\"level-item\"><strong>");
#nullable restore
#line 30 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                         Write(featuredNewsItem.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p class=\"level-item\">");
#nullable restore
#line 31 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                 Write(featuredNewsItem.Provider.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</div>
<div class=""container is-widescreen is-fluid"">
    <main role=""main"">
       <section class=""section"">
            <div class=""container"">
                <h1 class=""title"">Latest News</h1>
                <div class=""tile is-ancestor"">
");
#nullable restore
#line 42 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                     foreach (NewsItemViewModel item in articleList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div formatter");
            BeginWriteAttribute("sequence", " sequence=\"", 1674, "\"", 1687, 1);
#nullable restore
#line 44 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 1685, i, 1685, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"tile is-parent\">\r\n                                <article class=\"tile is-child box\">\r\n                                    <h3 class=\"title\">\r\n                                        <bold>");
#nullable restore
#line 48 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</bold>\r\n                                    </h3>\r\n                                    <p class=\"subtitle\">");
#nullable restore
#line 50 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                                   Write(item.DatePublished.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"content\">\r\n                                        ");
#nullable restore
#line 52 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2246, "\"", 2265, 1);
#nullable restore
#line 53 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2253, item.AmpUrl, 2253, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Read More</a>\r\n                                    </div>\r\n                                    <figure class=\"image\">\r\n");
#nullable restore
#line 56 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                         if (item.Image != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <img");
            BeginWriteAttribute("src", " src=\"", 2560, "\"", 2599, 2);
#nullable restore
#line 58 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2566, item.Image.Thumbnail.ContentUrl, 2566, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2598, "?", 2598, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2600, "\"", 2616, 1);
#nullable restore
#line 58 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
WriteAttributeValue("", 2606, item.Name, 2606, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 59 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </figure>\r\n                                </article>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 64 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                        if (i % 3 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</div><div class=\"tile is-ancestor\">\r\n");
#nullable restore
#line 67 "E:\Source\ServiceChannel\Views\Home\Index.cshtml"
                        }
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591