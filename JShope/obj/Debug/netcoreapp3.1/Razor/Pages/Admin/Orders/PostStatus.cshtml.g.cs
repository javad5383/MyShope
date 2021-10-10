#pragma checksum "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1901006fa3d46f1203ddba68364394cc67308cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Orders_PostStatus), @"mvc.1.0.razor-page", @"/Pages/Admin/Orders/PostStatus.cshtml")]
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
#line 2 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
using JShope.Services.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1901006fa3d46f1203ddba68364394cc67308cb", @"/Pages/Admin/Orders/PostStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f855f6f6017778797de42ec5b97d57edda094e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Orders_PostStatus : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
  
    var quantity = Model.Order.Cart.CartDetails.Select(q => q.Quantity).Sum();
    var totalPrice = Model.Order.Cart.TotalPrice.ToString("##,###");
    var cart = Model.Order.Cart;
    var user = Model.Order.Cart.User;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""wrapper"" style=""height: auto; min-height: 100%;"">
    <div class=""content-wrapper"" style=""min-height: 591px;"">
        <!-- Content Header (Page header) -->
        <div class=""content-header"">
            <div class=""d-flex align-items-center"">
                <div class=""mr-auto"">
                    <h3 class=""page-title"">Checkout</h3>
                    <div class=""d-inline-block align-items-center"">
                        <nav>
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""#""><i class=""mdi mdi-home-outline""></i></a></li>
                                <li class=""breadcrumb-item"" aria-current=""page"">e-Commerce</li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Checkout</li>
                            </ol>
                        </nav>
                    </div>
                </div>
            </div>
        </div>

        <section class=""content""");
            WriteLiteral(@">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""box"">
                        <div class=""box-header"">
                            <h4 class=""box-title"">Product Summary</h4>
                        </div>
                        <div class=""box-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>تصویر نمایه</th>
                                            <th>نام خریدار</th>
                                            <th class=""w-300"">آدرس ایمیل</th>
                                            <th class=""w-200"">شماره همراه</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
              ");
            WriteLiteral("                             \r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 2451, "\"", 2502, 2);
            WriteAttributeValue("", 2458, "/admin/users/userProfile/", 2458, 25, true);
#nullable restore
#line 54 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 2483, Model.Order.UserId, 2483, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 2508, "\"", 2562, 2);
            WriteAttributeValue("", 2514, "/images/avatar/", 2514, 15, true);
#nullable restore
#line 54 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 2529, Model.Order.Cart.User.UserAvatar, 2529, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"آواتار\" width=\"80\"> </a></td>\r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 2651, "\"", 2702, 2);
            WriteAttributeValue("", 2658, "/admin/users/userProfile/", 2658, 25, true);
#nullable restore
#line 55 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 2683, Model.Order.UserId, 2683, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                                                   Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 2777, "\"", 2828, 2);
            WriteAttributeValue("", 2784, "/admin/users/userProfile/", 2784, 25, true);
#nullable restore
#line 56 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 2809, Model.Order.UserId, 2809, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                                                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                                            <td> <a");
            BeginWriteAttribute("href", " href=\"", 2904, "\"", 2955, 2);
            WriteAttributeValue("", 2911, "/admin/users/userProfile/", 2911, 25, true);
#nullable restore
#line 57 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 2936, Model.Order.UserId, 2936, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                                                   Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </a></td>
                                           
                                        </tr>


                                    </tbody>
                                </table>
                            </div>
                            <table class=""table table-bordered"">
                                <thead>

                                    <p style=""background-color: #f5f6fa"" class=""font-size-24"">اطلاعات پرداخت</p>

                                </thead>
                                <tbody>
                                    <tr>
                                        <th colspan=""3"" class=""text-right"">تعداد آیتم‌های خریداری شده</th>
                                        <th class=""text-left"">");
#nullable restore
#line 74 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                         Write(quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"" align=""right"">کد تخفیف</td>
                                        <td class=""text-left"">----</td>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"" align=""right"">هزینه پستی</td>
                                        <td class=""text-left"">----</td>
                                    </tr>
                                    <tr>
                                        <td colspan=""3"" align=""right""> قیمت محصولات خریداری شده </td>
                                        <td class=""text-left"">");
#nullable restore
#line 86 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                         Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <th colspan=\"3\" class=\"text-right\">کد رهگیری پرداخت</th>\r\n                                        <th class=\"text-left\">");
#nullable restore
#line 90 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                         Write(Model.Order.PaymentAuthority);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    </tr>
                                    <tr>
                                        <th colspan=""3"" class=""text-right font-size-24"">خالص پرداختی</th>

                                        <th class=""font-size-24 text-left"">");
#nullable restore
#line 95 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                      Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    </tr>\r\n\r\n                                    <tr>\r\n                                        <th colspan=\"3\" class=\"text-right\">وضعیت ارسال</th>\r\n");
#nullable restore
#line 100 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                         if (Model.Order.IsDelivered)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th class=\"text-success text-left\">ارسال شد</th>\r\n");
#nullable restore
#line 103 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th class=\"text-warning text-left\">در انتظار ارسال </th>\r\n");
#nullable restore
#line 107 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n                                    <tr>\r\n                                        <th colspan=\"3\" class=\"text-right\">کد رهگیری پستی</th>\r\n");
#nullable restore
#line 111 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                         if (Model.Order.IsDelivered)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th class=\"text-left text-success\">");
#nullable restore
#line 113 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                          Write(Model.Order.PostalTrackingCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 114 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th class=\"text-warning\">-------</th>\r\n");
#nullable restore
#line 118 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n                                    <tr>\r\n                                        <th colspan=\"3\" class=\"text-right\">آدرس پستی</th>\r\n                                        <th class=\"text-left\">");
#nullable restore
#line 122 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                         Write(Model.Order.Cart.User.UserHomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                    </tr>
                                    <tr>
                                        <th colspan=""3"" class=""text-right"">کد پستی</th>
                                        <th class=""text-left""><h1 class=""text-danger"">TODO</h1></th>
                                    </tr>
                                </tbody>
                            </table>


                        </div>
                    </div>
                </div>
                <hr />
            </div>
");
#nullable restore
#line 137 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
             if (!Model.Order.IsDelivered)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1901006fa3d46f1203ddba68364394cc67308cb17236", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""box"">
                                <div class=""product-text"">
                                    <p style=""margin-right: 3%"">  در صورت ارسال کالا، کد رهگیری مرسوله را وارد کرده سپس کلید ""ثبت ""را بزنید.</p>
                                </div>

                                <div style=""width: 50%; margin: 3%; margin-top: 1%"" class=""input-group"">
                                    <input placeholder=""کد رهگیری پست"" name=""postalTrackingCode"" type=""text"" class=""form-control"">
                                    <div style=""display: flex"">
                                        <div class=""input-group-prepend"">
                                            <button type=""submit"" data-toggle=""tooltip"" data-original-title=""تائید ارسال"" onclick=""return confirm('تائید می‌کنید که سفارش ارسال شد؟')"" class=""btn btn-success"">ثبت</button>
                                        </d");
                WriteLiteral(@"iv>
                                        <div style=""margin-right: 1%"" class=""input-group-prepend"">
                                            <a href=""/admin/orders"" data-toggle=""tooltip"" data-original-title=""بازگشت"" class=""btn btn-danger"">بازگشت</a>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <h2 class=\"box-title mb-15\">آیتم‌های سبد خرید</h2>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 167 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                 foreach (var item in cart.CartDetails)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-lg-6 col-xl-3\">\r\n                        <div style=\"position: relative\" class=\"box\">\r\n");
#nullable restore
#line 171 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                             if (item.SelectedProductColor!=0)
                            {
                                var productColor = @item.Product.ProductColors.FirstOrDefault(p => p.ColorId == item.SelectedProductColor);
                                if (productColor!=null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span data-toggle=\"tooltip\" data-original-title=\" رنگ درخواستی ");
#nullable restore
#line 176 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                                               Write(productColor.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("style", " style=\"", 9619, "\"", 9739, 13);
            WriteAttributeValue("", 9627, "position:", 9627, 9, true);
            WriteAttributeValue(" ", 9636, "absolute;", 9637, 10, true);
            WriteAttributeValue(" ", 9646, "right:", 9647, 7, true);
            WriteAttributeValue(" ", 9653, "15px;", 9654, 6, true);
            WriteAttributeValue(" ", 9659, "top:", 9660, 5, true);
            WriteAttributeValue(" ", 9664, "30px;", 9665, 6, true);
            WriteAttributeValue(" ", 9670, "width:", 9671, 7, true);
            WriteAttributeValue(" ", 9677, "10px;", 9678, 6, true);
            WriteAttributeValue(" ", 9683, "height:", 9684, 8, true);
            WriteAttributeValue(" ", 9691, "10px;", 9692, 6, true);
            WriteAttributeValue(" ", 9697, "background-color:", 9698, 18, true);
#nullable restore
#line 176 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 9715, productColor.ColorCode, 9715, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 9738, "", 9739, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"avatar avatar-sm border border-gray \"></span>\r\n");
#nullable restore
#line 177 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"box-body\">\r\n                                <div class=\"product-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 10012, "\"", 10090, 2);
            WriteAttributeValue("", 10018, "/images/product/", 10018, 16, true);
#nullable restore
#line 181 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
WriteAttributeValue("", 10034, item.Product.ProductImages.Select(n => n.Names).First(), 10034, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10091, "\"", 10097, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""product-text"">
                                    <div class=""pro-img-overlay"">
                                        <a href=""javascript:void(0)"" class=""btn btn-info btn-icon-circle""><i class=""mdi mdi-settings""></i></a>
                                        <a href=""javascript:void(0)"" class=""btn btn-danger btn-icon-circle""><i class=""mdi mdi-delete""></i></a>
                                    </div>
                                    <h5 class=""pro-price text-blue"">");
#nullable restore
#line 188 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                               Write(item.Product.Price.ToString("##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h3 class=\"box-title mb-0\" style=\"margin-top: 15%\">");
#nullable restore
#line 189 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"
                                                                                  Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 196 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Orders\PostStatus.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JShope.Pages.Admin.Orders.PostStatusModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Orders.PostStatusModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Orders.PostStatusModel>)PageContext?.ViewData;
        public JShope.Pages.Admin.Orders.PostStatusModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
