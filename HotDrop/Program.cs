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
        private static string dbFileName_debug = "HotDropDataBaseDebug.sqlite";

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

#if (DEBUG)
            {
                DataBaseCreator creator = new DataBaseCreator();
                creator.CreateMainDataBase(dbFileName_debug);
                creator.UpdateTables(dbFileName_debug);
                creator = null;
                dataBase = new DataBaseManager();
                dataBase.ConnectToDataBase(dbFileName_debug);
            }
#else
            {
                DataBaseCreator creator = new DataBaseCreator();
                creator.CreateMainDataBase(dbFileName);
                creator.UpdateTables(dbFileName);
                creator = null;
                dataBase = new DataBaseManager();
                dataBase.ConnectToDataBase(dbFileName);
            }

#endif
        }
    }
}
