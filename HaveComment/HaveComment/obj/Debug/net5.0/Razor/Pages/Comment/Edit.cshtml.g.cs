#pragma checksum "C:\Users\vira66452172\source\repos\HaveComment\HaveComment\Pages\Comment\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85de61f63ba5216ee5adac0561c9e2dafde1e911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Comment_Edit), @"mvc.1.0.razor-page", @"/Pages/Comment/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85de61f63ba5216ee5adac0561c9e2dafde1e911", @"/Pages/Comment/Edit.cshtml")]
    public class Pages_Comment_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\vira66452172\source\repos\HaveComment\HaveComment\Pages\Comment\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Comments</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Comments.Id"" />
            <div class=""form-group"">
                <label asp-for=""Comments.Tittel"" class=""control-label""></label>
                <input asp-for=""Comments.Tittel"" class=""form-control"" />
                <span asp-validation-for=""Comments.Tittel"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Comments.Text"" class=""control-label""></label>
                <input asp-for=""Comments.Text"" class=""form-control"" />
                <span asp-validation-for=""Comments.Text"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Comments.Status"" class=""control-label""></label>
                <input asp-for=""Comments.Status");
            WriteLiteral(@""" class=""form-control"" />
                <span asp-validation-for=""Comments.Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\vira66452172\source\repos\HaveComment\HaveComment\Pages\Comment\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HaveComment.Pages.Comment.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HaveComment.Pages.Comment.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HaveComment.Pages.Comment.EditModel>)PageContext?.ViewData;
        public HaveComment.Pages.Comment.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
