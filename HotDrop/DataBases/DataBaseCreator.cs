using System.Data.SQLite;
using System.IO;
using System.Text;

namespace HotDrop
{
    class DataBaseCreator
    {
        //класс, отвечающий за создание баз данных       

        public void CreateMainDataBase(string dbFileName)
        {
            string commandString = CreateCommandString_CalCellsTable();
            CreateDataBase(dbFileName, commandString);

        }
               
        public void UpdateTables(string dbFileName)
        {
            //обновить существующие таблицы, добавить в них новые колонки


            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            m_dbConn.Open();

            SQLiteCommand m_sqlCmd = new SQLiteCommand();
            m_sqlCmd.Connection = m_dbConn;


            

        }





        private void CreateDataBase(string dbFileName, string commandString)
        {
            //если нет БД - создать её. Если есть БД, 
            //добавить в неё всё отсутствующие таблицы из commandString


            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            m_dbConn.Open();

            SQLiteCommand m_sqlCmd = new SQLiteCommand();
            m_sqlCmd.Connection = m_dbConn;
            m_sqlCmd.CommandText = commandString;
            m_sqlCmd.ExecuteNonQuery();

        }



        //описания таблиц в базе данных

        private string CreateCommandString_CalCellsTable()
        {
            //создать commandString для таблицы учёта звонков
            StringBuilder sb = new StringBuilder();
            sb.Append("CREATE TABLE IF NOT EXISTS CallCells (");

            sb.Append("id INTEGER PRIMARY KEY AUTOINCREMENT, ");
            sb.Append("inn TEXT, ");
            sb.Append("clientName TEXT, ");
            sb.Append("phoneNumber TEXT, ");
            sb.Append("descr TEXT, ");
            sb.Append("callDateTime TEXT, ");
            sb.Append("logged INTEGER");


            sb.Append(")");
            return sb.ToString();
        }

    }

}
