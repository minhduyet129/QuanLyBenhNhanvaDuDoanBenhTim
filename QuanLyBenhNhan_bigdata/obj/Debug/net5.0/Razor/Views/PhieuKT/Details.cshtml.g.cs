#pragma checksum "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bdb098adff05530f7f54c96f718771bf37216c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuKT_Details), @"mvc.1.0.view", @"/Views/PhieuKT/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bdb098adff05530f7f54c96f718771bf37216c", @"/Views/PhieuKT/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49fd5f9796c00f635b9ef95bc5ab8074734f09da", @"/Views/_ViewImports.cshtml")]
    public class Views_PhieuKT_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyBenhNhan_bigdata.Models.PhieuKT>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllPhieuKTTheoBN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết phiếu kiểm tra sức khỏe</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 15 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 18 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 21 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 24 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaPhieu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 27 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 30 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 33 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 35 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.Sex == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-8\">\r\n                Nam\r\n            </dd>\r\n");
#nullable restore
#line 40 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Nữ\r\n        </dd>\r\n");
#nullable restore
#line 44 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 49 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.Cp == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-8\">\r\n                Đau thắt ngực thường gặp\r\n            </dd>\r\n");
#nullable restore
#line 54 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else if(Model.Cp == 2){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Đau thắt ngực không thường gặp\r\n        </dd>\r\n");
#nullable restore
#line 58 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }
        else if(Model.Cp == 3){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Không đau thắt ngực\r\n        </dd>\r\n");
#nullable restore
#line 63 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Không có triệu chứng\r\n        </dd>\r\n");
#nullable restore
#line 67 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 70 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrestBps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 73 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrestBps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 76 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Chol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 79 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Chol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 82 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fbs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 85 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fbs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 88 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RestEcg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 90 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.RestEcg == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-8\">\r\n                Bình thường\r\n            </dd>\r\n");
#nullable restore
#line 95 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else if(Model.Cp == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Có bất thường sóng ST-T (đảo ngược sóng T và / hoặc ST chênh lên hoặc xuống> 0,05 mV)\r\n        </dd>\r\n");
#nullable restore
#line 99 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"

        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Phì đại thất trái có thể xảy ra\r\n        </dd>\r\n");
#nullable restore
#line 104 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 106 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 109 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thalac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 112 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Exang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 114 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.Exang == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-8\">\r\n                Không\r\n            </dd>\r\n");
#nullable restore
#line 119 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"

        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Có\r\n        </dd>\r\n");
#nullable restore
#line 124 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 126 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OldPeak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 129 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.OldPeak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 132 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Slope));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 134 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.Slope == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd class=\"col-sm-8\">\r\n        Tăng lên\r\n    </dd>\r\n");
#nullable restore
#line 139 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else if(Model.Slope == 2){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd class=\"col-sm-8\">\r\n        Bằng phẳng\r\n    </dd>\r\n");
#nullable restore
#line 143 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"

        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd class=\"col-sm-8\">\r\n        Dốc xuống\r\n    </dd>\r\n");
#nullable restore
#line 148 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 150 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 153 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 156 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 158 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if (Model.Thal == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-8\">\r\n                Bình thường\r\n            </dd>\r\n");
#nullable restore
#line 163 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }else if(Model.Thal == 6){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Nặng\r\n        </dd>\r\n");
#nullable restore
#line 167 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"

        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-8\">\r\n            Nhẹ\r\n        </dd>\r\n");
#nullable restore
#line 172 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 174 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Predict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n");
#nullable restore
#line 176 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
         if(Model.Predict==false){



#line default
#line hidden
#nullable disable
            WriteLiteral("<dd class=\"col-sm-8\">\r\n                Không\r\n            </dd>\r\n");
#nullable restore
#line 182 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dd class=\"col-sm-8\">\r\n        Có\r\n    </dd>\r\n");
#nullable restore
#line 188 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 190 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 193 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.Probability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 196 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-8\">\r\n            ");
#nullable restore
#line 199 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 204 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
Write(Html.ActionLink("Cập nhật", "Edit", new { _id = Model._id, MaBN = Model.MaBN }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23bdb098adff05530f7f54c96f718771bf37216c23339", async() => {
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
#line 205 "C:\Users\This PC\Desktop\Nhap môn dữ liệu lớn\BTL\QuanLyBenhNhan_bigdata\QuanLyBenhNhan_bigdata\Views\PhieuKT\Details.cshtml"
                                            WriteLiteral(Model.MaBN);

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
