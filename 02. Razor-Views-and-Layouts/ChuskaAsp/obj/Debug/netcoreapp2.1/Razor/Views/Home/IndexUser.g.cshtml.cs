#pragma checksum "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b30a795ef52d8c43a1b3834ecf501d080f45bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexUser), @"mvc.1.0.view", @"/Views/Home/IndexUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexUser.cshtml", typeof(AspNetCore.Views_Home_IndexUser))]
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
#line 1 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp;

#line default
#line hidden
#line 2 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp.Models;

#line default
#line hidden
#line 3 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b30a795ef52d8c43a1b3834ecf501d080f45bf5", @"/Views/Home/IndexUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87bfd2aae419184c0dd242be09a2032f2eadb86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::ChuskaAsp.TagHelpers.HelloTagHelper __ChuskaAsp_TagHelpers_HelloTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
  
    ViewData["Title"] = "UserIndex";

#line default
#line hidden
            BeginContext(45, 49, true);
            WriteLiteral("\r\n<div class=\"container-fluid text-center\">\r\n    ");
            EndContext();
            BeginContext(94, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda9fe41e628463e838e3f7a2a11fb72", async() => {
            }
            );
            __ChuskaAsp_TagHelpers_HelloTagHelper = CreateTagHelper<global::ChuskaAsp.TagHelpers.HelloTagHelper>();
            __tagHelperExecutionContext.Add(__ChuskaAsp_TagHelpers_HelloTagHelper);
            BeginWriteTagHelperAttribute();
#line 6 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
        WriteLiteral(this.User.Identity.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ChuskaAsp_TagHelpers_HelloTagHelper.TargetName = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("target-name", __ChuskaAsp_TagHelpers_HelloTagHelper.TargetName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 201, true);
            WriteLiteral("\r\n    <h4>Feel free to view and order any of our products.</h4>\r\n</div>\r\n<hr class=\"hr-2 bg-dark\" />\r\n<div class=\"container-fluid product-holder\">\r\n    <div class=\"row d-flex justify-content-around\">\r\n");
            EndContext();
#line 12 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
            BeginContext(393, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(405, 562, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca482ab477644dbf8a0b2816eed39a50", async() => {
                BeginContext(502, 138, true);
                WriteLiteral("\r\n                <div class=\"product p-1 chushka-bg-color rounded-top rounded-bottom\">\r\n                    <h5 class=\"text-center mt-3\">");
                EndContext();
                BeginContext(641, 12, false);
#line 16 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
                                            Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(653, 111, true);
                WriteLiteral("</h5>\r\n                    <hr class=\"hr-1 bg-white\" />\r\n                    <p class=\"text-white text-center\">");
                EndContext();
                BeginContext(765, 24, false);
#line 18 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
                                                 Write(product.ShortDescription);

#line default
#line hidden
                EndContext();
                BeginContext(789, 117, true);
                WriteLiteral("</p>\r\n                    <hr class=\"hr-1 bg-white\" />\r\n                    <h6 class=\"text-center text-white mb-3\">$");
                EndContext();
                BeginContext(907, 13, false);
#line 20 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(920, 43, true);
                WriteLiteral("</h6>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("asp-", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
                                                                    WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(967, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\milen\Downloads\Homework-EXERCISE_ VIEWS & LAYOUTS-654845\ChuskaAsp\Views\Home\IndexUser.cshtml"
        }

#line default
#line hidden
            BeginContext(980, 24, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
