#pragma checksum "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb6cb07277b7140552c77ee13d110ea757deaaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Character_GetTheCharacter), @"mvc.1.0.view", @"/Views/Character/GetTheCharacter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb6cb07277b7140552c77ee13d110ea757deaaf8", @"/Views/Character/GetTheCharacter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476c9c527df9033ce257f0e83f61e00fcd721133", @"/Views/_ViewImports.cshtml")]
    public class Views_Character_GetTheCharacter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gotcharacter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
  
    ViewData["Title"] = "GetTheCharacter";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Character</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <td>\r\n            Name: ");
#nullable restore
#line 11 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            House: ");
#nullable restore
#line 16 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
              Write(Model.House);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Born: ");
#nullable restore
#line 21 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
             Write(Model.Born);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n    <td>\r\n        Died: ");
#nullable restore
#line 26 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
         Write(Model.Died);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    </tr>\r\n    <tr>\r\n    <td>\r\n        Culture: ");
#nullable restore
#line 31 "C:\devbuild4\gameofthronesassessment\gameofthronesassessment\Views\Character\GetTheCharacter.cshtml"
            Write(Model.Culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    </tr>\r\n</table>\r\n<a href=\"/character/pickcharacter\">Select As Favorite</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gotcharacter> Html { get; private set; }
    }
}
#pragma warning restore 1591
