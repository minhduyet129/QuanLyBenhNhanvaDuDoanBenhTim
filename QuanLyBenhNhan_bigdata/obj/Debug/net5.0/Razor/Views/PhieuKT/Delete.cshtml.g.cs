#pragma checksum "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0a053f87a26d450f9c094969202749c604a652"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuKT_Delete), @"mvc.1.0.view", @"/Views/PhieuKT/Delete.cshtml")]
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
#line 1 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\_ViewImports.cshtml"
using QuanLyBenhNhan_bigdata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\_ViewImports.cshtml"
using QuanLyBenhNhan_bigdata.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0a053f87a26d450f9c094969202749c604a652", @"/Views/PhieuKT/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49fd5f9796c00f635b9ef95bc5ab8074734f09da", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuKT_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBenhNhan_bigdata.Models.PhieuKT>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllPhieuKTTheoBN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Xóa</h1>\r\n\r\n<h3>Bạn chắc chắn xóa phiếu kiểm tra này chứ?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Predict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Predict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0a053f87a26d450f9c094969202749c604a6529671", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"_id\"");
                BeginWriteAttribute("value", " value=\"", 1728, "\"", 1746, 1);
#nullable restore
#line 62 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
WriteAttributeValue("", 1736, Model._id, 1736, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"MaBN\"");
                BeginWriteAttribute("value", " value=\"", 1792, "\"", 1813, 1);
#nullable restore
#line 63 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
WriteAttributeValue("", 1800, ViewBag.MaBN, 1800, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0a053f87a26d450f9c094969202749c604a65210957", async() => {
                    WriteLiteral("Quay lại danh sách phiếu kiểm tra");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MaBN", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Delete.cshtml"
                                                WriteLiteral(ViewBag.MaBN);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaBN"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MaBN", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MaBN"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyBenhNhan_bigdata.Models.PhieuKT> Html { get; private set; }
    }
}
#pragma warning restore 1591
