#pragma checksum "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "90f8b427005c4128fbd2c3cc3912c62f0f3d3614a3ac3f8c58a038c19486aab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_WriterDashboard_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/WriterDashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"90f8b427005c4128fbd2c3cc3912c62f0f3d3614a3ac3f8c58a038c19486aab9", @"/Areas/Writer/Views/WriterDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7607ef8247fe001c84710f4e2141ef24c2ca88566080e2406f11429b3e3fc2ae", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_WriterDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/skydash/images/dashboard/people.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("people"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-xl-8 mb-4 mb-xl-0\">\r\n                <h3 class=\"font-weight-bold\">Hoşgeldiniz:<b style=\"color:red;\">");
#nullable restore
#line 11 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                                                          Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
                <h6 class=""font-weight-normal mb-0"">Asp.Net Core Dashboard Paneli Yeni Duyurular İçin <span class=""text-primary"">Hemen Tıkla!</span></h6>
            </div>
            <div class=""col-12 col-xl-4"">
                <div class=""justify-content-end d-flex"">
                    <div class=""dropdown flex-md-grow-1 flex-xl-grow-0"">
                        <button class=""btn btn-sm btn-light bg-white dropdown-toggle"" type=""button"" id=""dropdownMenuDate2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                            <i class=""mdi mdi-calendar""></i> ");
#nullable restore
#line 18 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                                        Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card tale-bg"">
            <div class=""card-people mt-auto"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90f8b427005c4128fbd2c3cc3912c62f0f3d3614a3ac3f8c58a038c19486aab96318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""weather-info"">
                    <div id=""wwo-weather-widget-1""></div><script type='text/javascript' src='https://www.worldweatheronline.com/widget/v5/weather-widget.ashx?loc=2451733&wid=1&tu=1&div=wwo-weather-widget-1' async></script><noscript><a href=""https://www.worldweatheronline.com/nigde-weather/nigde/tr.aspx"" alt=""Hour by hour Nigde, Nigde weather"">Nigde, Nigde weather forecast hourly</a></noscript>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 grid-margin transparent"">
        <div class=""row"">
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-tale"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Gelen Mesaj Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 43 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                         Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-dark-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Duyuru Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 51 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                         Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-4 mb-lg-0 stretch-card transparent"">
                <div class=""card card-light-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Toplam Kullanıcı Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 61 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                         Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 stretch-card transparent"">
                <div class=""card card-light-danger"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Toplam Yetenek Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 69 "C:\Users\Eren\source\repos\asp.net core mvc\Core_Web\Core_Web\Areas\Writer\Views\WriterDashboard\Index.cshtml"
                                         Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
