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
        public bool isActual;

        public Section(string name,User createdBy)
        {
            this.name = name;
            this.createdBy = createdBy;
            creationDate = DateTime.Now;
            isActual = true;
        }       
    }


    [Serializable]
    public class Problem : IComparable
    {
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
        public List<Solution> solutions;
        

        public Problem(Section section, User createdUser)
        {            
            this.section = section;           

            createdBy = createdUser;
            creatingDateTime = DateTime.Now;

            isActual = true;
            isSolved = false;
            heat = 30f;
            solutions = new List<Solution>();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Problem other = obj as Problem;
            return this.heat.CompareTo(other.heat);
        }

        public void Solved(bool solved, User user)
        {
            isSolved = solved;
            changedBy = user;
            lastChangingDateTime = DateTime.Now;
        }


    }


    [Serializable]
    public class Solution
    {
        public Problem problem { get; private set; }
        public string shortDescription { get; private set; }
        public string description { get; private set; }
        public User createdBy { get; private set; }
        public DateTime creatingDateTime { get; private set; }
        public User changedBy { get; private set; }
        public DateTime lastChangingDateTime { get; private set; }
        public List<string> comments;
        public bool isActual { get; private set; }
        public float heat { get; private set; }

        public Solution(Problem problem, string description, User creatUser, string firstComment = null)
        {
            this.problem = problem;
            this.description = description;
            comments = new List<string>();
            if (firstComment != null) comments.Add(firstComment);
            isActual = true;
            heat = 1;
            createdBy = creatUser;
            creatingDateTime = DateTime.Now;
            this.problem.Solved(true, CentralManager.Instance.currentUser);         
        }
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
            this.number = num;
            this.isDone = false;           
            this.text = message;
            this.startDate = DateTime.Now.ToString();
        }

        public void End(bool val)
        {
            this.isDone = val;
            if (val)
                this.endDate = DateTime.Now.ToString();
            else
                this.endDate = null;
        }



        public string number { get; private set; }
        public bool isDone { get; set; }       
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
