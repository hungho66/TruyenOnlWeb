#pragma checksum "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/Book/statistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc278052802e721cefbc5e2534876a68415acbbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_statistic), @"mvc.1.0.view", @"/Views/Book/statistic.cshtml")]
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
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/_ViewImports.cshtml"
using TruyenOnl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/_ViewImports.cshtml"
using TruyenOnl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc278052802e721cefbc5e2534876a68415acbbc", @"/Views/Book/statistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b138006130c631d7f0e088f41b3890c6d7c0eb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_statistic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link btn btn-outline-dark m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/EditBook"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/ChapterList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/CreateChapter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Book/statistic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/apple/Downloads/IT_CNPM/C#/Web Developer C7/TeamWork/FullProject/TruyenOnl/TruyenOnl/Views/Book/statistic.cshtml"
  
    Layout = "~/Views/Shared/_LayoutBook.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"row bg-title\">\n        <div class=\"col-lg-3 col-md-4 col-sm-4 col-xs-12\">\n            <h4 class=\"page-title\"");
            BeginWriteAttribute("style", " style=\"", 210, "\"", 218, 0);
            EndWriteAttribute();
            WriteLiteral(">Quản Lý Truyện</h4>\n        </div>\n        <div class=\"col-lg-9 col-sm-8 col-md-8 col-xs-12\">\n            <ol class=\"breadcrumb\" style=\"background-color:rgb(252, 252, 252);\">\n                <li class=\"breadcrumb-item ml-auto\"><a href=\"#\"");
            BeginWriteAttribute("style", " style=\"", 458, "\"", 466, 0);
            EndWriteAttribute();
            WriteLiteral(@">Quản lý</a></li>
                <li class=""breadcrumb-item active"">Ta Thật Không Phải Là Tiên Nhị Đại</li>
            </ol>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""white-box"">
                <div>
                    <nav>
                        <ul class=""nav nav-pills nav-fill"">
                            <li class=""nav-item"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc6619", async() => {
                WriteLiteral("Chỉnh Sửa");
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
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc7882", async() => {
                WriteLiteral("Danh Sách Chương");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc9152", async() => {
                WriteLiteral("Thêm Chương");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li class=\"nav-item\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc10417", async() => {
                WriteLiteral("Thống Kê");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12 bg-content d-flex"">
            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                <h5 class=""box-title"">Quy Đổi</h5>
                <ul class=""list-icons list-unstyled"">
                    <li><i class=""fa fa-check text-info""></i> Số chương chưa quy đổi: <strong>216</strong> chương</li>
                    <li><i class=""fa fa-check text-info""></i> Số chương đủ điều kiện quy đổi: <strong>213</strong> chương</li>
                    <li><i class=""fa fa-check text-info""></i> Giá gốc 1 lượt đọc: <strong>2.4</strong> đ</li>

                    <li><i class=""fa fa-check text-info""></i> Tổng tiền có thể quy đổi bây giờ: <strong>0</strong> đ</li>

                </ul>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc12496", async() => {
                WriteLiteral("\n                    <button type=\"button\" class=\"btn btn-block btn-info\">\n                        Quy Đổi\n                        Chương\n                    </button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

            <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                <h5 class=""box-title"">Rút Tiền</h5>
                <ul class=""list-icons list-unstyled"">
                    <li><i class=""fa fa-check text-danger""></i> Được tặng: 0 (chưa rút 0)</li>
                    <li><i class=""fa fa-check text-danger""></i> Thu phí: 0 (chưa rút 0)</li>
                    <li><i class=""fa fa-check text-danger""></i> Quy đổi từ chương: 0 (chưa rút 0)</li>
                    <li><i class=""fa fa-check text-danger""></i> Tổng: 0 (chưa rút 0 - saving 0)</li>
                </ul>
                <div class=""collapse m-t-15"">
                    <div class=""well"">
                        <div class=""table-responsive"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>Số tiền</th>
                                        <th>Người nhận</th>
                  ");
            WriteLiteral(@"                      <th>Thời gian</th>
                                        <th>Tình trạng</th>
                                    </tr>
                                </thead>

                            </table>
                        </div>
                    </div>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc278052802e721cefbc5e2534876a68415acbbc15294", async() => {
                WriteLiteral("\n                    <button type=\"button\" class=\"btn btn-block btn-danger\">Yêu Cầu Rút</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

    <div class=""row mt-5 bg-content"">
        <div class=""col-sm-12"">
            <div>
                <h5 class="" text-center"">Xem thống kê chi tiết theo ngày</h5>
                <input class=""form-control  text-center"" type=""text"" placeholder=""14/10/2020 - 14/11/2021"" disabled>
                <div class=""col-lg-6 col-xs-12"">
                    <ul class=""list-inline text-right d-flex mt-2"">
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #00bfc7;""></i>Lượt đọc</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #fdc006;""></i>Lượt thích</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #9675ce;""></i>Lượt mua</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle ");
            WriteLiteral(@"m-r-5"" style=""color: #17cc72;""></i>Lượt bình luận</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #fd5e04;""></i>Lượt đề cử</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #2d0808;""></i>Lượt tặng</h5>
                        </li>
                    </ul>
                </div>

                <div class=""col-lg-6 col-xs-12"">
                    <ul class=""list-inline text-rightmt-2"">
                        <li>
                            <h5><i class=""fa fa-circle m-r-5 w-200"" style=""color: #00bfc7;""></i>Lượt đọc : 100</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #fdc006;""></i>Lượt thích: 200</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #");
            WriteLiteral(@"9675ce;""></i>Lượt mua: 300</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #17cc72;""></i>Lượt bình luận: 400</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #fd5e04;""></i>Lượt đề cử: 500</h5>
                        </li>
                        <li>
                            <h5><i class=""fa fa-circle m-r-5"" style=""color: #2d0808;""></i>Lượt tặng: 600</h5>
                        </li>
                    </ul>


                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591