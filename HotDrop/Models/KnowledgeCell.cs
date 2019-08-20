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
        public List<string> Types { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string Comments { get; set; }
        public List<string> Tags { get; set; }
        public float Heat { get; set; }


        public KnowledgeCell(string type, string descr, string solution, string comments)
        {
            CreationDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            var types = type.Split(',');
            Types = types.ToList();
            Description = descr;
            Solution = solution;
            Comments = comments;
            Heat = 75f;
        }



        private int GetInt(object val)
        {
            return CommonMethods.GetInt(val);
        }

        private string GetStr(object val)
        {
            return CommonMethods.GetStr(val);
        }

        private float GetFloat(object val)
        {
            return CommonMethods.GetFloat(val);
        }




    }
}
