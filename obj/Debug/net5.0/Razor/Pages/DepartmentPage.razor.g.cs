#pragma checksum "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5464614f8dca6ba05cbe8c70b41666ef240a9685"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor358.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Blazor358;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Tugas5_72190358\Blazor\Blazor358\_Imports.razor"
using Blazor358.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentpage")]
    public partial class DepartmentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2> Daftar Department</h2>\r\n");
            __builder.AddMarkupContent(1, "<div><button type=\"button\" class=\"btn btn-info oi oi-plus\" aria-hidden=\"true\">CREATE NEW Department</button></div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-striped");
            __builder.AddMarkupContent(5, "<thead><tr><th>Department Id</th>\r\n            <th>Department Name</th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 14 "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor"
         foreach(var dept in Departments){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 16 "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor"
                     dept.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 17 "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor"
                     dept.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "href", 
#nullable restore
#line 18 "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor"
                               $"Departmentdetail/{dept.DepartmentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddContent(18, "detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Tugas5_72190358\Blazor\Blazor358\Pages\DepartmentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
