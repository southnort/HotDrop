using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrop.Models
{
    public class KnowledgeCellType
    {
        public int KnowledgeCellId { get; set; }
        public KnowledgeCell KnowledgeCell { get; set; }

        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }
}
