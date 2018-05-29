using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Net;


namespace Archiever
{
    public class CentralManager
    {
        private string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
            "ArchieverDataBase.bin";
        private string userSaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
            "ArchieverUser.bin";

        private string dataBaseFilePath = //@"D:\Файлы\ЛО шпаргалка.xhtml";
            @"ЛО шпаргалка.xhtml";

        private string serviceURL = @"https://getfile.dokpub.com/yandex/get/";
        private string dataBaseFileOnYandex = @"https://yadi.sk/d/jnAgqRVZ3ULupT";

        private string dataBaseFileURL { get { return serviceURL + dataBaseFileOnYandex; } }

        private static CentralManager instance = new CentralManager();
        public static CentralManager Instance { get { return instance; } }
        private Keeper keeper;
        public User currentUser;

        public DataBase dataBase;

        private List<string> _documentsNames;

        public List<string> documentsNames
        {
            get
            {
                if (_documentsNames == null)
                    CreateDocumentsNames();
                return _documentsNames;
            }
        }

        private void CreateDocumentsNames()
        {           
            WordReader reader = new WordReader();
            dataBase = reader.ReadWordFileToBase(dataBaseFilePath);
          
            _documentsNames = dataBase.GetTags();

        }


        public void StartManager()
        {
            //   keeper = LoadSerializedOb<Keeper>(saveFilePath);
            ReloadFile();

            currentUser = LoadSerializedOb<User>(userSaveFilePath);

            if (keeper == null) keeper = new Keeper();
            if (currentUser == null) currentUser = new User("Admin", "admin");


            foreach (Solution sol in keeper.solutions)
            {
                sol.CoolDown();
            }
        }


        public void EndManager()
        {
        //    SaveSerializedOb(keeper, saveFilePath);
            SaveSerializedOb(currentUser, userSaveFilePath);
        }


        private T LoadSerializedOb<T>(string filePath)
        {

            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        T tempOb = (T)bf.Deserialize(fs);
                        return tempOb;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return default(T);
                }
            }
            else
            {
                return default(T);
            }
        }

        private void SaveSerializedOb(object serializedOb, string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, serializedOb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public List<Section> sections { get { return keeper.sections; } }
        public List<Problem> problems { get { return keeper.problems; } }
        public List<Solution> solutions { get { return keeper.solutions; } }
        public List<User> users { get { return keeper.users; } }

        public Problem GetProblem(string id)
        {
            foreach (Problem pr in keeper.problems)
            {
                if (pr.id == id)
                    return pr;
            }
            throw new Exception("Не найдена такая проблема! " + id);
        }

        public Solution GetSolutions(string id)
        {
            foreach (Solution sol in keeper.solutions)
            {
                if (sol.id == id)
                    return sol;
            }
            throw new Exception("Не найдено такое решение! " + id);
        }


        ///////////////////////////////////////
        // новый код
        ///////////////////////////////////////

        private void ReloadFile()
        {


            if (File.Exists(dataBaseFilePath))
            {
                if (File.Exists(dataBaseFilePath + "_tmp"))
                    File.Delete(dataBaseFilePath + "_tmp");

                File.Move(dataBaseFilePath, dataBaseFilePath + "_tmp");
            }


            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(new Uri(dataBaseFileURL), dataBaseFilePath);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (File.Exists(dataBaseFilePath + "_tmp"))
                    File.Move(dataBaseFilePath + "_tmp", dataBaseFilePath);
            }

           



        }

    }



    public class Keeper
    {
        public List<User> users;

        public List<Section> sections;
        public List<Problem> problems;
        public List<Solution> solutions;

        public Keeper()
        {
            users = new List<User>();
            sections = new List<Section>();
            problems = new List<Problem>();
            solutions = new List<Solution>();
        }
    }
}
