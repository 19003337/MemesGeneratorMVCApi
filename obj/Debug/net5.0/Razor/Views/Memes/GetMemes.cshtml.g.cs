#pragma checksum "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99413e53d2dfa3f7374a6b1a722c00489610062d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Memes_GetMemes), @"mvc.1.0.view", @"/Views/Memes/GetMemes.cshtml")]
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
#line 1 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\_ViewImports.cshtml"
using MemesGeneratorMVCApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\_ViewImports.cshtml"
using MemesGeneratorMVCApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99413e53d2dfa3f7374a6b1a722c00489610062d", @"/Views/Memes/GetMemes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695eb23ebce7e65e2bd7a635e359c7409f05c1fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Memes_GetMemes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MemesGeneratorMVCApi.Models.Meme>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
  
    ViewBag.Title = "Memes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Image</th>\r\n        <th>Choose</th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 333, "\"", 348, 1);
#nullable restore
#line 16 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
WriteAttributeValue("", 339, item.url, 339, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70px\"></td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
           Write(Html.ActionLink("Generate", "Generate", new { id = item.id, url = item.url}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Charmaine Dobbin\Visual Studio Code Projects\MemesGeneratorMVCApi\Views\Memes\GetMemes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MemesGeneratorMVCApi.Models.Meme>> Html { get; private set; }
    }
}
#pragma warning restore 1591
