#pragma checksum "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84ef689d61b03ded80c8ca35743bad13bf4cb8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_UserEvents), @"mvc.1.0.view", @"/Views/Events/UserEvents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Events/UserEvents.cshtml", typeof(AspNetCore.Views_Events_UserEvents))]
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
#line 1 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure;

#line default
#line hidden
#line 2 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure.Models;

#line default
#line hidden
#line 3 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\_ViewImports.cshtml"
using Eventure.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84ef689d61b03ded80c8ca35743bad13bf4cb8d", @"/Views/Events/UserEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80070f401f5a6919a1bc18be4cc87e8d40f02f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_UserEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventure.ViewModels.Events.UserEventsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 519, true);
            WriteLiteral(@"
<main class=""mt-3 mb-5"">
    <h1 class=""text-center"">My Events</h1>
    <hr class=""hr-2 eventure-bg-color half-width"" />
    <table class=""table w-75 mx-auto table-hover"">
        <thead>
            <tr class=""row"">
                <th class=""col-md-1"">#</th>
                <th class=""col-md-3"">Name</th>
                <th class=""col-md-2"">Start</th>
                <th class=""col-md-2"">End</th>
                <th class=""col-md-2"">Tickets</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
             foreach (var eventEntity in Model.Events)
            {

#line default
#line hidden
            BeginContext(688, 75, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <td class=\"col-md-1\">");
            EndContext();
            BeginContext(764, 14, false);
#line 24 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
                                    Write(eventEntity.Id);

#line default
#line hidden
            EndContext();
            BeginContext(778, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-3\">");
            EndContext();
            BeginContext(827, 16, false);
#line 25 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
                                    Write(eventEntity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(843, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-2\">");
            EndContext();
            BeginContext(892, 22, false);
#line 26 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
                                    Write(eventEntity.StartToStr);

#line default
#line hidden
            EndContext();
            BeginContext(914, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-2\">");
            EndContext();
            BeginContext(963, 20, false);
#line 27 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
                                    Write(eventEntity.EndToStr);

#line default
#line hidden
            EndContext();
            BeginContext(983, 48, true);
            WriteLiteral("</td>\r\n                    <td class=\"col-md-3\">");
            EndContext();
            BeginContext(1032, 24, false);
#line 28 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
                                    Write(eventEntity.TotalTickets);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 30 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Events\UserEvents.cshtml"
            }

#line default
#line hidden
            BeginContext(1101, 95, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <hr class=\"hr-2 eventure-bg-color half-width\" />\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventure.ViewModels.Events.UserEventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
