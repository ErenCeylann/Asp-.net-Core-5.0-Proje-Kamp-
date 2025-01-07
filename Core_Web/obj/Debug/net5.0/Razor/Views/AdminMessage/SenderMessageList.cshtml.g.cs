#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5897046df2e4d443cd7e4bf8d84b48ded7c7c43db513973d0d8df9e594931aef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_SenderMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/SenderMessageList.cshtml")]
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
#line 1 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5897046df2e4d443cd7e4bf8d84b48ded7c7c43db513973d0d8df9e594931aef", @"/Views/AdminMessage/SenderMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_SenderMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
  
    ViewData["Title"] = "SenderMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar - Admin Giden Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Alıcı</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                               Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                                                              Write(item.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1277, "\"", 1352, 3);
            WriteAttributeValue("", 1284, "/AdminMessage/AdminMessageDelete/", 1284, 33, true);
#nullable restore
#line 33 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1317, item.WriterMessageID, 1317, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1338, "?sender=sender", 1338, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a> </td>\r\n                                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1501, 2);
            WriteAttributeValue("", 1446, "/AdminMessage/AdminMessageDetails/", 1446, 34, true);
#nullable restore
#line 34 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
WriteAttributeValue("", 1480, item.WriterMessageID, 1480, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\SenderMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
