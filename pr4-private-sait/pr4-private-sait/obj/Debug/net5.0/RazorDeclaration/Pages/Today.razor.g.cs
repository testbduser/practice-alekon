// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
