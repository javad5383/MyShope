#pragma checksum "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0906f08f035f3396a4ad5f67739107304f345c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_UserProfile), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/UserProfile.cshtml")]
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
#line 1 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\_ViewImports.cshtml"
using JShope;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\_ViewImports.cshtml"
using JShope.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0906f08f035f3396a4ad5f67739107304f345c78", @"/Pages/Admin/Users/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f855f6f6017778797de42ec5b97d57edda094e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_UserProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UserProfileStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0906f08f035f3396a4ad5f67739107304f345c783902", async() => {
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
<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">



<div class=""wrapper"">
    <div class=""content-wrapper"" style=""min-height: 474px;"">
        <section>
            <div class=""container bootstrap snippets bootdey"">
                <div class=""row"">
                    <div class=""profile-nav col-md-3"">
                        <div class=""panel"">
                            <div class=""user-heading round"">
                                <a href=""#"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 698, "\"", 742, 2);
            WriteAttributeValue("", 704, "/images/avatar/", 704, 15, true);
#nullable restore
#line 19 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
WriteAttributeValue("", 719, Model.Users.UserAvatar, 719, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 743, "\"", 749, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a>\r\n                                <h1>");
#nullable restore
#line 21 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                Write((Model.Users.Name)+" "+(Model.Users.Family));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                                <p> ");
#nullable restore
#line 22 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                               Write(Model.Users.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n\r\n                        <a style=\"margin-top: 3%\"");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1112, 2);
            WriteAttributeValue("", 1071, "/admin/users/edituser/", 1071, 22, true);
#nullable restore
#line 28 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
WriteAttributeValue("", 1093, Model.Users.UserId, 1093, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""submit"" class=""btn btn-success-outline btn-lg btn-block""> ویرایش</a>
                        <a style=""margin-top: 3%"" href=""/admin/users"" type=""submit"" class=""btn btn-danger-outline btn-lg btn-block""> بازگشت</a>
                    </div>
                    <div class=""profile-info col-md-9"">
                        <div class=""panel"">


                        </div>
                        <div class=""panel"">

                            <div class=""panel-body bio-graph-info"">
                                <h1>اطلاعات مشتری</h1>
                                <div class=""row"">
                                    <div class=""bio-row"">
                                        <p><span>نام </span>");
#nullable restore
#line 42 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                       Write(Model.Users.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>نام خانوادگی </span> ");
#nullable restore
#line 45 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                                 Write(Model.Users.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>کد ملی </span> ");
#nullable restore
#line 48 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                           Write(Model.Users.NationalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>شماره کارت</span> ");
#nullable restore
#line 51 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                              Write(Model.Users.BankCardNumber.ToString("0000-0000-0000-0000"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>نام کاربری </span> ");
#nullable restore
#line 54 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                               Write(Model.Users.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>ایمیل </span> ");
#nullable restore
#line 57 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                          Write(Model.Users.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>شماره همراه </span> ");
#nullable restore
#line 60 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                                Write(Model.Users.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>وضعیت </span> ");
#nullable restore
#line 63 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                          Write(Model.Users.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n                                    <div class=\"bio-row\">\r\n                                        <p><span>آدرس </span> ");
#nullable restore
#line 67 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Users\UserProfile.cshtml"
                                                         Write(Model.Users.UserHomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""panel"">
                                        <div class=""panel-body"">
                                            <div class=""bio-chart"">
                                                <div style=""display:inline;width:100px;height:100px;"">
                                                    <canvas width=""100"" height=""100px""></canvas>
                                                    <input class=""knob"" data-width=""100"" data-height=""100"" data-displayprevious=""true"" data-thickness="".2"" value=""35"" data-fgcolor=""#e06b7d"" data-bgcolor=""#e8e8e8"" style=""width: 54px; height: 33px; position: absolute; vertical-align: middle; margin-top: 33px; margin-left: -77px; border: 0p");
            WriteLiteral(@"x; font-weight: bold; font-style: normal; font-variant: normal; font-stretch: normal; font-size: 20px; line-height: normal; font-family: Arial; text-align: center; color: rgb(224, 107, 125); padding: 0px; -webkit-appearance: none; background: none;"">
                                                </div>
                                            </div>
                                            <div class=""bio-desk"">
                                                <h4 class=""red"">Envato Website</h4>
                                                <p>Started : 15 July</p>
                                                <p>Deadline : 15 August</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""panel"">
                                        <div class=""panel-body""");
            WriteLiteral(@">
                                            <div class=""bio-chart"">
                                                <div style=""display:inline;width:100px;height:100px;""><canvas width=""100"" height=""100px""></canvas><input class=""knob"" data-width=""100"" data-height=""100"" data-displayprevious=""true"" data-thickness="".2"" value=""63"" data-fgcolor=""#4CC5CD"" data-bgcolor=""#e8e8e8"" style=""width: 54px; height: 33px; position: absolute; vertical-align: middle; margin-top: 33px; margin-left: -77px; border: 0px; font-weight: bold; font-style: normal; font-variant: normal; font-stretch: normal; font-size: 20px; line-height: normal; font-family: Arial; text-align: center; color: rgb(76, 197, 205); padding: 0px; -webkit-appearance: none; background: none;""></div>
                                            </div>
                                            <div class=""bio-desk"">
                                                <h4 class=""terques"">ThemeForest CMS </h4>
                                                <p>S");
            WriteLiteral(@"tarted : 15 July</p>
                                                <p>Deadline : 15 August</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""panel"">
                                        <div class=""panel-body"">
                                            <div class=""bio-chart"">
                                                <div style=""display:inline;width:100px;height:100px;""><canvas width=""100"" height=""100px""></canvas><input class=""knob"" data-width=""100"" data-height=""100"" data-displayprevious=""true"" data-thickness="".2"" value=""75"" data-fgcolor=""#96be4b"" data-bgcolor=""#e8e8e8"" style=""width: 54px; height: 33px; position: absolute; vertical-align: middle; margin-top: 33px; margin-left: -77px; border: 0px; font-weight: bold; font-style: normal; font-variant: norma");
            WriteLiteral(@"l; font-stretch: normal; font-size: 20px; line-height: normal; font-family: Arial; text-align: center; color: rgb(150, 190, 75); padding: 0px; -webkit-appearance: none; background: none;""></div>
                                            </div>
                                            <div class=""bio-desk"">
                                                <h4 class=""green"">VectorLab Portfolio</h4>
                                                <p>Started : 15 July</p>
                                                <p>Deadline : 15 August</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""panel"">
                                        <div class=""panel-body"">
                                            <div class=""bio-chart"">
                                 ");
            WriteLiteral(@"               <div style=""display:inline;width:100px;height:100px;""><canvas width=""100"" height=""100px""></canvas><input class=""knob"" data-width=""100"" data-height=""100"" data-displayprevious=""true"" data-thickness="".2"" value=""50"" data-fgcolor=""#cba4db"" data-bgcolor=""#e8e8e8"" style=""width: 54px; height: 33px; position: absolute; vertical-align: middle; margin-top: 33px; margin-left: -77px; border: 0px; font-weight: bold; font-style: normal; font-variant: normal; font-stretch: normal; font-size: 20px; line-height: normal; font-family: Arial; text-align: center; color: rgb(203, 164, 219); padding: 0px; -webkit-appearance: none; background: none;""></div>
                                            </div>
                                            <div class=""bio-desk"">
                                                <h4 class=""purple"">Adobe Muse Template</h4>
                                                <p>Started : 15 July</p>
                                                <p>Deadline : 15 August</p>
   ");
            WriteLiteral(@"                                         </div>
                                        </div>
                                    </div>
                                </div>

                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JShope.Pages.Admin.Users.UserProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Users.UserProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Users.UserProfileModel>)PageContext?.ViewData;
        public JShope.Pages.Admin.Users.UserProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
