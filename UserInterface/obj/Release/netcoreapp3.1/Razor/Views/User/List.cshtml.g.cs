#pragma checksum "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ecf12bcc1496c2d331f987b9f73d706e68b85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_List), @"mvc.1.0.view", @"/Views/User/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ecf12bcc1496c2d331f987b9f73d706e68b85e", @"/Views/User/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43315f7187e02b91fbe085b63d31aa8b4d17d98", @"/Views/_ViewImports.cshtml")]
    public class Views_User_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserInterface.ViewModels.Entities.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\List.cshtml"
  
    ViewData["Title"] = "User List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section style=\"padding-top:50px\">\r\n    <div class=\"container pt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ecf12bcc1496c2d331f987b9f73d706e68b85e4328", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <nav aria-label=\"breadcrumb\">\r\n            <ol class=\"breadcrumb\">\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ecf12bcc1496c2d331f987b9f73d706e68b85e5900", async() => {
                WriteLiteral("EBookSharing");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Users</li>
            </ol>
        </nav>
        <div class=""input-group mb-3"">
            <input type=""text"" class=""form-control"" id=""ebs-search-value"" placeholder=""Search user""");
            BeginWriteAttribute("value", " value=\"", 714, "\"", 737, 1);
#nullable restore
#line 16 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\List.cshtml"
WriteAttributeValue("", 722, ViewBag.Search, 722, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""input-group-append"">
                <button class=""btn btn-outline-success"" id=""ebs-search-submit"" type=""button"">Find it</button>
            </div>
        </div>
        <div class=""row"" id=""users"">
            <div class=""col-md-2""></div>
            <div class=""col-md-8"">
                ");
#nullable restore
#line 24 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\User\List.cshtml"
           Write(await Html.PartialAsync("../Shared/PartialViews/_UserComponent.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\"></div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#ebs-search-submit"").click(function () {
                var search = $(""#ebs-search-value"").val();
                if (search.trim() != """") {
                    $.ajax({
                        method: ""GET"",
                        url: ""/api/ebs/users/list"",
                        contentType: ""application/json; charset=utf-8"",
                        type:""JSON"",
                        data: {
                            search: search,
                        },
                        headers: {
                            RequestVerificationToken:
                                $('input:hidden[name=""__RequestVerificationToken""]').val()
                        },
                        beforeSend: function () {
                            toastr.info(""We are updating your user list"", ""Please wait"");
                        },
                        success: function (result) {
                            con");
                WriteLiteral(@"sole.log(result);
                            if (result.length > 0) {
                                toastr.success(""Your user list was successfully updated"", ""Successful!"");
                                $(""#ebs-target-list"").empty();
                                for (let user of result) {
                                    var { imageSource, email, id } = user;
                                    var image = ""/img/no-user.png"";
                                    if (imageSource != null) {
                                        image = ""/img/"" + imageSource;
                                    }
                                    var col = `   <div class=""col-md-12"">
                                                <div class=""row pt-3 pl-3 pr-3 pb-3 bg-light mb-3"">
                                                    <div class=""col-md-4""><img src=""${image}"" width=""100%"" /></div>
                                                    <div class=""col-md-8"">
                               ");
                WriteLiteral(@"                         <p><b>${email}</b></p>
                                                        <a href=""/User/Details/${id}"" class=""btn btn-outline-primary"">Visit</a>
                                                        <a href=""/Message/Send/${id}"" class=""btn btn-outline-success"">Message</a>
                                                        <a href=""/Book/ByUser/${id}"" class=""btn btn-primary"">ELibrary</a>
                                                    </div>
                                                </div>
                                            </div>`;
                                    $(""#ebs-target-list"").append(col);
                                }
                            } else {
                                toastr.error(""There is no user that you have searching"", ""No result"");
                            }
                        },
                        error: function (result) {
                            toastr.error(result, ""Oops..."");
");
                WriteLiteral("                        }\r\n                    });\r\n                }\r\n                else {\r\n                    toastr.error(\"Search field is empty\", \"What!?\");\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserInterface.ViewModels.Entities.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591