#pragma checksum "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34ac62e70187f844ed42580858514868f6308c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_LatestArticles__LetestArticles), @"mvc.1.0.view", @"/Views/Home/Components/LatestArticles/_LetestArticles.cshtml")]
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
#line 1 "E:\testproject\NetCore\DevCart\DevCart\Views\_ViewImports.cshtml"
using DevCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\testproject\NetCore\DevCart\DevCart\Views\_ViewImports.cshtml"
using DevCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ac62e70187f844ed42580858514868f6308c57", @"/Views/Home/Components/LatestArticles/_LetestArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ae6816ff32e5805a2ee47c98492fe83f96658f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_LatestArticles__LetestArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <section class=\"latest-blog-section p-3 p-lg-5\">\r\n        <div class=\"container\">\r\n            <h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 8 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"
                 foreach (var article in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-5\">\r\n                    <div class=\"card blog-post-card\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 440, "\"", 479, 2);
            WriteAttributeValue("", 446, "assets/images/blog/", 446, 19, true);
#nullable restore
#line 12 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"
WriteAttributeValue("", 465, article.Image, 465, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                <a class=\"theme-link\" href=\"blog-post.html\">\r\n                                  ");
#nullable restore
#line 16 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"
                             Write(article.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 16 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"
                                         Write(article.Titel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                            <p class=\"card-text\">\r\n                               ");
#nullable restore
#line 20 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"
                          Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"mb-0\"><a class=\"more-link\" href=\"blog-post.html\">ادامه مطلب</a></p>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "E:\testproject\NetCore\DevCart\DevCart\Views\Home\Components\LatestArticles\_LetestArticles.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
