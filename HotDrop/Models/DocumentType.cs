using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrop.Models
{
    public class DocumentType : Item
    {
        public virtual List<KnowledgeCell> KnowledgeCells { get; set; }
    }
}
