using ClosedXML.Excel;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq; // Добавьте эту директиву

public class ExcelService
{
    public void ExportToExcel<T>(string fileName, string sheetName, IEnumerable<T> data)
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add(sheetName);

            // Записываем данные
            var properties = typeof(T).GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = properties[i].Name;
            }

            var dataList = data.ToList(); // Преобразуем IEnumerable<T> в List<T>

            for (int i = 0; i < dataList.Count; i++)
            {
                var item = dataList[i];
                for (int j = 0; j < properties.Length; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = properties[j].GetValue(item)?.ToString();
                }
            }

            // Сохраняем файл
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\import", fileName);
            workbook.SaveAs(filePath);

            // Открываем директорию с файлом
            var directoryPath = Path.GetDirectoryName(filePath);
            Process.Start(new ProcessStartInfo
            {
                FileName = directoryPath,
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}
