#pragma checksum "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c42bbf3eb63ade10ebf233917896522ad0968e6ccec86c0f9e878b8106a88650"
// <auto-generated/>
#pragma warning disable 1591
namespace RankingApp.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using RankingApp

#nullable disable
    ;
#nullable restore
#line 9 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\_Imports.razor"
using RankingApp.Shared

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>RankingApp</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", (object)("nav-link"));
            __builder.AddAttribute(22, "href", (object)(""));
            __builder.AddAttribute(23, "Match", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", (object)("nav-link"));
            __builder.AddAttribute(33, "href", (object)("counter"));
            __builder.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", (object)("nav-link"));
            __builder.AddAttribute(43, "href", (object)("fetchdata"));
            __builder.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\Workspace\PersonalStudy_Unity\RankingApp\RankingApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
