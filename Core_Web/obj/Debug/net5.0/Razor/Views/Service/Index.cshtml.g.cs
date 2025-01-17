#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e45ceca9c89a938ca2089a959fd00bf088522b06f58e0c6fa1062e3b94b8dea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e45ceca9c89a938ca2089a959fd00bf088522b06f58e0c6fa1062e3b94b8dea4", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Hizmet Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Görsel</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 25 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
             foreach (var item in Model)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 30 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
                   Write(item.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1133, "\"", 1153, 1);
#nullable restore
#line 36 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
WriteAttributeValue("", 1139, item.ImageUrl, 1139, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96px\" height=\"96px\"/>\r\n                    </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1238, "\"", 1283, 2);
            WriteAttributeValue("", 1245, "/Service/DeleteService/", 1245, 23, true);
#nullable restore
#line 38 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
WriteAttributeValue("", 1268, item.ServiceId, 1268, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil <i class=\"bi bi-trash\"></i></a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1384, "\"", 1427, 2);
            WriteAttributeValue("", 1391, "/Service/EditService/", 1391, 21, true);
#nullable restore
#line 39 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
WriteAttributeValue("", 1412, item.ServiceId, 1412, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle <i class=\"bi bi-pen\"></i></a></td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Service/AddService\" class=\"btn btn-primary\">Yeni Hizmet Ekle <i class=\"bi bi-plus-square\"></i></a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
