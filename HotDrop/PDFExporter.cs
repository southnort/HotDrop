using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotDrop.Models;
using System.IO;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;


namespace HotDrop
{
    public class PDFExporter
    {
        public void ExportToFile(List<KnowledgeCell> cells, string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                + "\\" + fileName;

            var html = CreateDocument(cells);
            var writer = new PdfWriter(new FileInfo(path));
            ConverterProperties props = new ConverterProperties();
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetDefaultPageSize(new PageSize(PageSize.A4.Rotate()));

            Document document = HtmlConverter.ConvertToDocument(html, 
                pdfDocument, props);

            document.Close();





            //Document document = HtmlConverter.ConvertToDocument(html, writer);
            //var pdfDoc = document.GetPdfDocument();
            //document.Close();

            //Document doc = new Document(pdfDoc, new iText.Kernel.Geom.PageSize(297, 210));

            //HtmlConverter.ConvertToPdf(writer, doc.GetPdfDocument());

            //doc.Close();
        }

        private string CreateDocument(List<KnowledgeCell> cells)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><table border=\"1\">");
            sb.Append("<tr>");

            //sb.Append("<th>Тип</th>");
            sb.Append("<th width=\"20%\">Описание проблемы</th>");
            sb.Append("<th width=\"60%\">Описание решения</th>");
            sb.Append("<th width=\"20%\">Комментарии</th>");
            sb.Append("</tr>");

            foreach (var cell in cells)
            {
                sb.Append("<tr>");

                //sb.Append(GetValue(cell.GetTypesString()));
                sb.Append(GetValue(cell.Description));
                sb.Append(GetValue(cell.Solution));
                sb.Append(GetValue(cell.Comments));                

                sb.Append("</tr>");
            }

            sb.Append("</table></body></html>");

            return sb.ToString();
        }

        private string GetValue(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td>");
            sb.Append(input.Replace("<body>", "").Replace("</body>", "")
                .Replace("<html>", "").Replace("</html>", ""));
            sb.Append("</td>");

            return sb.ToString();
        }



    }
}
