using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Archiever
{

    [Serializable]
    public class Section
    {
        public string name { get; private set; }
        public DateTime creationDate { get; private set; }
        public User createdBy { get; private set; }
        public bool isActual { get; private set; }
        public List<string> problemsIDs;

        public Section(string name, User createdBy)
        {
            this.name = name;
            this.createdBy = createdBy;
            creationDate = DateTime.Now;
            isActual = true;
            problemsIDs = new List<string>();
        }

        public void SetActual(bool val)
        {
            isActual = val;
        }
    }


    [Serializable]
    public class Problem : IComparable, IDisplayable
    {
        private Guid guid;
        public string id { get { return guid.ToString(); } }
        public string name { get; private set; }
        public Section section { get; private set; }
        public User createdBy { get; private set; }
        public DateTime creatingDateTime { get; private set; }
        public User changedBy { get; private set; }
        public DateTime lastChangingDateTime { get; private set; }
        public bool isActual { get; private set; }
        public bool isSolved { get; private set; }
        public float heat { get; private set; }
        public string description { get; private set; }
        public List<string> solutionsIDs;
        public string comments;


        public Problem(Section section, User createdUser)
        {
            guid = Guid.NewGuid();
            this.section = section;

            createdBy = createdUser;
            creatingDateTime = DateTime.Now;
            changedBy = createdUser;
            lastChangingDateTime = DateTime.Now;

            isActual = true;
            isSolved = false;
            heat = 30f;
            solutionsIDs = new List<string>();
            comments = string.Empty;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Problem other = obj as Problem;
            if (heat > other.heat)
                return 0;
            else if (heat < other.heat)
                return 1;

            else
            {
                if (lastChangingDateTime > other.lastChangingDateTime)
                    return 0;
                else return 1;
            }
        }

        public void Solved(bool solved, User user)
        {
            isSolved = solved;
            changedBy = user;
            lastChangingDateTime = DateTime.Now;
        }


        private void Changed(User user)
        {
            lastChangingDateTime = DateTime.Now;
            changedBy = user;
        }

        public void SetName(string name, User user)
        {
            this.name = name;
            Changed(user);
        }

        public void SetDescription(string text, User user)
        {
            description = text;
            Changed(user);
        }

        public void IncreaseHeat()
        {
            heat++;
        }


        public string NameForButton()
        {
            return name;
        }

        public bool ContainsString(string value)
        {
            if (name.Contains(value)) return true;
            if (description.Contains(value)) return true;
            if (comments.Contains(value)) return true;

            return false;
        }

        public string ReturnType()
        {
            return "Problem";
        }

        public string GetID()
        {
            return id;
        }
    }


    [Serializable]
    public class Solution : IComparable, IDisplayable
    {
        public Problem problem { get; private set; }
        public string shortDescription { get; private set; }
        public string description { get; private set; }
        public User createdBy { get; private set; }
        public DateTime creatingDateTime { get; private set; }
        public User changedBy { get; private set; }
        public DateTime lastChangingDateTime { get; private set; }
        public string comment { get; private set; }
        public bool isActual { get; private set; }
        public float heat { get; private set; }
        public string id { get { return guid.ToString(); } }
        private Guid guid;

        public Solution(Problem problem, User creatUser)
        {
            guid = Guid.NewGuid();
            this.problem = problem;
            this.description = description;
            isActual = true;
            heat = 15;
            createdBy = creatUser;
            creatingDateTime = DateTime.Now;
            this.problem.Solved(true, CentralManager.Instance.currentUser);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Solution other = (Solution)obj;
            if (heat > other.heat)
                return -1;
            if (heat < other.heat)
                return 0;

            else
            {
                if (lastChangingDateTime > other.lastChangingDateTime)
                    return -1;
                else return 0;
            }

        }

        public void IncreaseHeat()
        {
            heat++;
        }

        public void CoolDown()
        {
            heat *= 0.7f;
            if (heat < 1) heat = 0;
        }

        private void Changed(User user)
        {
            lastChangingDateTime = DateTime.Now;
            changedBy = user;
        }

        public void SetShortDescription(string text, User user)
        {
            shortDescription = text;
            Changed(user);
        }

        public void SetDescription(string text, User user)
        {
            description = text;
            Changed(user);
        }

        public void SetComment(string text, User user)
        {
            comment = text;
            Changed(user);
        }

        public void SetActual(bool val, User user)
        {
            isActual = val;
            Changed(user);
        }


        public string NameForButton()
        {
            return shortDescription;
        }

        public bool ContainsString(string value)
        {
            if (!isActual) return false;
            try
            {
                if (shortDescription.Contains(value)) return true;
                if (description.Contains(value)) return true;
                if (comment.Contains(value)) return true;

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - \n" + shortDescription +
                    "\n" + description +
                    "\n" + comment +
                    ex.ToString());

                return false;
            }
        }

        public string ReturnType()
        {
            return "Solution";
        }

        public string GetID()
        {
            return id;
        }
    }


    public interface IDisplayable
    {
        string ReturnType();
        string NameForButton();
        string GetID();
        bool ContainsString(string value);
    }


    [Serializable]
    public class User
    {
        public string login { get; private set; }
        string password;
        int levelOfAccess;
        string sessionID;
        public List<Daily> dailys;

        public User(string name, string pass)
        {
            login = name;
            password = pass;
            dailys = new List<Daily>();
        }
    }



    [Serializable]
    public class Daily
    {
        public Daily(string num, string message)
        {
            number = num;
            isDone = false;
            text = message;
            startDate = DateTime.Now.ToString();
        }

        public void End(bool val)
        {
            isDone = val;
            if (val)
                endDate = DateTime.Now.ToString();
            else
                endDate = null;
        }



        public string number { get; private set; }
        public bool isDone { get; private set; }
        public string text { get; private set; }
        public string startDate { get; private set; }
        public string endDate { get; private set; }
    }



    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,

            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 40, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static Daily AddNewDailyDialog()
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,

            };
            Label textLabel = new Label() { Left = 50, Top = 10, Text = "Титул:", Width = 300 };
            TextBox textBox = new TextBox() { Left = 50, Top = 25, Width = 150 };
            Label label2 = new Label() { Left = 50, Top = 60, Text = "Краткое описание:", Width = 300 };
            RichTextBox textBox2 = new RichTextBox() { Left = 50, Top = 75, Width = 290, Height = 90, BorderStyle = BorderStyle.None };
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 180, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(label2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? CheckEntrie(textBox.Text, textBox2.Text) : null;
        }

        private static Daily CheckEntrie(string num, string text)
        {
            if (num == null || null == "")
                return null;

            else return new Daily(num, text);
        }
    }

}


