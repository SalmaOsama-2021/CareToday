#pragma checksum "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "336ab9e526c2c880cb9acba0d3170e5b825d0f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oxygen_Index), @"mvc.1.0.view", @"/Views/Oxygen/Index.cshtml")]
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
#line 1 "C:\Users\salmaosama\Downloads\identity\identity\Views\_ViewImports.cshtml"
using identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\salmaosama\Downloads\identity\identity\Views\_ViewImports.cshtml"
using identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\salmaosama\Downloads\identity\identity\Views\_ViewImports.cshtml"
using identity.viewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\salmaosama\Downloads\identity\identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336ab9e526c2c880cb9acba0d3170e5b825d0f9f", @"/Views/Oxygen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a37e5ac904525cd1bf2e80295fd3f2d291f575a", @"/Views/_ViewImports.cshtml")]
    public class Views_Oxygen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<identity.Models.OxygenTube>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
      
        ViewData["Title"] = "index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>index</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "336ab9e526c2c880cb9acba0d3170e5b825d0f9f4344", async() => {
                WriteLiteral("Add New Service");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <table class=""table table-striped mt-4"">
        <thead class=""bg-primary text-white"">
            <tr class=""bg-primary text-white"">
                <th>OxygenType</th>
                <th>OxygenAmount</th>
                <th>OxygenCost</th>
                <th>PhoneNumber</th>

                <th>Address</th>
                <th>Description</th>
                <th>CityName</th>

                <th></th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 25 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 33 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.OxgnDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
                 if (item.City == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> </td>\r\n");
#nullable restore
#line 38 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 41 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
               Write(item.City.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
           Write(Html.ActionLink("Delete", "delete", new { id = item.OxgnId }, new { @class = "btn btn-danger text-white", onclick = "return confirm('Are you sure Delete Service?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 45 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
           Write(Html.ActionLink("Edit", "edit", new { id = item.OxgnId }, new { @class = "btn btn-outline-primary  text-black-50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\salmaosama\Downloads\identity\identity\Views\Oxygen\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<identity.Models.OxygenTube>> Html { get; private set; }
    }
}
#pragma warning restore 1591
