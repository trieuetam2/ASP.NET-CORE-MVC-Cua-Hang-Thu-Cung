#pragma checksum "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94050243fe3ce1bb82fbee599481dcb698398ee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\_ViewImports.cshtml"
using qlthucung;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\_ViewImports.cshtml"
using qlthucung.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94050243fe3ce1bb82fbee599481dcb698398ee7", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef73639f6b3737e7259fad928485fe42d0b458a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<qlthucung.Models.SanPham>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/empty_cart.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("getinfo_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<div class=\"cart__body\">\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94050243fe3ce1bb82fbee599481dcb698398ee78275", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 cart__items-box\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94050243fe3ce1bb82fbee599481dcb698398ee78636", async() => {
                    WriteLiteral("Tiếp tục mua sắm");
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
                WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                 if (ViewBag.cart == null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"emptyCart\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94050243fe3ce1bb82fbee599481dcb698398ee710513", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 66 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"cart__items\">\r\n                        <div class=\"row\">\r\n");
#nullable restore
#line 71 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                             foreach (var item in ViewBag.cart)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-sm-3 col-5 mt-2\">\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 2503, "\"", 2527, 1);
#nullable restore
#line 74 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2509, item.Product.Hinh, 2509, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2528, "\"", 2534, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"cart__items-img\">\r\n                                </div>\r\n                                <div class=\"col-sm-9 col-7 mt-2\">\r\n                                    <h3>\r\n                                        ");
#nullable restore
#line 78 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                   Write(item.Product.Tensp);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h3>

                                    <br>
                                    <div class=""cart__items-pride"">
                                        <div class=""product__pride-newPride"">
                                            <span class=""Price"">
                                                <bdi>
                                                    ");
#nullable restore
#line 86 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                               Write(string.Format("{0:N0}", item.Product.Giakhuyenmai * item.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"&nbsp;
                                                    <span class=""currencySymbol"">₫</span>
                                                </bdi>
                                            </span>
                                        </div>

                                        <div class=""cart__items-count"">
                                            Số lượng
                                            ");
#nullable restore
#line 94 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </div>\r\n\r\n                                    </div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94050243fe3ce1bb82fbee599481dcb698398ee715114", async() => {
                    WriteLiteral("Xóa sản phẩm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                                                                                                 WriteLiteral(item.Product.Masp);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 100 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 105 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

            <div class=""col-lg-4"" style=""padding-left: 20px; padding-right: 10px;"">
                <div>
                    <div class=""cart__info"">
                        <div class=""body__mainTitle"">
                            <h2>ĐỊA CHỈ NHẬN HÀNG</h2>
                        </div>
                        <center>
                            <div class=""cart__info-form"">
");
#nullable restore
#line 118 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                 if (ViewBag.info != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                     foreach (var item in ViewBag.info)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"text\" placeholder=\"Họ và tên\" name=\"hoten\"");
                BeginWriteAttribute("value", " value=\"", 4821, "\"", 4843, 1);
#nullable restore
#line 122 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4829, item.FullName, 4829, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n                                        <input type=\"email\" placeholder=\"Email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 4943, "\"", 4962, 1);
#nullable restore
#line 123 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4951, item.Email, 4951, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"text\" placeholder=\"Số điện thoại\" name=\"sdt\"");
                BeginWriteAttribute("value", " value=\"", 5063, "\"", 5088, 1);
#nullable restore
#line 124 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5071, item.PhoneNumber, 5071, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"hidden\" name=\"ngaysinh\"");
                BeginWriteAttribute("value", " value=\"", 5168, "\"", 5191, 1);
#nullable restore
#line 125 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5176, item.BirthDate, 5176, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 126 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                     

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"text\" placeholder=\"Họ và tên\"><br>\r\n                                    <input type=\"email\" placeholder=\"Email\">\r\n                                    <input type=\"text\" placeholder=\"Số điện thoại\">\r\n");
#nullable restore
#line 134 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                <div class=\"address\">\r\n                                    <h6>Tỉnh / Thành Phố</h6>\r\n                                    <select name=\"calc_shipping_provinces\" required>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94050243fe3ce1bb82fbee599481dcb698398ee722754", async() => {
                    WriteLiteral("Tỉnh/Tp");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>

                                <div class=""address"">
                                    <h6>Quận / Huyện</h6>
                                    <select name=""calc_shipping_district"" required>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94050243fe3ce1bb82fbee599481dcb698398ee724310", async() => {
                    WriteLiteral("Quận/Huyện");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n\r\n                                <input class=\"billing_address_1\" name=\"tinh\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6455, "\"", 6463, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input class=\"billing_address_2\" name=\"xa\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6555, "\"", 6563, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                <div class=\"address\">\r\n                                    <h6>Số nhà: </h6>\r\n                                    <input type=\"text\" name=\"sonha\"");
                BeginWriteAttribute("id", " id=\"", 6746, "\"", 6751, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                        </center>

                        <br>
                        <br>
                        <div class=""body__mainTitle"">
                            <h2>PHƯƠNG THỨC THANH TOÁN</h2>
                        </div>

                        <div class=""phuongthuctt"">
                            <input type=""radio"" id=""op1"" name=""op1""");
                BeginWriteAttribute("required", " required=\"", 7197, "\"", 7208, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <label for=""op1"">Chuyển khoản</label>

                            <br>

                            <input type=""radio"" id=""op2"" name=""op1"">
                            <label for=""op2"">Trả tiền khi nhận hàng</label>
                        </div>

                        <div class=""total"">
                            <h5>Tổng thanh toán</h5>
                            <br>

                            <div class=""product__pride-newPride"" style=""font-size: 25px;"">
                                <span class=""Price"">
                                    <bdi>
");
#nullable restore
#line 184 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                         if (ViewBag.cart != null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                       Write(string.Format("{0:N0}", @ViewBag.total));

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "C:\Downloads\Thuc tap .NET\qlnvMVC_Core5\qlthucung\qlthucung\qlthucung\Views\Cart\Index.cshtml"
                                                                                    
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        &nbsp;
                                        <span class=""currencySymbol"">₫</span>
                                    </bdi>
                                </span>
                            </div>

                        </div>

                        <center><button class=""buy"" name=""order"" id=""order"" type=""submit"">Đặt hàng</button></center>

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>


<script src=""https://code.jquery.com/jquery-3.6.3.js""></script>
<script src=""https://cdn.jsdelivr.net/gh/vietblogdao/js/districts.min.js""></script>
<script>
    //chuyen khoan vnpay
    $('#op1').click(function () {
        $('#order').attr('name', 'ordervnpay');
        $('#getinfo_form').attr('action', '/shopthucung/index.php?page=vnpay_create_payment');

    });

    //cod
    $('#op2').click(function () {
        $('#order').attr('name', 'order');
        $('#getinfo_form').attr('action', '');
    });
</script>

<script>
    //<![CDATA[
    if (address_2 = localStorage.getItem('address_2_saved')) {
        $('select[name=""calc_shipping_district""] option').each(function () {
            if ($(this).text() == address_2) {
                $(this).attr('selected', '')
            }
        })
        $('input.billing_address_2').attr('value', address_2)
    }
    if (district = localStorage.getItem('district')) {
        $('select[name=""calc_shipping_district""]').html");
            WriteLiteral(@"(district)
        $('select[name=""calc_shipping_district""]').on('change', function () {
            var target = $(this).children('option:selected')
            target.attr('selected', '')
            $('select[name=""calc_shipping_district""] option').not(target).removeAttr('selected')
            address_2 = target.text()
            $('input.billing_address_2').attr('value', address_2)
            district = $('select[name=""calc_shipping_district""]').html()
            localStorage.setItem('district', district)
            localStorage.setItem('address_2_saved', address_2)
        })
    }
    $('select[name=""calc_shipping_provinces""]').each(function () {
        var $this = $(this),
            stc = ''
        c.forEach(function (i, e) {
            e += +1
            stc += '<option value=' + e + '>' + i + '</option>'
            $this.html('<option value="""">Tỉnh / Thành phố</option>' + stc)
            if (address_1 = localStorage.getItem('address_1_saved')) {
                $('sel");
            WriteLiteral(@"ect[name=""calc_shipping_provinces""] option').each(function () {
                    if ($(this).text() == address_1) {
                        $(this).attr('selected', '')
                    }
                })
                $('input.billing_address_1').attr('value', address_1)
            }
            $this.on('change', function (i) {
                i = $this.children('option:selected').index() - 1
                var str = '',
                    r = $this.val()
                if (r != '') {
                    arr[i].forEach(function (el) {
                        str += '<option value=""' + el + '"">' + el + '</option>'
                        $('select[name=""calc_shipping_district""]').html('<option value="""">Quận / Huyện</option>' + str)
                    })
                    var address_1 = $this.children('option:selected').text()
                    var district = $('select[name=""calc_shipping_district""]').html()
                    localStorage.setItem('address_1_saved', addr");
            WriteLiteral(@"ess_1)
                    localStorage.setItem('district', district)
                    $('select[name=""calc_shipping_district""]').on('change', function () {
                        var target = $(this).children('option:selected')
                        target.attr('selected', '')
                        $('select[name=""calc_shipping_district""] option').not(target).removeAttr('selected')
                        var address_2 = target.text()
                        $('input.billing_address_2').attr('value', address_2)
                        district = $('select[name=""calc_shipping_district""]').html()
                        localStorage.setItem('district', district)
                        localStorage.setItem('address_2_saved', address_2)
                    })
                } else {
                    $('select[name=""calc_shipping_district""]').html('<option value="""">Quận / Huyện</option>')
                    district = $('select[name=""calc_shipping_district""]').html()
                 ");
            WriteLiteral("   localStorage.setItem(\'district\', district)\r\n                    localStorage.removeItem(\'address_1_saved\', address_1)\r\n                }\r\n            })\r\n        })\r\n    })\r\n//]]></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<qlthucung.Models.SanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591