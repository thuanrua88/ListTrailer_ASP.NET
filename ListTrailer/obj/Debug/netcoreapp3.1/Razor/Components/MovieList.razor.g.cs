#pragma checksum "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a58df5cd102d8cc6bf2c37f458f4b6b2e006f1e0"
// <auto-generated/>
#pragma warning disable 1591
namespace ListTrailer.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
using ListTrailer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
using ListTrailer.Services;

#line default
#line hidden
#nullable disable
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container row");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
     foreach (var Movie in MovieService.GetMovies())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "article");
            __builder.AddAttribute(5, "class", "col-md-12 d-inline");
            __builder.AddAttribute(6, "style", "width: 18rem; height: 40vh");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "iframe");
            __builder.AddAttribute(9, "class", "col-md-6 col-sm-6 h-100");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 11 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                                                      Movie.linkIframe

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "frameborder", "0");
            __builder.AddAttribute(12, "allow", "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(13, "allowfullscreen", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", 
#nullable restore
#line 12 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                  Movie.link

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "float-right tẽt-dark");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "h3");
            __builder.AddContent(20, 
#nullable restore
#line 13 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                 Movie.nameMovie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, " \r\n            ");
            __builder.OpenElement(22, "span");
            __builder.AddContent(23, 
#nullable restore
#line 14 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                   Movie.view

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " view - ");
            __builder.AddContent(25, 
#nullable restore
#line 14 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                                      Movie.time

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-body");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "card-text");
            __builder.AddContent(33, 
#nullable restore
#line 16 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
                                      Movie.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 20 "C:\Users\Pc\Documents\GitHub\ASP-NhuHoangMinhDuc\ASP-NhuDuc\ASP-API\ListTrailer\ListTrailer\Components\MovieList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonMovieService MovieService { get; set; }
    }
}
#pragma warning restore 1591