#pragma checksum "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4868ba0695b65ecd93e5828c65cee04f72ac3fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Delete), @"mvc.1.0.view", @"/Views/Events/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/Delete.cshtml", typeof(AspNetCore.Views_Events_Delete))]
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
#line 1 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure;

#line default
#line hidden
#line 2 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure.Models;

#line default
#line hidden
#line 3 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4868ba0695b65ecd93e5828c65cee04f72ac3fd2", @"/Views/Events/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80070f401f5a6919a1bc18be4cc87e8d40f02f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventure.Models.Events.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(79, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Event</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 40, false);
#line 14 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UUID));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 36, false);
#line 17 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UUID));

#line default
#line hidden
            EndContext();
            BeginContext(366, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(410, 40, false);
#line 20 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(450, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(494, 36, false);
#line 23 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(574, 41, false);
#line 26 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(615, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(659, 37, false);
#line 29 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Place));

#line default
#line hidden
            EndContext();
            BeginContext(696, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(740, 41, false);
#line 32 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
            EndContext();
            BeginContext(781, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(825, 37, false);
#line 35 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Start));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(906, 39, false);
#line 38 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.End));

#line default
#line hidden
            EndContext();
            BeginContext(945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(989, 35, false);
#line 41 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.End));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1068, 48, false);
#line 44 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalTickets));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1160, 44, false);
#line 47 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalTickets));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1248, 50, false);
#line 50 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1342, 46, false);
#line 53 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PricePerTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1422, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "900a6965bd714e61bd9c7b6aaff859fa", async() => {
                BeginContext(1448, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1458, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f7af130730d4339b135f2f2bbad7608", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\03. Application-Flow-and-Middleware\Eventure\Eventure\Views\Events\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1494, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1578, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88718342b38b4a8ab32276cff220bc34", async() => {
                    BeginContext(1600, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1616, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1629, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventure.Models.Events.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
