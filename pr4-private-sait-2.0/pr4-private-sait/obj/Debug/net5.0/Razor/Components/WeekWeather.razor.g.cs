#pragma checksum "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22297a4d40b6c8325577f1b9b312862f25fa549"
// <auto-generated/>
#pragma warning disable 1591
namespace pr4_private_sait.Components
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
    public partial class WeekWeather : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-avh2bp2mmc>Выберите город</h3>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                   ChangeCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-avh2bp2mmc");
#nullable restore
#line 6 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
     foreach (string city in Cities)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 8 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                        city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "b-avh2bp2mmc");
            __builder.AddContent(7, 
#nullable restore
#line 8 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                               city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "b-avh2bp2mmc");
            __builder.AddMarkupContent(11, "Погода на следующие 7 дней в ");
            __builder.AddContent(12, 
#nullable restore
#line 12 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                                  SelectedCity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "export-button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                                        ExportToExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-avh2bp2mmc");
            __builder.AddMarkupContent(18, "Экспорт в Excel");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "week-table");
            __builder.AddAttribute(22, "b-avh2bp2mmc");
            __builder.AddMarkupContent(23, @"<tr b-avh2bp2mmc><th b-avh2bp2mmc>Дата</th>
        <th b-avh2bp2mmc>Макс. температура</th>
        <th b-avh2bp2mmc>Мин. температура</th>
        <th b-avh2bp2mmc>Описание</th>
        <th b-avh2bp2mmc>Осадки</th>
        <th b-avh2bp2mmc>Влажность</th>
        <th b-avh2bp2mmc>Скорость ветра</th></tr>");
#nullable restore
#line 26 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
     if (WeatherRecords != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
         foreach (var day in WeatherRecords.Take(14))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "b-avh2bp2mmc");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-avh2bp2mmc");
            __builder.AddContent(28, 
#nullable restore
#line 31 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "b-avh2bp2mmc");
            __builder.AddContent(32, 
#nullable restore
#line 32 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.MaxTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "b-avh2bp2mmc");
            __builder.AddContent(37, 
#nullable restore
#line 33 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.MinTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "b-avh2bp2mmc");
            __builder.AddContent(42, 
#nullable restore
#line 34 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "b-avh2bp2mmc");
            __builder.AddContent(46, 
#nullable restore
#line 35 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.Precipitation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, " mm");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-avh2bp2mmc");
            __builder.AddContent(51, 
#nullable restore
#line 36 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "b-avh2bp2mmc");
            __builder.AddContent(56, 
#nullable restore
#line 37 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
                     day.WindSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " km/h");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Components\WeekWeather.razor"
       
    private List<WeatherRecord> WeatherRecords { get; set; }
    private List<string> Cities { get; set; }
    private string SelectedCity { get; set; }
    private static int exportCounter = 1;

    [Parameter]
    public int Days { get; set; }
    [Parameter]
    public string Name { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Cities = await WeatherService.GetCities();
        SelectedCity = Cities.FirstOrDefault(); // Установка первого города в списке по умолчанию
        await UpdateWeather();
    }

    private async Task UpdateWeather()
    {
        WeatherRecords = await WeatherService.GetWeatherForecast(SelectedCity, Days);
    }

    private async Task ChangeCity(ChangeEventArgs e)
    {
        SelectedCity = e.Value.ToString();
        await UpdateWeather();
    }

    private async Task ExportToExcel()
    {
        // Проверка наличия данных о погоде
        if (WeatherRecords == null || WeatherRecords.Count == 0)
        {
            return;
        }

        try
        {
            // Экспорт данных в Excel
            var fileName = $"{SelectedCity}_{Name}_{exportCounter}.xlsx";
            var data = WeatherRecords.Select(record => new
            {
                Date = record.Date.ToShortDateString(),
                MaxTemperature = record.MaxTemperature,
                MinTemperature = record.MinTemperature,
                Description = record.Description,
                Precipitation = record.Precipitation,
                Humidity = record.Humidity,
                WindSpeed = record.WindSpeed
            });

            ExcelService.ExportToExcel(fileName, "Погода", data);

            // Увеличение счетчика
            exportCounter++;
        }
        catch (Exception ex)
        {
            // Обработка ошибки при экспорте
            Console.WriteLine($"Ошибка при экспорте в Excel: {ex.Message}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ExcelService ExcelService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherService WeatherService { get; set; }
    }
}
#pragma warning restore 1591