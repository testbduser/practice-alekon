#pragma checksum "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2afc2cd43b931fe941e6a63c2604121e8b61d06"
// <auto-generated/>
#pragma warning disable 1591
namespace pr4_private_sait.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using pr4_private_sait;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\_Imports.razor"
using pr4_private_sait.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/today")]
    public partial class Today : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-qmxmaqvwj6>Выберите город</h3>\r\n<link href=\"Today.razor.css\" rel=\"stylesheet\" b-qmxmaqvwj6>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                   ChangeCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-qmxmaqvwj6");
#nullable restore
#line 8 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
     foreach (string city in Cities)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                        city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "b-qmxmaqvwj6");
            __builder.AddContent(7, 
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                               city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "b-qmxmaqvwj6");
            __builder.AddMarkupContent(11, "Погода в ");
            __builder.AddContent(12, 
#nullable restore
#line 14 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
              SelectedCity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " сегодня");
            __builder.CloseElement();
#nullable restore
#line 16 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
 if (WeatherRecords != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "weather-container");
            __builder.AddAttribute(16, "b-qmxmaqvwj6");
#nullable restore
#line 19 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
         foreach (var record in WeatherRecords)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "weather-record");
            __builder.AddAttribute(19, "b-qmxmaqvwj6");
            __builder.AddMarkupContent(20, "<div class=\"label\" b-qmxmaqvwj6>Дата:</div>\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "date");
            __builder.AddAttribute(23, "b-qmxmaqvwj6");
            __builder.AddContent(24, 
#nullable restore
#line 23 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                   record.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<div class=\"label\" b-qmxmaqvwj6>Макс. температура:</div>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "max-temp");
            __builder.AddAttribute(29, "b-qmxmaqvwj6");
            __builder.AddContent(30, 
#nullable restore
#line 25 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.MaxTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<div class=\"label\" b-qmxmaqvwj6>Мин. температура:</div>\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "min-temp");
            __builder.AddAttribute(36, "b-qmxmaqvwj6");
            __builder.AddContent(37, 
#nullable restore
#line 27 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.MinTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddMarkupContent(40, "<div class=\"label\" b-qmxmaqvwj6>Описание:</div>\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "description");
            __builder.AddAttribute(43, "b-qmxmaqvwj6");
            __builder.AddContent(44, 
#nullable restore
#line 29 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                          record.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<div class=\"label\" b-qmxmaqvwj6>Осадки:</div>\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "precipitation");
            __builder.AddAttribute(49, "b-qmxmaqvwj6");
            __builder.AddContent(50, 
#nullable restore
#line 31 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                            record.Precipitation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, " mm");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.AddMarkupContent(53, "<div class=\"label\" b-qmxmaqvwj6>Влажность:</div>\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "humidity");
            __builder.AddAttribute(56, "b-qmxmaqvwj6");
            __builder.AddContent(57, 
#nullable restore
#line 33 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.AddMarkupContent(60, "<div class=\"label\" b-qmxmaqvwj6>Скорость ветра:</div>\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "wind-speed");
            __builder.AddAttribute(63, "b-qmxmaqvwj6");
            __builder.AddContent(64, 
#nullable restore
#line 35 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                         record.WindSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(65, " km/h");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "<p b-qmxmaqvwj6>Информация о погоде недоступна.</p>");
#nullable restore
#line 43 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
       
    private List<WeatherRecord> WeatherRecords { get; set; }
    private List<string> Cities { get; set; }
    private string SelectedCity { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Cities = await WeatherService.GetCities();
        SelectedCity = Cities.FirstOrDefault(); // Установка первого города в списке по умолчанию
        await UpdateWeather();
    }

    private async Task UpdateWeather()
    {
        WeatherRecords = await WeatherService.GetWeatherForecast(SelectedCity, 1);
    }

    private async Task ChangeCity(ChangeEventArgs e)
    {
        SelectedCity = e.Value.ToString();
        await UpdateWeather();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherService WeatherService { get; set; }
    }
}
#pragma warning restore 1591
