#pragma checksum "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be99b0c140b3ebd7c8a82f7fa5ed56cfbc58b067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Managers_Index), @"mvc.1.0.view", @"/Views/Managers/Index.cshtml")]
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
#line 1 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\_ViewImports.cshtml"
using MVCProject1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\_ViewImports.cshtml"
using MVCProject1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be99b0c140b3ebd7c8a82f7fa5ed56cfbc58b067", @"/Views/Managers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7704628acd63692c10ae857a42e43b2d7c272569", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Managers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCProject1.Models.Leave5>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Manager View</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 10 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
     using (Html.BeginForm("Index", "Managers", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div style=\"display: none;\"> ");
#nullable restore
#line 12 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
                                 Write(Html.RadioButton("searchBy", "ManagerID", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div style=\"margin: 20px; font-weight: bold;\">\r\n        <text>Search by Manager ID : </text>\r\n");
            WriteLiteral("        \r\n        ");
#nullable restore
#line 19 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
   Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <input type=\"submit\" value=\"Search\" /></div>\r\n");
#nullable restore
#line 22 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmplLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManagerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeavesInHand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaveStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaveEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmplLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ManagerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeavesInHand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                <div style=\"position: relative; width: 800px;\">\r\n                        <button style=\"background-color: green;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be99b0c140b3ebd7c8a82f7fa5ed56cfbc58b06711352", async() => {
                WriteLiteral("Approve");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
                                                                                                              WriteLiteral(item.LeaveStatus);

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
            WriteLiteral("</button>\r\n                        <button style=\"background-color: red; color: white;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be99b0c140b3ebd7c8a82f7fa5ed56cfbc58b06713742", async() => {
                WriteLiteral("Deny");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
                                                                                                                          WriteLiteral(item.LeaveStatus);

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
            WriteLiteral("</button>\r\n                 </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 102 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 3401, "\"", 3437, 1);
#nullable restore
#line 107 "L:\Hexaware\dev\MVCProject1\MVCProject1\Views\Managers\Index.cshtml"
WriteAttributeValue("", 3408, Url.Action("index","Leave5"), 3408, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to Home</a>\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCProject1.Models.Leave5>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
