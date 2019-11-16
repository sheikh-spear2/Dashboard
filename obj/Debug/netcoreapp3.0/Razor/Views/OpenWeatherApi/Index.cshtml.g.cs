#pragma checksum "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d54919a5a8e9865a7e8118ea8b3191436b7e119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpenWeatherApi_Index), @"mvc.1.0.view", @"/Views/OpenWeatherApi/Index.cshtml")]
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
#line 1 "C:\Users\haoua\source\repos\Dashboard\Views\_ViewImports.cshtml"
using Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\haoua\source\repos\Dashboard\Views\_ViewImports.cshtml"
using Dashboard.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d54919a5a8e9865a7e8118ea8b3191436b7e119", @"/Views/OpenWeatherApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb225a8b7775b6d65d4bc41cad2c9bd60636940", @"/Views/_ViewImports.cshtml")]
    public class Views_OpenWeatherApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dashboard.Models.OpenWeatherMap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
  
    ViewData["Title"] = "OpenWeatherMap";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #apiDiv {
        padding-left: 20px;
    }

        #apiDiv select, #apiDiv button {
            font-size: 25px;
        }

        #apiDiv h4 {
            margin: 10px 0;
        }

        #apiDiv #message table {
            width: 100%;
            border: double 1px #00ffff;
            background: #ff6a00;
        }

            #apiDiv #message table th {
                text-align: left;
                background: #4CAF50;
            }
</style>
");
#nullable restore
#line 34 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Weather</h1>\r\n");
#nullable restore
#line 37 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<button id=\"reset\" name=\"reset\">Reset »</button>");
#nullable restore
#line 38 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"apiDiv\">\r\n        <h4>Select the City for Weather Report</h4>\r\n");
#nullable restore
#line 41 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
         using (Html.BeginForm())
        {
            foreach (var city in Model.cities)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>\r\n                    ");
#nullable restore
#line 46 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
               Write(Html.RadioButtonFor(m => m.cities, city.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
                                                               Write(city.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n");
#nullable restore
#line 48 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <button name=\"submit\">Submit</button>\r\n");
#nullable restore
#line 51 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"message\">");
#nullable restore
#line 52 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
                      Write((Html.Raw(Model.apiResponse)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    </div>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""input[id='cities']"").change(function () {
                $(this).parents(""#apiDiv"").find
                    (""span"").css(""background"", ""none"");
                $(this).parent().css(""background"", ""#4CAF50"");
            });
        });
    </script>
");
#nullable restore
#line 64 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3> You need to login for that </h3>\r\n");
#nullable restore
#line 68 "C:\Users\haoua\source\repos\Dashboard\Views\OpenWeatherApi\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dashboard.Models.OpenWeatherMap> Html { get; private set; }
    }
}
#pragma warning restore 1591