#pragma checksum "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67bff88b77eaaee7f54a554794a53258e38f52e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuKT_GetAllPhieuKTTheoBN), @"mvc.1.0.view", @"/Views/PhieuKT/GetAllPhieuKTTheoBN.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67bff88b77eaaee7f54a554794a53258e38f52e4", @"/Views/PhieuKT/GetAllPhieuKTTheoBN.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49fd5f9796c00f635b9ef95bc5ab8074734f09da", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuKT_GetAllPhieuKTTheoBN : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBenhNhan_bigdata.Models.PhieuKT>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
  
    ViewData["Title"] = "GetAllPhieuKTTheoBN";
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Danh sách kiểm tra sức khỏe của bệnh nhân</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67bff88b77eaaee7f54a554794a53258e38f52e44029", async() => {
                WriteLiteral("Thêm mới");
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
#line 11 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                STT\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayNameFor(model => model.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayNameFor(model => model.Predict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayNameFor(model => model.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
            Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n");
#nullable restore
#line 45 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
             if(item.Predict == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Có \r\n                </td>\r\n");
#nullable restore
#line 50 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
                }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    Không\r\n                </td>\r\n");
#nullable restore
#line 55 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayFor(modelItem => item.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.ActionLink("Cập nhật", "Edit", new { _id=item._id,MaBN=item.MaBN }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 65 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.ActionLink("Chi tiết", "Details", new { _id = item._id, MaBN = item.MaBN }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 66 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
           Write(Html.ActionLink("Xóa", "Delete", new { _id = item._id, MaBN = item.MaBN }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\GetAllPhieuKTTheoBN.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n</table>\r\n<a href=\"/BenhNhan\">Danh sách bệnh nhân</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyBenhNhan_bigdata.Models.PhieuKT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
