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
    public partial class Form1 : Form
    {
        private int defaultWidth = 190;
        private int defaultHeight = 80;
        private int spacingX = 5;
        private int spacingY = 5;
        private bool showReady = false;

        public Form1()
        {
            InitializeComponent();
            RefreshDataGrid();
            RefreshSolutions();
        }

        private void RefreshDataGrid()
        {
            User user = CentralManager.Instance.currentUser;
            dataGridView1.Rows.Clear();
            foreach (Daily dl in user.dailys)
            {
                if (dl.endDate == null || showReady)
                {
                    try
                    {
                        int rowNumber = dataGridView1.Rows.Add();

                        dataGridView1.Rows[rowNumber].Cells[0].Value = user.dailys.IndexOf(dl);
                        dataGridView1.Rows[rowNumber].Cells[1].Value = dl.startDate.ToString();
                        dataGridView1.Rows[rowNumber].Cells[2].Value = (dl.endDate != null);
                        dataGridView1.Rows[rowNumber].Cells[3].Value = dl.number;
                        dataGridView1.Rows[rowNumber].Cells[4].Value = dl.text;
                        dataGridView1.Rows[rowNumber].Cells[5].Value = dl.endDate != null ? dl.endDate.ToString() : string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NewCallForm tempForm = new NewCallForm();
            tempForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolutionsForm tempForm = new SolutionsForm();
            tempForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Daily dl = Prompt.AddNewDailyDialog();
            if (dl != null)
            {
                CentralManager.Instance.currentUser.dailys.Add(dl);

                int rowNumber = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowNumber].Cells[0].Value = CentralManager.Instance.currentUser.dailys.IndexOf(dl);
                dataGridView1.Rows[rowNumber].Cells[1].Value = dl.startDate.ToString();
                dataGridView1.Rows[rowNumber].Cells[2].Value = (dl.endDate != null);
                dataGridView1.Rows[rowNumber].Cells[3].Value = dl.number;
                dataGridView1.Rows[rowNumber].Cells[4].Value = dl.text;
                dataGridView1.Rows[rowNumber].Cells[5].Value = dl.endDate != null ? dl.endDate.ToString() : string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showReady = !showReady;
            RefreshDataGrid();
            RefreshSolutions();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            int numOfVal = (int)dg.Rows[e.RowIndex].Cells[0].Value;

            Daily daily = CentralManager.Instance.currentUser.dailys[numOfVal];
            daily.End(!daily.isDone);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Действительно выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Приложение будет закрыто. Данные сохранятся");
                CentralManager.Instance.EndManager();
            }
            else e.Cancel = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshProblems();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RefreshSolutions();
        }



        private Button CreateButton(string text, EventHandler clickMethod)
        {
            Button button = new Button()
            {
                Text = text,
                Size = new Size(defaultWidth, defaultHeight),
                BackColor = Color.White,
            };

            button.Click += new EventHandler(clickMethod);
            panel1.Controls.Add(button);
            this.Controls.Add(panel1);

            return button;
        }

        private void RefreshSolutions()
        {
            panel1.Controls.Clear();
            List<Solution> tempArray = new List<Solution>();

            for (int i = 0; i < CentralManager.Instance.solutions.Count; i++)
            {
                Solution solution = CentralManager.Instance.solutions[i];
                if (solution.heat > 0 && solution.isActual)
                    tempArray.Add(solution);
                else
                {
                    TimeSpan span = DateTime.Now.Date - solution.lastChangingDateTime.Date;                   
                    if (span.Days < 7)
                        tempArray.Add(solution);
                }
            }

            int count = tempArray.Count;
            if (count > 21) count = 21;
            tempArray.Sort();

            for (int i = 0; i < count; i++)
            {
                Solution solution = tempArray[i];
                Button button = CreateButton(solution.shortDescription,
                    ClickOnSolution);

                button.Name = solution.id;

                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void RefreshProblems()
        {
            CentralManager.Instance.problems.Sort();
            panel1.Controls.Clear();
            int count = CentralManager.Instance.problems.Count;
            if (count > 21) count = 21;

            List<Problem> problems = new List<Problem>();
            for (int i = 0; i < count; i++)
            {
                Problem problem = CentralManager.Instance.problems[i];
                if (!problem.isSolved && problem.isActual)
                {
                    problems.Add(problem);
                }
            }


            for (int i = 0; i < problems.Count; i++)
            {
                Problem problem = problems[i];

                Button button = CreateButton(problem.name, ClickOnProblem);
                button.Name = problem.id;
                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);

            }
        }



        private void ClickOnSolution(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            Solution solution = CentralManager.Instance.GetSolutions(name);
            OpenSolution form = new OpenSolution(solution);
            form.ShowDialog();
            RefreshSolutions();
        }

        private void ClickOnProblem(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            Problem problem = CentralManager.Instance.GetProblem(name);
            ProblemForm form = new ProblemForm(problem);
            form.ShowDialog();
            RefreshProblems();
        }
    }
}
