#pragma checksum "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f12ba37ebd60900eec00bdef582c8632755aca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f12ba37ebd60900eec00bdef582c8632755aca", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f12ba37ebd60900eec00bdef582c8632755aca3779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Register Now</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 13 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                 using (Html.BeginForm("Index", "Register", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Name-Surname</label>\r\n                            ");
#nullable restore
#line 18 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.WriterName,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 19 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterName,"",new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Email</label>\r\n                            ");
#nullable restore
#line 24 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterMail,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Password</label>
                            ");
#nullable restore
#line 32 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 33 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterPassword,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Writer Image</label>\r\n                            ");
#nullable restore
#line 38 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                        </div>

                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Register</button>
                    <p>
                        <input type=""checkbox"" /> <a href=""#"" id=""btn1"">I have read all the terms, I agree to your terms</a>
                    </p>
");
#nullable restore
#line 48 "C:\Users\ULAŞ\source\repos\CoreDemo\CoreDemo\Views\Register\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <br />

    <script>
        $('#btn1').click(function () {
            swal(""PRIVACY POLICY"",""IP gives you just for user agent, to do analysis and candies etc. technologies, automated or non-automated, are aimed at being true to reality, retained, recorded, stored and retrieved from, and obtained from and by business, up-to-date and real analytics providers, advertisers, search providers, technology providers."");
        });
    </script>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
