#pragma checksum "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04173b8578846c7e5816316e3aeec756e56c9ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicio_Index), @"mvc.1.0.view", @"/Views/Servicio/Index.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\_ViewImports.cshtml"
using ReservacionesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\_ViewImports.cshtml"
using ReservacionesApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\_ViewImports.cshtml"
using ReservacionesApp.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04173b8578846c7e5816316e3aeec756e56c9ab9", @"/Views/Servicio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fa557820c29f1d5a2b32e1bb2ae24aa088e3735", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservacionesApp.Models.ServicioViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Servicios</h1>\r\n\r\n<div class=\"container\">\r\n   \r\n\r\n");
#nullable restore
#line 12 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" style=\"margin-bottom: 5px; margin-top: 5px;\">\r\n            <div class=\"col-12\" style=\"background:#d2cece;\" onclick=\"selecciona(this);\" data-id=\"");
#nullable restore
#line 15 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
                                                                                            Write(item.Identificador);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <p class=\"text-center\">\r\n                    <span class=\"hora\">");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
                                  Write(item.Hora);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> <span class=\"motociclista\">");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
                                                                                Write(item.Leyenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  <span class=\"disponibles\">");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
                                                                                                                                Write(item.TotalMotociclistas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Usuario\source\repos\ReservacionesApp\ReservacionesApp\Views\Servicio\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        window.onload = function () {\r\n             \r\n        }\r\n\r\n        function selecciona(t) {\r\n            \r\n            console.log(t);\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservacionesApp.Models.ServicioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
