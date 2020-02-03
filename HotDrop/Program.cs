using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotDrop
{
    static class Program
    {        
        public static HotDropContext dataBase;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartDataBases();

            Application.Run(new MainForm());
        }

        private static void StartDataBases()
        {
            //настраиваем соединения с БД            
            dataBase = new HotDropContext();                  
        }
    }
}
