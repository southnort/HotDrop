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
            webBrowser1.DocumentText = dataBase.GetTrouble(problemID);
           // richTextBox1.Text = dataBase.GetTrouble(problemID);         

            webBrowser2.DocumentText = dataBase.GetSolution(problemID);
          //  richTextBox2.Text = dataBase.GetSolution(problemID);

            webBrowser3.DocumentText = dataBase.GetComments(problemID);         
          //  richTextBox3.Text = dataBase.GetComments(problemID);
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
