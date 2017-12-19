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
            webBrowser1.DocumentText = CommentWithDate(solution.comment);
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


        private Form ChangeComment(Solution solution)
        {
            Form form = new Form()
            {
                Width = 400,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
            };
            RichTextBox textBox2 = new RichTextBox() { Left = 10, Top = 15, Width = 320, Height = 150, BorderStyle = BorderStyle.None };
            textBox2.Text = solution.comment;
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 180, DialogResult = DialogResult.OK };
            confirmation.Focused = false;
            confirmation.Click += (sender, e) => { solution.SetComment(textBox2.Text, CentralManager.Instance.currentUser); };
            confirmation.Click += (sender, e) => { form.Close(); };
            form.Controls.Add(textBox2);
            form.Controls.Add(confirmation);
            form.Controls.Add(label2);
            form.AcceptButton = confirmation;
            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = ChangeComment(solution);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                webBrowser1.DocumentText = solution.comment;
        }
                            

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solution.SetShortDescription(richTextBox4.Text, CentralManager.Instance.currentUser);
            solution.SetDescription(richTextBox2.Text, CentralManager.Instance.currentUser);
            solution.SetActual(checkBox1.Checked, CentralManager.Instance.currentUser);

            if (!CentralManager.Instance.solutions.Contains(solution))
            {
                solution.problem.solutionsIDs.Add(solution.id);
                CentralManager.Instance.solutions.Add(solution);
            }

            this.Close();
        }
    }
}
