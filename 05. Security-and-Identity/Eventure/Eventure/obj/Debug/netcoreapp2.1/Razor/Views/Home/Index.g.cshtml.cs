#pragma checksum "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f6e83c3ff983282134ac9c6ce38ecbfaee0bd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f6e83c3ff983282134ac9c6ce38ecbfaee0bd7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80070f401f5a6919a1bc18be4cc87e8d40f02f9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    if (User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(268, 135, true);
            WriteLiteral("        <main>\r\n            <div class=\"jumbotron mt-3 eventure-bg-color text-center\">\r\n                <h1>Greetings, Administrator - ");
            EndContext();
            BeginContext(404, 23, false);
#line 16 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
                                          Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(427, 153, true);
            WriteLiteral("!</h1>\r\n                <hr class=\"hr-3 hr-muted\" />\r\n                <h3 class=\"text-muted\">Enjoy your work.</h3>\r\n            </div>\r\n        </main>\r\n");
            EndContext();
#line 21 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
    }
    else if (User.IsInRole("User"))
    {

#line default
#line hidden
            BeginContext(631, 117, true);
            WriteLiteral("        <main>\r\n            <div class=\"jumbotron mt-3 eventure-bg-color text-center\">\r\n                <h1>Welcome, ");
            EndContext();
            BeginContext(749, 23, false);
#line 26 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
                        Write(this.User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(772, 180, true);
            WriteLiteral("!</h1>\r\n                <hr class=\"hr-3 hr-muted\" />\r\n                <h3 class=\"text-muted\">Eventures wihes you an exciting experience.</h3>\r\n            </div>\r\n        </main>\r\n");
            EndContext();
#line 31 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"

    }
}
else
{

#line default
#line hidden
            BeginContext(973, 420, true);
            WriteLiteral(@"    <main>
        <div class=""jumbotron mt-3 eventure-bg-color"">
            <h1>Eventures - The best ticket service in the world.</h1>
            <hr class=""hr-3 hr-black"" />
            <h3><a class=""text-primary"" href=""/Users/Login"">Login</a> to start ""eventing"".</h3>
            <h3><a class=""text-primary"" href=""/Users/Register"">Register</a> if you don't have an account.</h3>
        </div>
    </main>
");
            EndContext();
#line 44 "C:\Users\milen\source\repos\mvc-frameworks-asp.net-core\05. Security-and-Identity\Eventure\Eventure\Views\Home\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<EventureUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<EventureUser> SignInManager { get; private set; }
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
