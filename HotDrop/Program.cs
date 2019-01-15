using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotDrop
{
    static class Program
    {
        public static DataBaseManager dataBase;
        private static string dbFileName = "HotDropDataBase.sqlite";

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


            DataBaseCreator creator = new DataBaseCreator();
            creator.CreateMainDataBase(dbFileName);
            creator.UpdateTables(dbFileName);
            creator = null;

            
            dataBase = new DataBaseManager();
            dataBase.ConnectToDataBase(dbFileName);
        }

    }
}
