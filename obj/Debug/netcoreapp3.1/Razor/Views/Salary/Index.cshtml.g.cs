#pragma checksum "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f99f433beef29e45efd8443c0d428cbccc4a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salary_Index), @"mvc.1.0.view", @"/Views/Salary/Index.cshtml")]
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
#line 1 "/Users/fadyhanna/Projects/MarinaHR/Views/_ViewImports.cshtml"
using MarinaHR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
using MarinaHR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f99f433beef29e45efd8443c0d428cbccc4a3f", @"/Views/Salary/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b877e385d394aeb45a2b5891c679bf13d993c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<MarinaHR.ViewModels.SalaryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"container\">\n       <div class=\"text-left\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55f99f433beef29e45efd8443c0d428cbccc4a3f4017", async() => {
                WriteLiteral("الرواتب");
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
            WriteLiteral(@"
        </div>
    <div class=""row"">
<div class=""display-4 text-right float-right"">
    الرواتب
</div>
<br/>
<table class=""table table-striped float-left"">
    <thead>
        <tr class=""text-right"">
            <th scope=""col"">رقم المعملة</th>
            <th scope=""col"">الموظف</th>
            <th scope=""col"">اداع</th>
            <th scope=""col"">صرف</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Date</th>
        </tr>
    </thead>
");
#nullable restore
#line 24 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td class=\"text-right\">");
#nullable restore
#line 27 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                              Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">");
#nullable restore
#line 28 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">  ");
#nullable restore
#line 29 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                      if (item.transactionType == TransactionType.Deposit) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                                                                       Write(item.Amount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">  ");
#nullable restore
#line 30 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                      if (item.transactionType == TransactionType.Credit)  {

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                                                                       Write(item.Amount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                                                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">");
#nullable restore
#line 31 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td class=\"text-right\">");
#nullable restore
#line 32 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
                              Write(item.dateTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 34 "/Users/fadyhanna/Projects/MarinaHR/Views/Salary/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<MarinaHR.ViewModels.SalaryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
