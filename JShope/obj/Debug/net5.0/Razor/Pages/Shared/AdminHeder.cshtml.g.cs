#pragma checksum "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57100080ab0a5598e07c1c01e89c255ac7cab2f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_AdminHeder), @"mvc.1.0.view", @"/Pages/Shared/AdminHeder.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
using JShope.Services.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57100080ab0a5598e07c1c01e89c255ac7cab2f7", @"/Pages/Shared/AdminHeder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f855f6f6017778797de42ec5b97d57edda094e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_AdminHeder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
  
    var newOrdersCount = _siteService.GetNumberOfNewOrders();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57100080ab0a5598e07c1c01e89c255ac7cab2f74433", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 336, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 373, "\"", 383, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <link rel=""icon"" href=""/images/favicon.ico"">

    <script src=""https://code.jquery.com/jquery-1.10.2.js""></script>
    <script src=""https://code.jquery.com/ui/1.10.4/jquery-ui.js""></script>
    <link rel=""stylesheet"" href=""/assets/vendor_components/bootstrap/dist/css/bootstrap.css"">

    <!-- Bootstrap extend-->
    <link rel=""stylesheet"" href=""/css/bootstrap-extend.css"">
    <link href=""//db.onlinewebfonts.com/c/235b71a9b409e684e865eb4a996e925e?family=IRANYekan"" rel=""stylesheet"" type=""text/css"" />

    <!-- theme style -->
    <link rel=""stylesheet"" href=""/css/master_style.css"">

    <!-- Superieur Admin skins -->
    <link rel=""stylesheet"" href=""/css/skins/_all-skins.css"">

    <!-- daterange picker -->
    <link rel=""stylesheet"" href=""/assets/vendor_components/bootstrap-daterangepicker/daterangepicker.css"">

    <!-- Morris charts -->
    <link rel=""stylesheet"" href=""/assets/vendor_components/morris.js/morris.css"">

    <!-- Data Table-->
    <link rel=""stylesheet"" type=""text/");
                WriteLiteral("css\" href=\"/assets/vendor_components/datatable/datatables.min.css\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<header class=""main-header"">
    <!-- Logo -->
    <a href=""index.html"" class=""logo"">
        <!-- mini logo -->
        <div class=""logo-mini"">
            <span class=""light-logo""><img src=""/images/logo-light.png"" alt=""logo""></span>
            <span class=""dark-logo""><img src=""/images/logo-dark.png"" alt=""logo""></span>
        </div>
        <!-- logo-->
        <div class=""logo-lg"">
            <span class=""light-logo""><img src=""/images/logo-light-text.png"" alt=""logo""></span>
            <span class=""dark-logo""><img src=""/images/logo-dark-text.png"" alt=""logo""></span>
        </div>
    </a>
    <!-- Header Navbar -->
    <nav class=""navbar navbar-static-top"">
        <!-- Sidebar toggle button-->
        <div>
            <a href=""#"" class=""sidebar-toggle"" data-toggle=""push-menu"" role=""button"">
                <span class=""sr-only"">Toggle navigation</span>
            </a>
        </div>
        <div class=""navbar-custom-menu"">
            <ul class=""nav navbar-nav"">

           ");
            WriteLiteral("     <li class=\"search-box\">\r\n                    <a class=\"nav-link hidden-sm-down\" href=\"javascript:void(0)\"><i class=\"mdi mdi-magnify\"></i></a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57100080ab0a5598e07c1c01e89c255ac7cab2f78411", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Search &amp; enter\"> <a class=\"srh-btn\"><i class=\"ti-close\"></i></a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                </li>
                <!-- User Account-->
                <li class=""dropdown user user-menu"">
                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                        <img src=""/images/avatar/7.jpg"" class=""user-image rounded-circle"" alt=""User Image"">
                    </a>
                    <ul class=""dropdown-menu animated flipInY"">
                        <!-- User image -->
                        <li class=""user-header bg-img"" style=""background-image: url(/images/user-info.jpg)"" data-overlay=""3"">
                            <div class=""flexbox align-self-center"">
                                <img src=""/images/avatar/7.jpg"" class=""float-left rounded-circle"" alt=""User Image"">
                                <h4 class=""user-name align-self-center"">
                                    <span>Samuel Brus</span>
                                    <small>samuel@gmail.com</small>
                                </h4>
                        ");
            WriteLiteral(@"    </div>
                        </li>
                        <!-- Menu Body -->
                        <li class=""user-body"">
                            <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ion ion-person""></i> My Profile</a>
                            <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ion ion-bag""></i> My Balance</a>
                            <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ion ion-email-unread""></i> Inbox</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ion ion-settings""></i> Account Setting</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ion-log-out""></i> Logout</a>
                            <div class=""dropdown-divider""></div>
                            <div class=""p-10""><a href=""javascri");
            WriteLiteral(@"pt:void(0)"" class=""btn btn-sm btn-rounded btn-success"">View Profile</a></div>
                        </li>
                    </ul>
                </li>

                <!-- Messages -->
                <li class=""dropdown messages-menu"">
                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                        <i class=""mdi mdi-email""></i>
                    </a>
                    <ul class=""dropdown-menu animated fadeInDown"">

                        <li class=""header"">
                            <div class=""bg-img text-white p-20"" style=""background-image: url(/images/user-info.jpg)"" data-overlay=""5"">
                                <div class=""flexbox"">
                                    <div>
                                        <h3 class=""mb-0 mt-0"">5 New</h3>
                                        <span class=""font-light"">Messages</span>
                                    </div>
                                    <div class=""font-size-40"">");
            WriteLiteral(@"
                                        <i class=""mdi mdi-email-alert""></i>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li>
                            <!-- inner menu: contains the actual data -->
                            <ul class=""menu sm-scrol"">
                                <li>
                                    <!-- start message -->
                                    <a href=""#"">
                                        <div class=""pull-left"">
                                            <img src=""/images/user2-160x160.jpg"" class=""rounded-circle"" alt=""User Image"">
                                        </div>
                                        <div class=""mail-contnet"">
                                            <h4>
                                                Lorem Ipsum
                                                <small><i class=""fa fa-");
            WriteLiteral(@"clock-o""></i> 15 mins</small>
                                            </h4>
                                            <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</span>
                                        </div>
                                    </a>
                                </li>
                                <!-- end message -->
                                <li>
                                    <a href=""#"">
                                        <div class=""pull-left"">
                                            <img src=""/images/user3-128x128.jpg"" class=""rounded-circle"" alt=""User Image"">
                                        </div>
                                        <div class=""mail-contnet"">
                                            <h4>
                                                Nullam tempor
                                                <small><i class=""fa fa-clock-o""></i> 4 hours</small>
                                     ");
            WriteLiteral(@"       </h4>
                                            <span>Curabitur facilisis erat quis metus congue viverra.</span>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <div class=""pull-left"">
                                            <img src=""/images/user4-128x128.jpg"" class=""rounded-circle"" alt=""User Image"">
                                        </div>
                                        <div class=""mail-contnet"">
                                            <h4>
                                                Proin venenatis
                                                <small><i class=""fa fa-clock-o""></i> Today</small>
                                            </h4>
                                            <span>Vestibulum nec ligula nec quam sodales rutrum sed luctus.</span");
            WriteLiteral(@">
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        <div class=""pull-left"">
                                            <img src=""/images/user3-128x128.jpg"" class=""rounded-circle"" alt=""User Image"">
                                        </div>
                                        <div class=""mail-contnet"">
                                            <h4>
                                                Praesent suscipit
                                                <small><i class=""fa fa-clock-o""></i> Yesterday</small>
                                            </h4>
                                            <span>Curabitur quis risus aliquet, luctus arcu nec, venenatis neque.</span>
                                        </div>
                                    </a>
                ");
            WriteLiteral(@"                </li>
                                <li>
                                    <a href=""#"">
                                        <div class=""pull-left"">
                                            <img src=""/images/user4-128x128.jpg"" class=""rounded-circle"" alt=""User Image"">
                                        </div>
                                        <div class=""mail-contnet"">
                                            <h4>
                                                Donec tempor
                                                <small><i class=""fa fa-clock-o""></i> 2 days</small>
                                            </h4>
                                            <span>Praesent vitae tellus eget nibh lacinia pretium.</span>
                                        </div>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class=""footer"">");
            WriteLiteral("\r\n                            <a href=\"#\" class=\"text-white bg-info\">See all e-Mails</a>\r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n                <!-- Notifications -->\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 11326, "\"", 11389, 2);
            WriteAttributeValue("", 11334, "dropdown", 11334, 8, true);
#nullable restore
#line 203 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
WriteAttributeValue(" ", 11342, (newOrdersCount!=0)?"notifications-menu":"", 11343, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                        <i class=""mdi mdi-bell""></i>
                    </a>
                    <ul class=""dropdown-menu animated fadeInDown"">

                        <li class=""header"">
                            <div class=""bg-img text-white p-20"" style=""background-image: url(/images/user-info.jpg)"" data-overlay=""5"">
                                <div class=""flexbox"">
                                    <div>
                                        <h3 class=""mb-0 mt-0"">?????????????????</h3>
                                        <span class=""font-light"">Notifications</span>
                                    </div>
                                    <div class=""font-size-40"">
                                        <i class=""mdi mdi-message-alert""></i>
                                    </div>
                                </div>
                            </div>
                        </li>

       ");
            WriteLiteral("                 <li>\r\n                            <!-- inner menu: contains the actual data -->\r\n                            <ul class=\"menu ace_scroller\">\r\n");
#nullable restore
#line 226 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
                                 if (newOrdersCount != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a href=\"/admin/orders\">\r\n                                            <i class=\"fa fa-shopping-cart text-success\"></i>  ");
#nullable restore
#line 230 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
                                                                                         Write(newOrdersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ?????????? ????????\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 233 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li>
                                        <a href=""#"">
                                            <i ></i>  ?????????? ???????? ?????????? ????????
                                        </a>
                                    </li>
");
#nullable restore
#line 241 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Shared\AdminHeder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </li>
                        <li class=""footer""><a href=""#"" class=""text-white bg-danger""></a></li>
                    </ul>
                </li>
                <!-- Tasks-->
                <li class=""dropdown tasks-menu"">
                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                        <i class=""mdi mdi-bulletin-board""></i>
                    </a>
                    <ul class=""dropdown-menu animated fadeInDown"">

                        <li class=""header"">
                            <div class=""bg-img text-white p-20"" style=""background-image: url(/images/user-info.jpg)"" data-overlay=""5"">
                                <div class=""flexbox"">
                                    <div>
                                        <h3 class=""mb-0 mt-0"">6 New</h3>
                                        <span class=""font-light"">Tasks</span>
                                    </div>
             ");
            WriteLiteral(@"                       <div class=""font-size-40"">
                                        <i class=""mdi mdi-bulletin-board""></i>
                                    </div>
                                </div>
                            </div>
                        </li>

                        <li>
                            <!-- inner menu: contains the actual data -->
                            <ul class=""menu sm-scrol"">
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Lorem ipsum dolor sit amet
                                            <small class=""pull-right"">30%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-danger"" style=""width: 30%"" role=""progr");
            WriteLiteral(@"essbar""
                                                 aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">30% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Vestibulum nec ligula
                                            <small class=""pull-right"">20%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-info"" style=""width: 20%"" role=""progressbar""");
            WriteLiteral(@"
                                                 aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">20% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Donec id leo ut ipsum
                                            <small class=""pull-right"">70%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-success"" style=""width: 70%"" role=""progressbar""
  ");
            WriteLiteral(@"                                               aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">70% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Praesent vitae tellus
                                            <small class=""pull-right"">40%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-warning"" style=""width: 40%"" role=""progressbar""
      ");
            WriteLiteral(@"                                           aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">40% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Nam varius sapien
                                            <small class=""pull-right"">80%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-primary"" style=""width: 80%"" role=""progressbar""
              ");
            WriteLiteral(@"                                   aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">80% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                                <li>
                                    <!-- Task item -->
                                    <a href=""#"">
                                        <h3>
                                            Nunc fringilla
                                            <small class=""pull-right"">90%</small>
                                        </h3>
                                        <div class=""progress xs"">
                                            <div class=""progress-bar progress-bar-info"" style=""width: 90%"" role=""progressbar""
                            ");
            WriteLiteral(@"                     aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                <span class=""sr-only"">90% Complete</span>
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <!-- end task item -->
                            </ul>
                        </li>
                        <li class=""footer""><a href=""#"" class=""text-white bg-warning"">View all tasks</a></li>
                    </ul>
                </li>


            </ul>
        </div>
    </nav>

</header>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISiteService _siteService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
