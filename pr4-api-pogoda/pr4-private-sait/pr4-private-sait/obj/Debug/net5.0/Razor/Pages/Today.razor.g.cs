#pragma checksum "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea36dc72bd8574f0963febe524b94c5311411b3"
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
#line 3 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
using ClosedXML.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
using System.IO;

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
#line 9 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                   ChangeCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-qmxmaqvwj6");
#nullable restore
#line 10 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
     foreach (string city in Cities)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.AddAttribute(5, "value", 
#nullable restore
#line 12 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                        city

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "b-qmxmaqvwj6");
            __builder.AddContent(7, 
#nullable restore
#line 12 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                               city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
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
#line 16 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
              SelectedCity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " сегодня");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "export-button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                        ExportToExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-qmxmaqvwj6");
            __builder.AddMarkupContent(19, "Экспорт в Excel");
            __builder.CloseElement();
#nullable restore
#line 20 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
 if (WeatherRecords != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "weather-container");
            __builder.AddAttribute(22, "b-qmxmaqvwj6");
#nullable restore
#line 23 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
         foreach (var record in WeatherRecords)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "weather-record");
            __builder.AddAttribute(25, "b-qmxmaqvwj6");
            __builder.AddMarkupContent(26, "<div class=\"label\" b-qmxmaqvwj6>Дата:</div>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "date");
            __builder.AddAttribute(29, "b-qmxmaqvwj6");
            __builder.AddContent(30, 
#nullable restore
#line 27 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                   record.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, "<div class=\"label\" b-qmxmaqvwj6>Макс. температура:</div>\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "max-temp");
            __builder.AddAttribute(35, "b-qmxmaqvwj6");
            __builder.AddContent(36, 
#nullable restore
#line 29 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.MaxTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.AddMarkupContent(39, "<div class=\"label\" b-qmxmaqvwj6>Мин. температура:</div>\r\n                ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "min-temp");
            __builder.AddAttribute(42, "b-qmxmaqvwj6");
            __builder.AddContent(43, 
#nullable restore
#line 31 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.MinTemperature

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, " °C");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<div class=\"label\" b-qmxmaqvwj6>Описание:</div>\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "description");
            __builder.AddAttribute(49, "b-qmxmaqvwj6");
            __builder.AddContent(50, 
#nullable restore
#line 33 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                          record.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.AddMarkupContent(52, "<div class=\"label\" b-qmxmaqvwj6>Осадки:</div>\r\n                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "precipitation");
            __builder.AddAttribute(55, "b-qmxmaqvwj6");
            __builder.AddContent(56, 
#nullable restore
#line 35 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                            record.Precipitation

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " mm");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.AddMarkupContent(59, "<div class=\"label\" b-qmxmaqvwj6>Влажность:</div>\r\n                ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "humidity");
            __builder.AddAttribute(62, "b-qmxmaqvwj6");
            __builder.AddContent(63, 
#nullable restore
#line 37 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                       record.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<div class=\"label\" b-qmxmaqvwj6>Скорость ветра:</div>\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "wind-speed");
            __builder.AddAttribute(69, "b-qmxmaqvwj6");
            __builder.AddContent(70, 
#nullable restore
#line 39 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
                                         record.WindSpeed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " km/h");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 43 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<p b-qmxmaqvwj6>Информация о погоде недоступна.</p>");
#nullable restore
#line 47 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "E:\работы305\prALEKON\pr4c#\pr4-private-sait\pr4-private-sait\Pages\Today.razor"
       
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
                var worksheet = workbook.Worksheets.Add("Погода");

                // Заголовки столбцов
                worksheet.Cell(1, 1).Value = "Дата";
                worksheet.Cell(1, 2).Value = "Макс. температура";
                worksheet.Cell(1, 3).Value = "Мин. температура";
                worksheet.Cell(1, 4).Value = "Описание";
                worksheet.Cell(1, 5).Value = "Осадки";
                worksheet.Cell(1, 6).Value = "Влажность";
                worksheet.Cell(1, 7).Value = "Скорость ветра";

                // Данные о погоде
                for (int i = 0; i < WeatherRecords.Count; i++)
                {
                    var record = WeatherRecords[i];
                    int row = i + 2;

                    worksheet.Cell(row, 1).Value = record.Date.ToShortDateString();
                    worksheet.Cell(row, 2).Value = record.MaxTemperature;
                    worksheet.Cell(row, 3).Value = record.MinTemperature;
                    worksheet.Cell(row, 4).Value = record.Description;
                    worksheet.Cell(row, 5).Value = record.Precipitation;
                    worksheet.Cell(row, 6).Value = record.Humidity;
                    worksheet.Cell(row, 7).Value = record.WindSpeed;
                }

                // Сохранение файла Excel
                var fileName = $"{SelectedCity}_погода.xlsx";
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
