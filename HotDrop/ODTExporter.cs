using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotDrop.Models;
using Independentsoft.Office.Odf;
using HtmlAgilityPack;

namespace HotDrop
{
    public class ODTExporter
    {
        public void ExportToFile(List<KnowledgeCell> cells, string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                + "\\" + fileName;

            var doc = CreateDocument(cells);
            doc.Save(path, true);
        }

        private TextDocument CreateDocument(List<KnowledgeCell> cells)
        {
            TextDocument doc = new TextDocument();
            Cell cell1 = new Cell("Тип");
            Cell cell2 = new Cell("Описание проблемы");
            Cell cell3 = new Cell("Решение");
            Cell cell4 = new Cell("Комментарии");


            Row headerRow = new Row();
            headerRow.Cells.Add(cell1);
            headerRow.Cells.Add(cell2);
            headerRow.Cells.Add(cell3);
            headerRow.Cells.Add(cell4);

            Table table = new Table();
            table.Rows.Add(headerRow);

            foreach (var item in cells)
            {
                var row = new Row();
                var c1 = BuildCell(item.GetTypesString());
                var c2 = BuildCell(item.Description);
                var c3 = BuildCell(item.Solution);
                var c4 = BuildCell(item.Comments);

                row.Cells.Add(c1);
                row.Cells.Add(c2);
                row.Cells.Add(c3);
                row.Cells.Add(c4);

                table.Rows.Add(row);
            }

            doc.Body.Add(table);

            return doc;
        }

        private Cell BuildCell(string input)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(input);
            //doc.DocumentNode.InnerHtml = input;

            var cell = new Cell();
            cell.Value = UnbuildHtmlNode(doc.DocumentNode);

            return cell;
        }

        private string UnbuildHtmlNode(HtmlNode node)
        {
            string result = node.InnerText;
            foreach (var child in node.ChildNodes)
                result += UnbuildHtmlNode(child);

            return result;
        }





    }
}
