#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a2db506cb9c05494f18666699b318864c4fe1ee75df48af46aba9f79d9ff1857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\_ViewImports.cshtml"
using Core_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\_ViewImports.cshtml"
using Core_Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a2db506cb9c05494f18666699b318864c4fe1ee75df48af46aba9f79d9ff1857", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Referanslar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                
                                <th> Görsel </th>
                                <th> Ad - Soyad </th>
                                <th> Şirket </th>
                                <th> Ünvan </th>
                                <th> Sil </th>
                                <th> Detaylar </th>
                                
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
                             foreach (var x in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr> \r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1167, "\"", 1184, 1);
#nullable restore
#line 32 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1173, x.ImageUrl, 1173, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 34 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
                                Write(x.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 35 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
                                Write(x.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
                                Write(x.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1448, "\"", 1502, 2);
            WriteAttributeValue("", 1455, "/Testimonial/DeleteTestimonial/", 1455, 31, true);
#nullable restore
#line 37 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1486, x.TestimonialId, 1486, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1589, "\"", 1641, 2);
            WriteAttributeValue("", 1596, "/Testimonial/EditTestimonial/", 1596, 29, true);
#nullable restore
#line 38 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1625, x.TestimonialId, 1625, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Testimonial\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
