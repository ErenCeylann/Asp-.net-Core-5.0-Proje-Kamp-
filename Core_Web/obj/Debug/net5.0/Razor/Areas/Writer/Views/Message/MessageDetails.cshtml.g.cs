#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "581df42363a0adb6deff4737b79e1e90fd5b45442f7c15ef034f95c4176d1a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_MessageDetails), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/MessageDetails.cshtml")]
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
#line 1 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"581df42363a0adb6deff4737b79e1e90fd5b45442f7c15ef034f95c4176d1a32", @"/Areas/Writer/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n       \r\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                          Write(Html.HiddenFor(x=>x.WriterMessageID,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Gönderici Mail:");
#nullable restore
#line 11 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                                                            Write(Html.TextBoxFor(x=>x.Sender,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Alıcı Mail:");
#nullable restore
#line 12 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                                                        Write(Html.TextBoxFor(x=>x.Receiver,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Tarih:");
#nullable restore
#line 13 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                                                   Write(Html.TextBoxFor(x=>x.Date,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Gönderen Adı:");
#nullable restore
#line 14 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                                                          Write(Html.TextBoxFor(x=>x.SenderName,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Alıcı Adı:");
#nullable restore
#line 15 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                                                       Write(Html.TextBoxFor(x=>x.ReceiverName,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p class=\"card-text\">Mesaj:");
#nullable restore
#line 16 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\Message\MessageDetails.cshtml"
                              Write(Html.TextAreaFor(x=>x.MessageContent,13,30,new { disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
