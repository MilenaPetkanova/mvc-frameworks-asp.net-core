#pragma checksum "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c533fcc5eb97406b1ea615244fed9ee485aea3a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Delete.cshtml", typeof(AspNetCore.Views_Products_Delete))]
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
#line 1 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp;

#line default
#line hidden
#line 2 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp.Models;

#line default
#line hidden
#line 3 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\_ViewImports.cshtml"
using ChuskaAsp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c533fcc5eb97406b1ea615244fed9ee485aea3a9", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87bfd2aae419184c0dd242be09a2032f2eadb86", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn chushka-bg-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto half-width"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(67, 112, true);
            WriteLiteral("\r\n<main class=\"mt-3 mb-5\">\r\n    <h1 class=\"text-center\">Edit Product</h1>\r\n    <hr class=\"hr-2 bg-dark\" />\r\n    ");
            EndContext();
            BeginContext(179, 2996, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0eddf59da9ec4ccca77a10d23dceb5e5", async() => {
                BeginContext(295, 141, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 436, "", 454, 1);
#line 12 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
WriteAttributeValue("", 443, Model.Name, 443, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 207, true);
                WriteLiteral(" name=\"name\" disabled>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"price\">Price</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"price\" min=\"0.01\" step=\"0.01\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 661, "", 680, 1);
#line 16 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
WriteAttributeValue("", 668, Model.Price, 668, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(680, 230, true);
                WriteLiteral(" name=\"price\" disabled>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"description\">Description</label>\r\n            <textarea class=\"form-control\" id=\"description\" rows=\"4\" name=\"description\" disabled>");
                EndContext();
                BeginContext(911, 17, false);
#line 20 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                            Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(928, 371, true);
                WriteLiteral(@"</textarea>
        </div>
        <h4 class=""text-center"">Product Type</h4>
        <hr class=""hr-2 bg-dark half-width mt-4"" />
        <div class=""product-type-holder mt-4 d-flex justify-content-around"">
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""Type"" id=""inlineRadio1"" value=""Food"" ");
                EndContext();
                BeginContext(1301, 49, false);
#line 26 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                    Write(Model.Type.ToString() == "Food " ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1351, 277, true);
                WriteLiteral(@" disabled>
                <label class=""form-check-label"" for=""inlineRadio1"">Food</label>
            </div>
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""Type"" id=""inlineRadio2"" value=""Domestic"" ");
                EndContext();
                BeginContext(1630, 52, false);
#line 30 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                        Write(Model.Type.ToString() == "Domestic" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1683, 279, true);
                WriteLiteral(@" disabled>
                <label class=""form-check-label"" for=""inlineRadio2"">Domestic</label>
            </div>
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""Type"" id=""inlineRadio3"" value=""Health"" ");
                EndContext();
                BeginContext(1964, 50, false);
#line 34 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                      Write(Model.Type.ToString() == "Health" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2015, 279, true);
                WriteLiteral(@" disabled>
                <label class=""form-check-label"" for=""inlineRadio3"">Health</label>
            </div>
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""Type"" id=""inlineRadio4"" value=""Cosmetic"" ");
                EndContext();
                BeginContext(2296, 52, false);
#line 38 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                        Write(Model.Type.ToString() == "Cosmetic" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2349, 278, true);
                WriteLiteral(@" disabled>
                <label class=""form-check-label"" for=""inlineRadio4"">Cosmetic</label>
            </div>
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""Type"" id=""inlineRadio5"" value=""Other"" ");
                EndContext();
                BeginContext(2629, 49, false);
#line 42 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                     Write(Model.Type.ToString() == "Other" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2679, 374, true);
                WriteLiteral(@" disabled>
                <label class=""form-check-label"" for=""inlineRadio5"">Other</label>
            </div>
        </div>
        <hr class=""hr-2 bg-dark half-width mt-4"" />
        <div class=""product-action-holder mt-4 half-width mx-auto d-flex justify-content-around"">
            <button type=""submit"" class=""btn chushka-bg-color"">Delete</button>
            ");
                EndContext();
                BeginContext(3053, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cda71a2ef6c04ead8b37753a2e501aec", async() => {
                    BeginContext(3131, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3146, 22, true);
                WriteLiteral("\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\02. Razor-Views-and-Layouts\ChuskaAsp\Views\Products\Delete.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3175, 15, true);
            WriteLiteral("\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
