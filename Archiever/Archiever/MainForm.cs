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
    public partial class MainForm : Form
    {
        private int defaultWidth = 190;
        private int defaultHeight = 80;
        private int spacingX = 10;
        private int spacingY = 10;
        private bool showAllDaily = true;       //если false - в таблице отображаются только выполненные задания. 
                                                //Если true - то все

        private int indexOfCurrentWindow = 0;

        public MainForm()
        {
            InitializeComponent();
            RefreshDataGrid();
            RefreshSolutions();
            Text = "HotBlob                  ver. " + Application.ProductVersion;

            CreateTabControl();
          
        }

        private void CreateTable()
        {


        }


        private void RefreshDataGrid()
        {
            User user = CentralManager.Instance.currentUser;
            dataGridView1.Rows.Clear();
            foreach (var dl in user.dailys)
            {
                if (showAllDaily)
                {
                    AddDailyToDataGridView(dl);

                }
                else
                {
                    if (!dl.isDone)
                        AddDailyToDataGridView(dl);
                }
             
            }

        }

        private void AddDailyToDataGridView(Daily dl)
        {
            User user = CentralManager.Instance.currentUser;
            try
            {
                int rowNumber = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowNumber].Cells[0].Value = user.dailys.IndexOf(dl);
                dataGridView1.Rows[rowNumber].Cells[1].Value = dl.startDate.ToString();
                dataGridView1.Rows[rowNumber].Cells[2].Value = dl.isDone;
                dataGridView1.Rows[rowNumber].Cells[3].Value = dl.number;
                dataGridView1.Rows[rowNumber].Cells[4].Value = dl.text;
                dataGridView1.Rows[rowNumber].Cells[5].Value = dl.endDate != null ? dl.endDate.ToString() : string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            NewCallForm tempForm = new NewCallForm();
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
            showAllDaily = !showAllDaily;
            RefreshDataGrid();
            RefreshSolutions();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var row = ((DataGridView)sender).CurrentRow;

                User user = CentralManager.Instance.currentUser;
                int index = (int)row.Cells[0].Value;
                Daily daily = user.dailys[index];

                daily.End(!(bool)row.Cells["Column3"].Value);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Действительно выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {               
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
            //panel1.Controls.Add(button);
            //this.Controls.Add(panel1);

            return button;
        }

        private void RefreshSolutions()
        {
            //panel1.Controls.Clear();
            List<Solution> tempArray = new List<Solution>();

            //for (int i = 0; i < CentralManager.Instance.solutions.Count; i++)
            //{
            //    Solution solution = CentralManager.Instance.solutions[i];
            //    if (solution.heat > 0 && solution.isActual)
            //        tempArray.Add(solution);
            //    else
            //    {
            //        TimeSpan span = DateTime.Now.Date - solution.lastChangingDateTime.Date;                   
            //        if (span.Days < 7)
            //            tempArray.Add(solution);
            //    }
            //}

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
            //CentralManager.Instance.problems.Sort();
            //panel1.Controls.Clear();
            //int count = CentralManager.Instance.problems.Count;
            //if (count > 21) count = 21;

            //List<Problem> problems = new List<Problem>();
            //for (int i = 0; i < count; i++)
            //{
            //    Problem problem = CentralManager.Instance.problems[i];
            //    if (!problem.isSolved && problem.isActual)
            //    {
            //        problems.Add(problem);
            //    }
            //}


            //for (int i = 0; i < problems.Count; i++)
            //{
            //    Problem problem = problems[i];

            //    Button button = CreateButton(problem.name, ClickOnProblem);
            //    button.Name = problem.id;
            //    int width = i % 3 * (defaultWidth + spacingX);
            //    int height = i / 3 * (defaultHeight + spacingY);
            //    button.Location = new Point(width, height);

            //}
        }



        private void ClickOnSolution(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            Solution solution = CentralManager.Instance.GetSolutions(name);
            OpenSolution form = new OpenSolution(solution);
            form.ShowDialog();
            RefreshSolutions();
        }
       


        /////////////////////////////////////////
        //   Новый код
        ////////////////////////////////////////

        private void CreateTabControl()
        {            
            tabControl1.Controls.Clear();            

            foreach (var value in CentralManager.Instance.documentsNames)
            {
                TabPage page = new TabPage()
                {
                    Text = value,
                    Name = value,
                };     
                tabControl1.TabPages.Add(page);
                            
                CreateButtons(value, page);
            }
            
        }

        private void CreateButtons(string tag, TabPage page)
        {
            DataBase dataBase = CentralManager.Instance.dataBase;
            List<string> IDs = dataBase.GetAllIDs(tag, richTextBox1.Text);
            
            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            panel.AutoScrollMargin = new Size(10, 10);
            panel.AutoScrollMinSize = new Size(10, 10);
            page.Controls.Add(panel);


            for (int i = 0; i < IDs.Count; i++)
            {
                string id = IDs[i];              

                Button button = CreateButton(id);
                panel.Controls.Add(button);

                int x = i % 3 * (defaultWidth + spacingX);
                int y = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(x, y);


            }



        }

        private Button CreateButton(string id)
        {
            DataBase dataBase = CentralManager.Instance.dataBase;

            Button button = new Button()
            {
                Name = id,
                Text = dataBase.GetTrouble(id),
                Size = new Size(defaultWidth, defaultHeight),
                BackColor = Color.White,
            };
            button.Click += new EventHandler(ClickMethod);
            return button;



        }

        private void ClickMethod(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;
            OpenProblem(id);
        }       

        private void OpenProblem(string problemID)
        {
            ProblemForm form = new ProblemForm(problemID);
            form.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            indexOfCurrentWindow = tabControl1.SelectedIndex;
            CreateTabControl();
            tabControl1.SelectedIndex = indexOfCurrentWindow;
            richTextBox1.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
