#pragma checksum "/Users/Aelien/Documents/c#/WebApplication1/Pages/Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721bd86e65662adebc8c36a53308501bfc951171"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using WebApplication1;
    using WebApplication1.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 9 "/Users/Aelien/Documents/c#/WebApplication1/Pages/Counter.cshtml"
            
    int currentCount = 0;

    [Parameter] int IncrementAmount {get; set;} = 1;

    void IncrementCount()
    {
        currentCount += IncrementAmount;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
