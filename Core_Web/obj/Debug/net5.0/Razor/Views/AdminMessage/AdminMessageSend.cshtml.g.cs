#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fb310e299a3414d1267eb9394eb0ad1cbbc2ae63d4c4b3bbedff831d826d07fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_AdminMessageSend), @"mvc.1.0.view", @"/Views/AdminMessage/AdminMessageSend.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fb310e299a3414d1267eb9394eb0ad1cbbc2ae63d4c4b3bbedff831d826d07fb", @"/Views/AdminMessage/AdminMessageSend.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_AdminMessageSend : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
  
    ViewData["Title"] = "AdminMessageSend";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
 using (Html.BeginForm("AdminMessageSend", "AdminMessage", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n       <label>Konu</label>\r\n        ");
#nullable restore
#line 13 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
   Write(Html.TextBoxFor(Model=>Model.Subject,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n\r\n        <label>Alıcı</label>\r\n        ");
#nullable restore
#line 19 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
   Write(Html.TextBoxFor(Model=>Model.Receiver,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n\r\n        <label>Mesaj</label>\r\n        ");
#nullable restore
#line 25 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
   Write(Html.TextAreaFor(Model=>Model.MessageContent,8,3,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button class=\"btn btn-primary\">Gönder</button>\r\n");
#nullable restore
#line 29 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\AdminMessage\AdminMessageSend.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
