using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archiever
{
    public partial class ProblemForm : Form
    {
        private DataBase dataBase;
        private string problemID;

        public ProblemForm(string problemID)
        {
            InitializeComponent();
            dataBase = CentralManager.Instance.dataBase;
            this.problemID = problemID;

            InitializeProblem();
        }

        private void InitializeProblem()
        {
            webBrowser1.DocumentText = CommentWithDate(dataBase.GetTrouble(problemID));
           // richTextBox1.Text = dataBase.GetTrouble(problemID);         

            webBrowser2.DocumentText = CommentWithDate(dataBase.GetSolution(problemID));
          //  richTextBox2.Text = dataBase.GetSolution(problemID);

            webBrowser3.DocumentText = CommentWithDate(dataBase.GetComments(problemID));         
          //  richTextBox3.Text = dataBase.GetComments(problemID);
        }

        private string CommentWithDate(string text)
        {
            if (text == null) return null;
            else if (text.Contains("#NextDate#"))
            {
                DateTime needDateTime = DateTime.Now.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Sunday) needDateTime = needDateTime.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Saturday) needDateTime = needDateTime.AddDays(2);

                return text.Replace("#NextDate#", needDateTime.ToString("dd.MM.yyyy"));
            }

            else return text;
        }





        private void ProblemForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
