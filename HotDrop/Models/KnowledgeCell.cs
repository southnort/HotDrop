using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace HotDrop.Models
{
    public class KnowledgeCell : IComparable
    {
        public int Id { get; set; }
        public string CreationDate { get; set; }
        public List<DocumentType> DocumentTypes { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string Comments { get; set; }
        public List<Tag> Tags { get; set; }
        public float Heat { get; set; }


        public KnowledgeCell(string str)
        {
            CreationDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            Heat = 75f;

            SetDocumetTypes("");
            SetTags("");
        }

        public KnowledgeCell()
        {
        }

        public void SetDocumetTypes(string text)
        {
            var list = new List<DocumentType>();
            var types = text.Split(',');
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = types[i].Replace(" ", "");
            }
            foreach (var item in types)
            {
                if (item != "" && item != " ")
                {

                    var type = Program.dataBase.DocumentTypes
                        .FirstOrDefault(x => x.Name == item);
                    if (type == null)
                    {
                        type = new DocumentType { Name = item };
                        Program.dataBase.DocumentTypes.Add(type);
                        Program.dataBase.SaveChanges();
                    }

                    list.Add(type);
                }
            }

            DocumentTypes = list;
            Program.dataBase.SaveChanges();
        }

        public void SetTags(string text)
        {
            var list = new List<Tag>();
            var tags = text.Split(',');
            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = tags[i].Replace(" ", "");
            }
            foreach (var item in tags)
            {
                if (item != "" && item != " ")
                {
                    var tag = Program.dataBase.Tags
                    .FirstOrDefault(x => x.Name == item);
                    if (tag == null)
                    {
                        tag = new Tag { Name = item };
                        Program.dataBase.Tags.Add(tag);
                        Program.dataBase.SaveChanges();
                    }

                    list.Add(tag);
                }
            }

            Tags = list;
            Program.dataBase.SaveChanges();
        }

        public string GetTypesString()
        {
            var result = "";

            if (DocumentTypes != null)
                foreach (var item in DocumentTypes)
                    result += item.Name + ", ";


            return result;
        }

        public string GetTagsString()
        {
            var result = "";

            if (Tags != null)
                foreach (var item in Tags)
                    result += item.Name + ", ";
            return result;
        }

        int IComparable.CompareTo(object obj)
        {
            var other = (KnowledgeCell)obj;
            if (Heat > other.Heat) return 1;
            else if (Heat < other.Heat) return -1;
            else
            {
                var date1 = DateTime.ParseExact(CreationDate, "yyyy-MM-dd-HH-mm", CultureInfo.InvariantCulture);
                var date2 = DateTime.ParseExact(other.CreationDate, "yyyy-MM-dd-HH-mm", CultureInfo.InvariantCulture);

                if (date1 > date2)

                    return 1;
                else
                    return -1;

            }


        }
    }
}
