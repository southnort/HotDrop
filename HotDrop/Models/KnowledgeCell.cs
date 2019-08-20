using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotDrop.Models
{
    class KnowledgeCell
    {
        public int Id { get; set; }
        public string CreationDate { get; set; }
        public List<DocumentType> DocumentTypes { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string Comments { get; set; }
        public List<Tag> Tags { get; set; }
        public float Heat { get; set; }


        //public KnowledgeCell(string type, string descr, string solution, 
        //    string comments,string tags)
        //{
        //    CreationDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
        //    DocumentTypes = GetTypes(type);
        //    Description = descr;
        //    Solution = solution;
        //    Comments = comments;
        //    Tags = GetTags(tags);
        //    Heat = 75f;
        //}

        //private List<DocumentType> GetTypes(string type)
        //{
        //    var types = type.Split(',');
        //    var list = new List<DocumentType>();
        //}

        //private List<Tag> GetTags(string tags)
        //{

        //}



    }
}
