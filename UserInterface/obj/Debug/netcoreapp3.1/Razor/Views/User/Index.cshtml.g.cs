#pragma checksum "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e867e19780fdc18f812c4ed0935edb9c3bc74410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\_ViewImports.cshtml"
using UserInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\_ViewImports.cshtml"
using UserInterface.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e867e19780fdc18f812c4ed0935edb9c3bc74410", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43315f7187e02b91fbe085b63d31aa8b4d17d98", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccess.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/index-1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/index-3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .ebs-menu{display:none} .card{margin:0 auto;}
    .ebs-left-menu {background:#3C3A52;box-shadow:0 0 10px rgba(0,0,0,0.5);border-radius: 5px;padding: 20px;}
    .ebs-left-menu a{color:white;font-size:20px;padding-bottom:10px;text-decoration:none;transition:all ease .3s;}
    .ebs-left-menu a:hover{color:#6C63FF;text-decoration:none;padding-left:10px;}
    .ebs-left-menu p {border-color:#6C63FF !important;}
</style>
<section style=""padding-top:60px;"">
    <div class=""container-fluid"">
        <hr />
        <div class=""row pt-3"">
            <div class=""col-md-3"">
                ");
#nullable restore
#line 18 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml"
           Write(await Html.PartialAsync("../Shared/PartialViews/_MenuComponent.cshtml", ViewData["Id"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml"
                 if (ViewBag.Role == "admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""ebs-left-menu mb-4"">
                        <h4 class=""text-light mb-3"">Admin panel</h4>
                        <p class=""border-bottom""><a href=""#""><i class=""fa fa-users mr-2""></i> Users</a></p>
                        <p class=""border-bottom""><a href=""#""><i class=""fa fa-book mr-2""></i> Books</a></p>
                    </div>
");
#nullable restore
#line 26 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4 mb-4\">\r\n                        <div class=\"card\" style=\"width: 18rem;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e867e19780fdc18f812c4ed0935edb9c3bc744106385", async() => {
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
                            <div class=""card-body"">
                                <h5 class=""card-title"">Create your own ELibrary</h5>
                                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" class=""btn btn-primary pull-right"">View</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-4"">
                        <div class=""card"" style=""width: 18rem;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e867e19780fdc18f812c4ed0935edb9c3bc744108227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div class=""card-body"">
                                <h5 class=""card-title"">Looking for a book?</h5>
                                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" class=""btn btn-primary pull-right"">View</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4 mb-4"">
                        <div class=""card"" style=""width: 18rem;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e867e19780fdc18f812c4ed0935edb9c3bc7441010064", async() => {
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
                            <div class=""card-body"">
                                <h5 class=""card-title"">Easy to track book</h5>
                                <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            </div>
                            <div class=""card-footer"">
                                <a href=""#"" class=""btn btn-primary pull-right"">View</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var trCount = ");
#nullable restore
#line 73 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\Index.cshtml"
                 Write(ViewData["TrCount"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        if (trCount > 0) {
            $(""#signalr-requests"").html(trCount);
        }
        const hubConnection = new signalR.HubConnectionBuilder().withUrl(""/requests"").build();
 
        hubConnection.on(""Send"", function (data) {
            let elem = document.createElement(""p"");
            elem.appendChild(document.createTextNode(data));
            let firstElem = document.getElementById(""chatroom"").firstChild;
            document.getElementById(""chatroom"").insertBefore(elem, firstElem);
 
        });
 
        document.getElementById(""sendBtn"").addEventListener(""click"", function (e) {
            let message = document.getElementById(""message"").value;
            hubConnection.invoke(""Send"", message);
        });
 
        hubConnection.start();
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccess.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
