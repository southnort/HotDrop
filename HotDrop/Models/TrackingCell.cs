using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrop.Models
{
    public class TrackingCell
    {
        public int IsDone { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public int Id { get; set; }


        public TrackingCell()
        {
            
        }

        public TrackingCell(string number, string description)
        {
            IsDone = 0;
            Number = number;
            Description = description;
            CreationDate = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
        }


        
    }
}
