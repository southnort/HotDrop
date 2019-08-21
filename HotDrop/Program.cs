using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotDrop
{
    static class Program
    {
        public static DataBaseManager manager;
        private static string dbFileName = "HotDropDataBase.sqlite";
        private static string dbFileName_debug = "HotDropDataBaseDebug.sqlite";
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
            int num = dataBase.CallCells.Count();

            //manager = new DataBaseManager();
            //manager.ConnectToDataBase(dbFileName_debug);
            //var table = manager.GetTable("SELECT * FROM CallCells");            
            //foreach (System.Data.DataRow row in table.Rows)
            //{
            //    var old = new Models.CallCellOld(row);
            //    dataBase.CallCells.Add(new Models.CallCell
            //    {
            //        Id = old.id,
            //        Inn = old.inn,
            //        ClientName = old.clientName,
            //        PhoneNumber = old.phoneNumber,
            //        Descr = old.descr,
            //        CallDateTime = old.callDateTime,
            //        Logged = old.logged,               
            //    });
            //}
            //dataBase.SaveChanges();



            //#if (DEBUG)
            //            {
            //                DataBaseCreator creator = new DataBaseCreator();
            //                creator.CreateMainDataBase(dbFileName_debug);
            //                creator.UpdateTables(dbFileName_debug);
            //                creator = null;
            //                dataBase = new DataBaseManager();
            //                dataBase.ConnectToDataBase(dbFileName_debug);
            //            }
            //#else
            //            {
            //                DataBaseCreator creator = new DataBaseCreator();
            //                creator.CreateMainDataBase(dbFileName);
            //                creator.UpdateTables(dbFileName);
            //                creator = null;
            //                dataBase = new DataBaseManager();
            //                dataBase.ConnectToDataBase(dbFileName);
            //            }

            //#endif
        }
    }
}
