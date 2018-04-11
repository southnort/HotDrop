using System;
using System.IO.Packaging;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



public class DataBase
{
    private Dictionary<string, DataBaseElement> elements;

    public DataBase(Table table)
    {
        elements = new Dictionary<string, DataBaseElement>();
        InitializeDataBase(table);
    }

    private void InitializeDataBase(Table table)
    {

        var rows = table.Elements<TableRow>();
        foreach (var row in rows)
        {
            DataBaseElement element = new DataBaseElement(row);
            elements.Add(element.number, element);
        }


    }





    private bool ContainsID(string id)
    {
        return elements.ContainsKey(id);
    }

    public string GetTrouble(string id)
    {
        if (ContainsID(id))
            return elements[id].troubleDescription;
        else return "ID " + id + " отсутствует в списке";

    }

    public string GetSolution(string id)
    {
        if (ContainsID(id))
            return elements[id].solutionDescription;
        else return "ID " + id + " отсутствует в списке";

    }

    public string GetComments(string id)
    {
        if (ContainsID(id))
            return elements[id].comms;
        else return "ID " + id + " отсутствует в списке";

    }

    public List<string> GetTags()
    {
        List<string> temp = new List<string>();

        foreach (var pair in elements)
        {
            string[] input = pair.Value.GetTags();
            for (int i = 0; i < input.Length; i++)
            {
                string val = input[i];
                if (!temp.Contains(val))
                    temp.Add(val);
            }   
        }

        return temp;
    }

    public List<string> AllIDs()
    {
        return elements.Keys.ToList();
    }


    private class DataBaseElement
    {
        public string number { get; private set; }
        private string tags;
        public string troubleDescription { get; private set; }
        public string solutionDescription { get; private set; }
        public string comms { get; private set; }


        public DataBaseElement(TableRow row)
        {
            foreach (TableCell cell in row.Elements<TableCell>())
            {
                if (number == null)
                    number = cell.InnerText;
                else if (tags == null)
                    tags = cell.InnerText;
                else if (troubleDescription == null)
                    troubleDescription = cell.InnerXml;
                else if (solutionDescription == null)
                    solutionDescription = cell.InnerXml;
                else if (comms == null)
                    comms = cell.InnerXml;

            }


        }

        public string[] GetTags()
        {
            string str = tags;
            string[] result = str.Split(',');
            return result;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Start#######################");
            sb.Append("\n" + number);
            // sb.Append("\n\n" + Tags);
            sb.Append("\n\n" + troubleDescription);
            sb.Append("\n\n" + solutionDescription);
            sb.Append("\n\n" + comms);
            sb.Append("#######################################END");
            return sb.ToString();
        }
    }


}



public class WordReader
{

    public DataBase ReadWordFileToBase(string filePath)
    {
        using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, false))
        {
            StringBuilder sb = new StringBuilder();
            Table table = wordDocument.MainDocumentPart.Document.Body.Elements<Table>().First();
            DataBase dataBase = new DataBase(table);
            return dataBase;
        }


    }

    /*
    public static DataBase ReadWordFileToBase(string filePath)
    {
        DataBase dataBase = new DataBase();

        using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, false))
        {
            Table table = wordDocument.MainDocumentPart.Document.Body.Elements<Table>().First();
            var rows = table.Elements<TableRow>();
            foreach (var row in rows)
            {
                dataBase.AddElement(row);

            }

            Console.WriteLine("Success!!");
            return dataBase;

        }


    }
    */


}




