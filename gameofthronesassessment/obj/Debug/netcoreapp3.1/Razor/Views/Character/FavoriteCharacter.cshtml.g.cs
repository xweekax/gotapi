#pragma checksum "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc742cbe7182da88a7e3a41c7549e4f87de0a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_FavoriteCharacter), @"mvc.1.0.view", @"/Views/Character/FavoriteCharacter.cshtml")]
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
#line 1 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\_ViewImports.cshtml"
using gameofthronesassessment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\_ViewImports.cshtml"
using gameofthronesassessment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc742cbe7182da88a7e3a41c7549e4f87de0a36", @"/Views/Character/FavoriteCharacter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476c9c527df9033ce257f0e83f61e00fcd721133", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_FavoriteCharacter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SessionCharacter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
  
    ViewData["Title"] = "FavoriteCharacter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Favorite Characters</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
 foreach(gotcharacter character in Model.charactersList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 13 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 16 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.House);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 19 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 22 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.Born);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 25 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.Died);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 28 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
       Write(character.Book);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 608, 2);
            WriteAttributeValue("", 565, "/character/getthecharacter?id=", 565, 30, true);
#nullable restore
#line 30 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
WriteAttributeValue("", 595, character.id, 595, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Get All Details</a></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 33 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\FavoriteCharacter.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SessionCharacter> Html { get; private set; }
    }
}
#pragma warning restore 1591
