#pragma checksum "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f725ee9e7de9b13b55f043f10efb75c3559fe35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
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
#line 2 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\_ViewImports.cshtml"
using Task_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\_ViewImports.cshtml"
using Task_Manager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\_ViewImports.cshtml"
using Task_Manager.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f725ee9e7de9b13b55f043f10efb75c3559fe35", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2e534b26a51867b25b5cd7a14c356644caf3a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task_Manager.Services.Config>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div>\r\n    <p>Contact mail:");
#nullable restore
#line 5 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\Home\Contacts.cshtml"
               Write(Config.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    Contact phone:");
#nullable restore
#line 6 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\Home\Contacts.cshtml"
             Write(Config.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    My name:");
#nullable restore
#line 7 "D:\Универ\C#\ASP.NET\Task Manager\Task Manager\Views\Home\Contacts.cshtml"
       Write(Config.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task_Manager.Services.Config> Html { get; private set; }
    }
}
#pragma warning restore 1591
