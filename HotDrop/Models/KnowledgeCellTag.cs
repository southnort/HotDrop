using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrop.Models
{
    public class KnowledgeCellTag
    {
        public int KnowledgeCellId { get; set; }
        public KnowledgeCell KnowledgeCell { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
