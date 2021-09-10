#pragma checksum "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca92a04daaf99952e0770889cd14ede45a1c6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Verification), @"mvc.1.0.view", @"/Views/Cart/Verification.cshtml")]
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
#line 1 "C:\Users\mohammad\source\repos\JShope\JShope\Views\_ViewImports.cshtml"
using JShope;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohammad\source\repos\JShope\JShope\Views\_ViewImports.cshtml"
using JShope.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca92a04daaf99952e0770889cd14ede45a1c6a5", @"/Views/Cart/Verification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f855f6f6017778797de42ec5b97d57edda094e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Verification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
 if (ViewBag.isSuccess==true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""wrapper default shopping-page"">
        <!-- header-shopping -->
        <header class=""header-shopping default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 text-center pt-2"">
                        <div class=""header-shopping-logo default"">
                            <a href=""#"">
                                <img src=""assets/img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 483, "\"", 489, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                    </div>
                    <div class=""col-12 text-center"">
                        <ul class=""checkout-steps"">
                            <li>
                                <a href=""shopping.html"" class=""active"">
                                    <span>اطلاعات ارسال</span>
                                </a>
                            </li>
                            <li class=""active"">
                                <a href=""shopping-payment.html"" class=""active"">
                                    <span>پرداخت</span>
                                </a>
                            </li>
                            <li class=""active"">
                                <a href=""shopping-complete-buy.html"" class=""active"">
                                    <span>اتمام خرید و ارسال</span>
                                </a>
                            </li>
                        </ul>
        ");
            WriteLiteral(@"            </div>
                </div>
            </div>
        </header>
        <!-- header-shopping -->
        <!-- main-shopping -->
        <main class=""cart-page default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""cart-page-content col-12 order-1"">
                        <section class=""page-content default"">
                            <div class=""success-checkout text-center default"">
                                <div class=""icon-success"">
                                    <i class=""fa fa-check""></i>
                                </div>
                                <h1>سفارش <a href=""#"">");
#nullable restore
#line 49 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                 Write(Model.CartId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>با موفقیت در سیستم ثبت شد.</h1>
                                <p>سفارش نهایتا تا یک روز آماده ارسال خواهد شد.</p>
                            </div>
                            <div class=""order-info default"">
                                <h3>کد سفارش: <span>");
#nullable restore
#line 53 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                               Write(Model.CartId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h3>
                                <p>
                                    سفارش شما با موفقیت در سیستم ثبت شد و هم اکنون <span class=""badge badge-success"">تکمیل شده</span> است.جزئیات این سفارش را می توانید
                                    با کلیک بر روی دکمه <a href=""#"" class=""btn-link-border"">پیگیری سفارش</a>مشاهده نمایید.
                                </p>
                                <button type=""button"" class=""btn-primary"">
                                    پیگیری سفارش
                                </button>
                                <div class=""table-responsive default mt-3 mb-3"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">نام تحویل گیرنده : ");
#nullable restore
#line 65 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                              Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th scope=\"col\">شماره تماس : ");
#nullable restore
#line 66 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                        Write(Model.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <th scope=""row"">تعداد مرسوله : ");
#nullable restore
#line 71 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                          Write(Model.CartDetails.Select(q=>q.Quantity).Sum());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>مبلغ کل : ");
#nullable restore
#line 72 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                         Write(Model.TotalPrice.ToString("##,###"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            </tr>
                                            <tr>
                                                <th scope=""row"">وضعیت پرداخت : پرداخت آنلاین(موفق)</th>
                                                <td>کد رهگیری پرداخت: ");
#nullable restore
#line 76 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                  Write(int.Parse(ViewBag.authority));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n                                            <tr>\r\n                                                <th scope=\"row\">آدرس : ");
#nullable restore
#line 79 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                  Write(Model.User.UserHomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </main>

    </div>
");
#nullable restore
#line 92 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""wrapper default shopping-page"">
        <!-- header-shopping -->
        <header class=""header-shopping default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 text-center pt-2"">
                        <div class=""header-shopping-logo default"">
                            <a href=""#"">
                                <img src=""assets/img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 5277, "\"", 5283, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                        </div>
                    </div>
                    <div class=""col-12 text-center"">
                        <ul class=""checkout-steps"">
                            <li>
                                <a href=""shopping.html"" class=""active"">
                                    <span>اطلاعات ارسال</span>
                                </a>
                            </li>
                            <li class=""active"">
                                <a href=""shopping-payment.html"" class=""active"">
                                    <span>پرداخت</span>
                                </a>
                            </li>
                            <li class=""active"">
                                <a href=""shopping-complete-buy.html"" class=""active"">
                                    <span>اتمام خرید و ارسال</span>
                                </a>
                            </li>
                        </ul>
        ");
            WriteLiteral(@"            </div>
                </div>
            </div>
        </header>
        <!-- main-shopping -->
        <main class=""cart-page default"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""cart-page-content col-12 order-1"">
                        <section class=""page-content default"">
                            <div class=""warning-checkout text-center default"">
                                <div class=""icon-warning"">
                                    <i class=""fa fa-close""></i>
                                </div>
                                <h1>سفارش <a href=""#"">");
#nullable restore
#line 139 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                 Write(Model.CartId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>ثبت شد اما پرداخت ناموفق بود.</h1>
                                <p class=""text-warning"">برای جلوگیری از لغو سیستمی سفارش،تا 24 ساعت آینده پرداخت را انجام دهید.</p>
                                <p>چنانچه طی این فرایند مبلغی از حساب شما کسر شده است،طی 72 ساعت آینده به حساب شما باز خواهد گشت.</p>
                            </div>
                            <div class=""order-info default"">
                                <h3>کد سفارش: <span>");
#nullable restore
#line 144 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                               Write(Model.CartId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h3>
                                <p>
                                    سفارش شما با موفقیت در سیستم ثبت شد و هم اکنون <span class=""badge badge-warning"">در انتظار پرداخت</span> است.جزئیات این سفارش را می توانید
                                    با کلیک بر روی دکمه <a href=""#"" class=""btn-link-border"">پیگیری سفارش</a>مشاهده نمایید.
                                </p>
                                <button type=""button"" class=""btn-primary"">
                                    پیگیری سفارش
                                </button>
                                <div class=""table-responsive default mt-3 mb-3"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th scope=""col"">نام تحویل گیرنده : ");
#nullable restore
#line 156 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                              Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <th scope=\"col\">شماره تماس : ");
#nullable restore
#line 157 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                        Write(Model.User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <th scope=""row"">تعداد مرسوله : ");
#nullable restore
#line 162 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                                          Write(Model.CartDetails.Select(q=>q.Quantity).Sum());

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                <td>مبلغ کل : ");
#nullable restore
#line 163 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                         Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            </tr>
                                        <tr>
                                            <th scope=""row"">وضعیت پرداخت : پرداخت آنلاین(ناموفق)</th>
                                            <td>وضعیت سفارش: در انتظار پرداخت</td>
                                            <td>کد رهگیری سفارش: ");
#nullable restore
#line 168 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
                                                             Write(int.Parse(ViewBag.authority));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                     
                                            <tr>
                                                <th scope=""row"">آدرس : استان خراسان شمالی،بجنورد</th>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </div>
        </main>

    </div>
");
#nullable restore
#line 185 "C:\Users\mohammad\source\repos\JShope\JShope\Views\Cart\Verification.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
