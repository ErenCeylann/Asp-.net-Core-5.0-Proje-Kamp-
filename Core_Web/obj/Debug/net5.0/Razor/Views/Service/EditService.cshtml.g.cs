#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a05c28ac97d488fabf9681f68ad9e55b413ae3998671cee9d684fb050d8b93b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_EditService), @"mvc.1.0.view", @"/Views/Service/EditService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a05c28ac97d488fabf9681f68ad9e55b413ae3998671cee9d684fb050d8b93b9", @"/Views/Service/EditService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_EditService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
  
    ViewData["Title"] = "EditService";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
 using (Html.BeginForm("EditService", "Service", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
Write(Html.HiddenFor(x=>x.ServiceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
   Write(Html.LabelFor(Model=>Model.Title,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
   Write(Html.TextBoxFor(Model=>Model.Title,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
   Write(Html.LabelFor(Model=>Model.ImageUrl,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
   Write(Html.TextBoxFor(Model=>Model.ImageUrl,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button class=\"btn btn-outline-primary\">Güncelle</button>\r\n");
#nullable restore
#line 20 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Views\Service\EditService.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
