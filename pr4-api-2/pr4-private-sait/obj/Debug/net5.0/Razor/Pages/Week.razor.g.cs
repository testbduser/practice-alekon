#pragma checksum "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda930ad5376779c361179743bbc8b3524eaa869"
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
#nullable restore
#line 3 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
using ClosedXML.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/week")]
    public partial class Week : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-qptq2alev5>Выберите город</h3>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                   ChangeCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-qptq2alev5");
#nullable restore
#line 8 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
     foreach (string city in Cities)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                        city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "b-qptq2alev5");
            __builder.AddContent(7, 
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                               city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "h3");
            __builder.AddAttribute(10, "b-qptq2alev5");
            __builder.AddMarkupContent(11, "Погода на следующие 7 дней в ");
            __builder.AddContent(12, 
#nullable restore
#line 14 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
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
#line 16 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                                        ExportToExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-qptq2alev5");
            __builder.AddMarkupContent(18, "Экспорт в Excel");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "week-table");
            __builder.AddAttribute(22, "b-qptq2alev5");
            __builder.AddMarkupContent(23, @"<tr b-qptq2alev5><th b-qptq2alev5>Дата</th>
        <th b-qptq2alev5>Макс. температура</th>
        <th b-qptq2alev5>Мин. температура</th>
        <th b-qptq2alev5>Описание</th>
        <th b-qptq2alev5>Осадки</th>
        <th b-qptq2alev5>Влажность</th>
        <th b-qptq2alev5>Скорость ветра</th></tr>");
#nullable restore
#line 27 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
     if (WeatherRecords != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
         foreach (var day in WeatherRecords.Take(7))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "b-qptq2alev5");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "b-qptq2alev5");
            __builder.AddContent(28, 
#nullable restore
#line 32 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "b-qptq2alev5");
            __builder.AddContent(32, 
#nullable restore
#line 33 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.MaxTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "b-qptq2alev5");
            __builder.AddContent(37, 
#nullable restore
#line 34 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.MinTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "b-qptq2alev5");
            __builder.AddContent(42, 
#nullable restore
#line 35 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "b-qptq2alev5");
            __builder.AddContent(46, 
#nullable restore
#line 36 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.Precipitation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, " mm");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-qptq2alev5");
            __builder.AddContent(51, 
#nullable restore
#line 37 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "b-qptq2alev5");
            __builder.AddContent(56, 
#nullable restore
#line 38 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
                     day.WindSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " km/h");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Week.razor"
       
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
        WeatherRecords = await WeatherService.GetWeatherForecast(SelectedCity, 7);
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
            // Создание нового документа Excel
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Погода на неделю");

                // Заголовки столбцов
                worksheet.Cell(1, 1).Value = "Дата";
                worksheet.Cell(1, 2).Value = "Макс. температура";
                worksheet.Cell(1, 3).Value = "Мин. температура";
                worksheet.Cell(1, 4).Value = "Описание";
                worksheet.Cell(1, 5).Value = "Осадки";
                worksheet.Cell(1, 6).Value = "Влажность";
                worksheet.Cell(1, 7).Value = "Скорость ветра";

                // Данные о погоде
                for (int i = 0; i < WeatherRecords.Count && i < 7; i++)
                {
                    var day = WeatherRecords[i];
                    int row = i + 2;

                    worksheet.Cell(row, 1).Value = day.Date.ToShortDateString();
                    worksheet.Cell(row, 2).Value = day.MaxTemperature;
                    worksheet.Cell(row, 3).Value = day.MinTemperature;
                    worksheet.Cell(row, 4).Value = day.Description;
                    worksheet.Cell(row, 5).Value = day.Precipitation;
                    worksheet.Cell(row, 6).Value = day.Humidity;
                    worksheet.Cell(row, 7).Value = day.WindSpeed;
                }

                // Сохранение файла Excel
                var fileName = $"{SelectedCity}_погода_на_неделю.xlsx";
                var filePath = Path.Combine(@"E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\wwwroot\import", fileName); // Замените "Путь_к_директории" на вашу желаемую директорию

                workbook.SaveAs(filePath);

                // Вывод сообщения об успешном экспорте
                Console.WriteLine($"Файл Excel успешно экспортирован: {filePath}");
            }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherService WeatherService { get; set; }
    }
}
#pragma warning restore 1591
