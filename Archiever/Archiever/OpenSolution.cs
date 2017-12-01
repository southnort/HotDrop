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
    public partial class OpenSolution : Form
    {
        private Solution solution;

        public OpenSolution(Solution solution)
        {
            this.solution = solution;
            this.solution.IncreaseHeat();
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            richTextBox1.Text = solution.problem.name + "\n\n" +
                solution.problem.description;
            richTextBox4.Text = solution.shortDescription;
            richTextBox2.Text = solution.description;
            richTextBox3.Text = CommentWithDate(solution.comment);
            checkBox1.Checked = solution.isActual;   
        }

        private string CommentWithDate(string text)
        {
            if (text == null) return null;
            if (text.Contains("<NextDate>"))
            {
                DateTime needDateTime = DateTime.Now.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Sunday) needDateTime.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Saturday) needDateTime.AddDays(2);

                text = text.Replace("<NextDate>", needDateTime.ToString("dd.MM.yyyy"));
            }
            return text;
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            solution.SetShortDescription(richTextBox4.Text, CentralManager.Instance.currentUser);            
            solution.SetDescription(richTextBox2.Text, CentralManager.Instance.currentUser);            
            solution.SetComment(richTextBox3.Text, CentralManager.Instance.currentUser);            
            solution.SetActual(checkBox1.Checked, CentralManager.Instance.currentUser);

            if (!CentralManager.Instance.solutions.Contains(solution))
            {
                solution.problem.solutionsIDs.Add(solution.id);
                CentralManager.Instance.solutions.Add(solution);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
