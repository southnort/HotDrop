using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HotDrop.Models;


namespace HotDrop
{
    class HotDropContext : DbContext
    {
        public HotDropContext() : base("DbConnection")
        {
            
        }

        public DbSet<CallCell> CallCells { get; set; }

    }
}
