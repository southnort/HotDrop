using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotDrop.Models;
using System.IO;
using HtmlAgilityPack;
using System.Xml;
using iText.Html2pdf;


namespace HotDrop
{
    public class PDFExporter
    {
        private string htmlFileName = "html.html";

        public void ExportToFile(List<KnowledgeCell> cells, string fileName)
        {
            var pdfPath = Environment.GetFolderPath
                (Environment.SpecialFolder.DesktopDirectory) +
                "\\" + fileName ;
            var htmlPath = Environment.GetFolderPath
                (Environment.SpecialFolder.DesktopDirectory) +
                "\\" + htmlFileName;

            var html = GetContent(cells);
            File.WriteAllText(htmlPath, html);

            HtmlConverter.ConvertToPdf(
                new FileInfo(htmlPath),
                new FileInfo(pdfPath)
    );

           // File.Delete(htmlPath);

        }

        private string GetContent(List<KnowledgeCell> cells)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><table>");
            sb.Append("<tr>");

            sb.Append("<th>Тип</th>");
            sb.Append("<th>Описание проблемы</th>");
            sb.Append("<th>Описание решения</th>");
            sb.Append("<th>Комментарии</th>");
            sb.Append("</tr>");

            foreach (var cell in cells)
            {
                sb.Append("<tr>");

                sb.Append($"<td>{cell.GetTypesString()}</td>");
                sb.Append($"<td>{cell.Description}</td>");
                sb.Append($"<td>{cell.Solution}</td>");
                sb.Append($"<td>{cell.Comments}</td>");

                sb.Append("</tr>");
            }

            sb.Append("</table></body></html>");

            return sb.ToString();

        }

    }
}
