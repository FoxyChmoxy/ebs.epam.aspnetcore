#pragma checksum "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f51839f4f09eca36435e503be7ff461bdd8b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Dialog), @"mvc.1.0.view", @"/Views/Message/Dialog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f51839f4f09eca36435e503be7ff461bdd8b87", @"/Views/Message/Dialog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43315f7187e02b91fbe085b63d31aa8b4d17d98", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Dialog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInterface.ViewModels.DialogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
  
    ViewData["Title"] = "Dialog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
#messages {overflow-y: scroll;width: 100%;height: 60vh;}
.myMessage {width: 100%;background: #EFFFDE;border-radius: 15px;padding: 5px;color: black;margin-bottom: 20px;padding-top: 10px;}
.friendMessage {width: 100%;background: #FFFFFF;border-radius: 15px;padding: 5px;color: black;margin-bottom: 20px;padding-top: 10px;}
.ebs-image {width: 50px;height: 50px;border-radius: 50%;overflow: hidden;margin:0 auto;}
.ebs-image img {width: 100%}
</style>
<section style=""padding-top:50px"">
    <div class=""container pt-5"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div style=""background:#D8DFE7"">
                    <div class=""bg-secondary pl-3 pt-3 pb-3 pt-3 text-light"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f51839f4f09eca36435e503be7ff461bdd8b875176", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <span>");
#nullable restore
#line 19 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                         Write(ViewBag.Receiver.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div id=\"messages\" class=\"pl-3 pr-3 pt-4 pb-2\">\r\n");
#nullable restore
#line 22 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                         foreach (var message in Model.Messages)
                        {
                            if (message.UserSenderEmail == User.Identity.Name)
                            {
                                var image = ViewBag.Me.ImageSource == null ? "no-user.png" : ViewBag.Receiver;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""myMessage"">
                                    <div class=""row mb-1"">
                                        <div class=""col-md-1"">
                                            <div class=""ebs-image"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47f51839f4f09eca36435e503be7ff461bdd8b877816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1710, "~/img/", 1710, 6, true);
#nullable restore
#line 31 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
AddHtmlAttributeValue("", 1716, ViewBag.Me.ImageSource, 1716, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"col-md-11 pt-1 text-left\">\r\n                                            <p>");
#nullable restore
#line 35 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                                          Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 39 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                            }
                            else
                            {
                                var image = ViewBag.Receiver.ImageSource == null ? "no-user.png" : ViewBag.Receiver;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""friendMessage"">
                                    <div class=""row mb-1"">
                                        <div class=""col-md-1"">
                                            <div class=""ebs-image"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47f51839f4f09eca36435e503be7ff461bdd8b8710640", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2649, "~/img/", 2649, 6, true);
#nullable restore
#line 47 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
AddHtmlAttributeValue("", 2655, image, 2655, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"col-md-11 pt-1 text-left\">\r\n                                            <p>");
#nullable restore
#line 51 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                                          Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 55 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""input-group mb-3"">
                    <input style=""padding:25px !important;padding-left:15px !important"" type=""text"" class=""form-control"" placeholder=""Write a message..."" id=""messageText"">
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary pl-4 pr-4"" id=""sendMessage""><i class=""fa fa-send""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Message\Dialog.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        $(document).ready(function () {

            const hubConnection = new signalR.HubConnectionBuilder()
            .withUrl(""/chat"")
            .build();
 
            hubConnection.on(""Send"", function (data) {
 
                let elem = document.createElement(""p"");
                elem.appendChild(document.createTextNode(data));
                let firstElem = document.getElementById(""messages"").firstChild;
                document.getElementById(""messages"").insertBefore(elem, firstElem);
 
            });
 
            document.getElementById(""sendMessage"").addEventListener(""click"", function (e) {
                let message = document.getElementById(""messageText"").value;
                hubConnection.invoke(""Send"", message);
            });
 
            hubConnection.start();

            //$(""#sendMessage"").click(function () {
            //    var message = $(""#messageText"").val().trim();
            //    if (message != """") {
            //        toastr");
                WriteLiteral(".success(message, \"success\");\r\n            //    }\r\n            //});\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInterface.ViewModels.DialogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591