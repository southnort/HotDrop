using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Archiever
{
    public class CentralManager
    {
        private string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "ArchieverDataBase.bin";
        private string userSaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "ArchieverUser.bin";


        private static CentralManager instance = new CentralManager();
        public static CentralManager Instance { get { return instance; } }
        private Keeper keeper;
        public User currentUser;

        public void StartManager()
        {
            keeper = LoadSerializedOb<Keeper>(saveFilePath);
            currentUser = LoadSerializedOb<User>(userSaveFilePath);

            if (keeper == null) keeper = new Keeper();
            if (currentUser == null) currentUser = new User("Admin", "admin");
        }
           

        public void EndManager()
        {
            SaveSerializedOb(keeper, saveFilePath);
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
    }


    [Serializable]
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
