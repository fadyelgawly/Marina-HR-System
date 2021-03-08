#pragma checksum "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30893465b466c848eae7661df27de49aac24866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacation_Index), @"mvc.1.0.view", @"/Views/Vacation/Index.cshtml")]
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
#line 2 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
using MarinaHR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30893465b466c848eae7661df27de49aac24866", @"/Views/Vacation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b877e385d394aeb45a2b5891c679bf13d993c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<MarinaHR.ViewModels.VacationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vacation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptVacationRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RefuseVacationRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"display-4 text-right\">\n    الاجازات\n</div>\n<br />\n<div class=\"container font-weight-bold\">\n    <div class=\"row\">\n        <div class=\"col-sm\">\n            إجمالي رصيد الإجازة: ");
#nullable restore
#line 11 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                            Write(ViewData["TotalBalance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n      <div class=\"col-sm\">\n                رصيد الإجازةالمستخدم:  ");
#nullable restore
#line 14 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                  Write(ViewData["UsedBalance"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </div>\n      <div class=\"col-sm\">\n          رصيد الإجازة المتبقي:  ");
#nullable restore
#line 17 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                            Write(ViewData["BalanceLeft"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      </div>

        </div>
    </div>

    <br />
    <table class=""table table-striped float-left"">
        <thead>
            <tr class=""text-right"">
                <th scope=""col"">الاسم</th>
                <th scope=""col"">من</th>
                <th scope=""col"">إلى</th>
                <th scope=""col"">عدد الايام</th>
                <th scope=""col"">السبب</th>
                <th scope=""col"">حالة الاجازة</th>
            </tr>
        </thead>
");
#nullable restore
#line 35 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"text-right\">");
#nullable restore
#line 38 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 39 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                  Write(item.StartDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 40 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                  Write(item.EndDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 41 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                   Write((item.EndDate.Date - item.StartDate.Date).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">");
#nullable restore
#line 42 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                  Write(item.Reason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">\n\n\n\n");
#nullable restore
#line 47 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                     if (item.vacationStatus == VacationStatus.Requested && User.IsInRole("Administrator"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30893465b466c848eae7661df27de49aac248668213", async() => {
                WriteLiteral("موافق");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-VacationID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                                                                                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VacationID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-VacationID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VacationID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30893465b466c848eae7661df27de49aac2486610736", async() => {
                WriteLiteral("رفض");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-VacationID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                                                                                                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VacationID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-VacationID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VacationID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 51 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                    }
                    else if (item.vacationStatus == VacationStatus.Requested)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("تام الطلب\n");
#nullable restore
#line 55 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                    }
                    else if (item.vacationStatus == VacationStatus.Accepted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("وافقت\n");
#nullable restore
#line 59 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                    }
                    else if (item.vacationStatus == VacationStatus.Declined)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("رفض\n");
#nullable restore
#line 63 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 66 "/Users/fadyhanna/Projects/MarinaHR/Views/Vacation/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<MarinaHR.ViewModels.VacationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
