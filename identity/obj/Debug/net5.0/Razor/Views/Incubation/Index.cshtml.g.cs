#pragma checksum "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8069eeb4ef6f4994622839e68cfb4e15e84579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Incubation_Index), @"mvc.1.0.view", @"/Views/Incubation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8069eeb4ef6f4994622839e68cfb4e15e84579", @"/Views/Incubation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a37e5ac904525cd1bf2e80295fd3f2d291f575a", @"/Views/_ViewImports.cshtml")]
    public class Views_Incubation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<identity.Models.Nursery>>
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
#line 2 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
  
    ViewData["Title"] = "index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb8069eeb4ef6f4994622839e68cfb4e15e845794290", async() => {
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
<th>NurseryCost</th>
    <th>PhoneNumber</th>
    <th>Address</th>
    <th>Description</th>
    <th>          </th>
</tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(item.NurCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(item.NurPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(item.NurLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(item.NurDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               \r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(Html.ActionLink("Delete", "delete", new { id = item.NurId }, new { @class = "btn btn-danger text-white", onclick = "return confirm('Are you sure Delete Service?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
               Write(Html.ActionLink("Edit", "edit", new { id = item.NurId }, new { @class = "btn btn-outline-primary  text-black-50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\salmaosama\Downloads\identity\identity\Views\Incubation\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<identity.Models.Nursery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
