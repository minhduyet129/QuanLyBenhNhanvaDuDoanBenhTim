#pragma checksum "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e815db9ca439f62cd5da2d5548b5c1ff9bf07c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BenhNhan_Delete), @"mvc.1.0.view", @"/Views/BenhNhan/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e815db9ca439f62cd5da2d5548b5c1ff9bf07c79", @"/Views/BenhNhan/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49fd5f9796c00f635b9ef95bc5ab8074734f09da", @"/Views/_ViewImports.cshtml")]
    public class Views_BenhNhan_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBenhNhan_bigdata.Models.BenhNhan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Xóa</h1>\r\n\r\n<h3>Bạn có chắc chắn xóa bệnh nhân này không?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QueQuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.QueQuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e815db9ca439f62cd5da2d5548b5c1ff9bf07c798967", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"_id\"");
                BeginWriteAttribute("value", " value=\"", 1544, "\"", 1562, 1);
#nullable restore
#line 54 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\BenhNhan\Delete.cshtml"
WriteAttributeValue("", 1552, Model._id, 1552, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e815db9ca439f62cd5da2d5548b5c1ff9bf07c799781", async() => {
                    WriteLiteral("Quay lại danh sách bệnh nhân");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyBenhNhan_bigdata.Models.BenhNhan> Html { get; private set; }
    }
}
#pragma warning restore 1591