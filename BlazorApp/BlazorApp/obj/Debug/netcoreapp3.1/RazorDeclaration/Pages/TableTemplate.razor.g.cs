// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp

#nullable disable
    ;
#nullable restore
#line 9 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared

#nullable disable
    ;
#nullable restore
#line 1 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\Pages\TableTemplate.razor"
 using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    #nullable restore
    public partial class TableTemplate<
#nullable restore
#line 3 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\Pages\TableTemplate.razor"
           TItem

#line default
#line hidden
#nullable disable
    > : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Workspace\PersonalStudy_Unity\BlazorApp\BlazorApp\Pages\TableTemplate.razor"
       
    [Parameter]
    public RenderFragment Header { get; set; }

    [Parameter]
    public RenderFragment<TItem> Row { get; set; }

    [Parameter]
    public IReadOnlyList<TItem> Items { get; set; }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
