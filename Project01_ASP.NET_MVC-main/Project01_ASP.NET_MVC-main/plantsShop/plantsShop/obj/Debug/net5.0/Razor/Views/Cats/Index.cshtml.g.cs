#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3526efd22b2e16a2557a4e1e97c12a7ed630799f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats_Index), @"mvc.1.0.view", @"/Views/Cats/Index.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3526efd22b2e16a2557a4e1e97c12a7ed630799f", @"/Views/Cats/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233d3ce1597551b5dcf4f6efeed0184212839024", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
  
    var cat = (List<CatModel>)ViewData["Cats"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container ml-5 pl-5\">\n    <div class=\"row\">\n");
#nullable restore
#line 8 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
         foreach (var c in cat)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\n                <div class=\"card-body\">\n                    <img class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=\"", 323, "\"", 337, 1);
#nullable restore
#line 13 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
WriteAttributeValue("", 329, c.image, 329, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
                                      Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\"> ");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
                                     Write(c.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 523, 2);
            WriteAttributeValue("", 504, "/cats/details/", 504, 14, true);
#nullable restore
#line 16 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"
WriteAttributeValue("", 518, c.id, 518, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">More Info</button></a>\n                </div>\n            </div>\n");
#nullable restore
#line 19 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\Unit Test\mvc-unit-test\Project01_ASP.NET_MVC-main\Project01_ASP.NET_MVC-main\plantsShop\plantsShop\Views\Cats\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
