#pragma checksum "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\Shared\MainLayout2.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c9308136a66108828a0ed69c5babf46cab049a33addb2e943943414ab7049764"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStudy.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using BlazorStudy

#nullable disable
    ;
#nullable restore
#line 9 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\_Imports.razor"
using BlazorStudy.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class MainLayout2 : LayoutComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<global::BlazorStudy.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">Layout2</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorStudy\Shared\MainLayout2.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
