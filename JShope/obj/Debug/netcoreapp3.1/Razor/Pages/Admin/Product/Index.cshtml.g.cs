#pragma checksum "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Product_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Product/Index.cshtml")]
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
#line 3 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
using JShope.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{subGroupId?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea", @"/Pages/Admin/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f855f6f6017778797de42ec5b97d57edda094e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Product_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n\r\n\r\n<div class=\"wrapper\">\r\n\r\n    <div class=\"content-wrapper\">\r\n\r\n        <div class=\"box-body\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea4795", async() => {
                WriteLiteral(@"

                <div style=""display: flex"">

                    <div>


                        <input id=""input1"" class=""form-control mr-sm-2"" name=""search"" type=""search"" placeholder=""Search"" aria-label=""Search"">



                    </div>

                    <div>
                        <a id=""btn1"" class=""btn btn-outline-success my-2 my-sm-0"">جستجو</a>
                        <a ");
                WriteLiteral(@" id=""clearField1"" class=""btn btn-info-outline my-2 my-sm-0"">پاک کردن</a>


                    </div>
                    <div style=""margin-right: 10%;display: flex"">
                        <a class=""btn btn-dribbble"" href=""/admin/product/categories/addcategory"">مدیریت دسته بندی‌ها  </a>

                       

                    </div>
                
                </div>

                <div>
                    <div class=""col-md-2"">


                        
                           
                                <div>
                                    <label for=""test"">دسته بندی: </label>
                                    <select  class=""form-control"" onchange=""jm()"" id=""test"" name=""catId"">
                                      
                                        
                                        
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea6443", async() => {
                    WriteLiteral("همه");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 67 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                         foreach (var item in _productService.GetCategory())
                                        {





#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <");
                WriteLiteral("option ");
#nullable restore
#line 73 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                                 Write((Model.CategoryId==item.CategoryId)?"selected":"");

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 73 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                                                                                            Write(item.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                                ");
#nullable restore
#line 74 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                                            </");
                WriteLiteral("option>\r\n");
#nullable restore
#line 76 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"


                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </select>\r\n                                   \r\n                                </div>\r\n                          \r\n");
#nullable restore
#line 84 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                         if (Model.CategoryId != 0)
                        {
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div>
                                <label for=""test"">گروه ها: </label>
                                <select  class=""form-control"" onchange=""jm()"" id=""test"" name=""groupId"">
                                      
                                        
                                        
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea10031", async() => {
                    WriteLiteral("همه");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 96 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                     foreach (var item in _productService.GetGroupsByCategoryId(Model.CategoryId))
                                    {





#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <");
                WriteLiteral("option ");
#nullable restore
#line 102 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                             Write((Model.GroupId==item.GroupId)?"selected":"");

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 102 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                                                                                  Write(item.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                            ");
#nullable restore
#line 103 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                       Write(item.GroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </");
                WriteLiteral("option>\r\n");
#nullable restore
#line 105 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"


                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </select>\r\n                                   \r\n                            </div>\r\n");
#nullable restore
#line 112 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                             if (Model.GroupId != 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div>
                                    <label for=""test"">زیرگروه ها: </label>
                                    <select  class=""form-control"" onchange=""jm()"" id=""test"" name=""subGroupId"">
                                      
                                        
                                        
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd2a3cbf2e7b7d0401c84095217c7d19e5f8fdea13555", async() => {
                    WriteLiteral("همه");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 123 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                         foreach (var item in _productService.GetSubGroupsByGroupId(Model.GroupId))
                                        {





#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <");
                WriteLiteral("option ");
#nullable restore
#line 129 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                                 Write((Model.SubGroupId==item.SubGroupId)?"selected":"");

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 129 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                                                                                            Write(item.SubGroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                                ");
#nullable restore
#line 130 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                           Write(item.SubGroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </");
                WriteLiteral("option>\r\n");
#nullable restore
#line 132 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"


                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </select>\r\n                                   \r\n                                </div>\r\n");
#nullable restore
#line 139 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>


                </div>
                <div style=""margin-top: 2%"">

                        <a href=""/admin/product/addproduct"" class=""btn btn-outline btn-success""><i class=""fa fa fa-plus""></i> افزودن محصول</a>


                </div>
                <div style=""margin-top: 2%"">
                   
                    <div id=""t1"" class=""table-responsive"">
                        <table id=""tbl1"" class=""table product-overview"">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>نام</th>
                                    <th></th>
                                    <th>قیمت</th>
                                    <th>تعداد</th>
                                    <th></th>

                                </tr>
                            </thead>
                            <tbody>

");
#nullable restore
#line 168 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                 foreach (var item in Model.Product)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n\r\n                                        <td>\r\n\r\n");
#nullable restore
#line 174 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                             if (_productService.GetProductImage(item.ProductId).Count != 0)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <img");
                BeginWriteAttribute("src", " src=\"", 6006, "\"", 6090, 2);
                WriteAttributeValue("", 6012, "/images/product/", 6012, 16, true);
#nullable restore
#line 176 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
WriteAttributeValue("", 6028, _productService.GetProductImage(item.ProductId).First().Names, 6028, 62, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 6091, "\"", 6097, 0);
                EndWriteAttribute();
                WriteLiteral(" width=\"80\">\r\n");
#nullable restore
#line 177 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </td>\r\n                                        <td>");
#nullable restore
#line 179 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <h5>");
#nullable restore
#line 181 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n\r\n                                        </td>\r\n\r\n                                        <td width=\"150\">\r\n                                            <h5>");
#nullable restore
#line 187 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                        </td>\r\n\r\n                                        <td width=\"150\">\r\n                                            ");
#nullable restore
#line 191 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 6877, "\"", 6921, 2);
                WriteAttributeValue("", 6884, "/admin/product/delete/", 6884, 22, true);
#nullable restore
#line 195 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
WriteAttributeValue("", 6906, item.ProductId, 6906, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger-outline ti-trash \"></a>\r\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 7016, "\"", 7065, 2);
                WriteAttributeValue("", 7023, "/admin/product/editproduct/", 7023, 27, true);
#nullable restore
#line 196 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
WriteAttributeValue("", 7050, item.ProductId, 7050, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary-outline  \">ویرایش</a>\r\n                                        </td>\r\n\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 201 "C:\Users\mohammad\source\repos\JShope\JShope\Pages\Admin\Product\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

    </div>
</div>
<script>

    function jm() {
       
      
        $(""#frm1"").submit();

    }

    $(document).ready(function () {
     
        $(""#clearField1"").hide();
        $(""#input1"").keyup(function (e) {
            console.log('1');
           if ($(this).val() !== null) {
              
               $(""#clearField1"").show();
               console.log('2');
            }
            if (e.keyCode == 8 && $(""#input1"").val()=="""") {
               
                    $(""#clearField1"").hide();
                
               
               
            }
        });

        $(""#clearField1"").click(function () {
            $(""#input1"").val("""");
            $(""#clearField1"").hide();
        });


    });
   
            //document.getElementById('group1').disable =true ;
            //function dropdown(id) {



            //    document.getElementById('group1').disable = false;

            //    var as = document.createElement(");
            WriteLiteral(@"'<a>hi</a>');
            //    document.getElementById('group2').innerHTML = as;

            //}
            //function showCustomer(str) {
            //    var a = 2;
            //    if (str == """") {
            //        document.getElementById(""txtHint"").innerHTML = """";
            //        return;
            //    }
            //    const xhttp = new XMLHttpRequest();
            //    xhttp.onload = function () {
            //        document.getElementById(""txtHint"").innerHTML = this.responseText;
            //    }
            //    xhttp.open(""Get"", ""/admin/product/"");
            //    xhttp.send();
            //}

            //$(""#input1"").keyup(function () {
            //    var search = $(""#input1"").val();

            //    $.get(""/admin/product""+search);
            //});

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductService _productService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JShope.Pages.Admin.Product.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Product.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<JShope.Pages.Admin.Product.IndexModel>)PageContext?.ViewData;
        public JShope.Pages.Admin.Product.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591