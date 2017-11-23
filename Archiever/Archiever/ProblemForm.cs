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
        private Problem problem;      
        private int defaultWidth = 190;
        private int defaultHeight = 80;
        private int spacingX = 5;
        private int spacingY = 5;



        public ProblemForm(Problem problem)
        {
            this.problem = problem;          
            
            this.problem.IncreaseHeat();
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            foreach (Section section in CentralManager.Instance.sections)
            {
                if (section.isActual)
                    comboBox1.Items.Add(section.name);
            }
            RefreshForm();
        }

        private void RefreshForm()
        {
            RefreshHeader();
            RefreshLabels();
            RefreshDescription();
            RefreshSolutions();
        }

        private void RefreshHeader()
        {
            comboBox1.Text = problem.section.name;
            if (CentralManager.Instance.problems.Contains(problem))
                comboBox1.Enabled = false;

            checkBox1.Checked = problem.isSolved;
        }

        private void RefreshLabels()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Создано: \n");
            sb.Append(problem.creatingDateTime.ToString("dd.MM.yyyy"));
            sb.Append("\n");
            sb.Append(problem.createdBy.login);
            label3.Text = sb.ToString();

            sb = new StringBuilder();
            sb.Append("Изменено: \n");
            sb.Append(problem.lastChangingDateTime.ToString("dd.MM.yyyy"));
            sb.Append("\n");
            sb.Append(problem.changedBy.login);
            label4.Text = sb.ToString();
        }

        private void RefreshDescription()
        {
            richTextBox1.Text = problem.name;
            richTextBox2.Text = problem.description;
            richTextBox3.Text = problem.comments;
        }

        private void RefreshSolutions()
        {
            problem.solutions.Sort();
            for (int i = 0; i < problem.solutions.Count; i++)
            {
                Button button = CreateButton(problem.solutions[i].shortDescription, ClickOnSolution);
                button.Name = i.ToString();

                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void ClickOnSolution(object sender, EventArgs e)
        {
            int numOfsolution = int.Parse(((Button)sender).Name);
            Solution solution = problem.solutions[numOfsolution];

            OpenSolution form = new OpenSolution(solution);
            form.Show();
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

        private void SaveProblem()
        {
            problem.Solved(checkBox1.Checked, CentralManager.Instance.currentUser);
            problem.SetName(richTextBox1.Text, CentralManager.Instance.currentUser);
            problem.SetDescription(richTextBox2.Text, CentralManager.Instance.currentUser);
            problem.comments = richTextBox3.Text;
        }








       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveProblem();
            this.Close();
        }               

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfSection = ((ComboBox)sender).SelectedIndex;
            Section section = CentralManager.Instance.sections[numOfSection];
            problem = new Problem(section, CentralManager.Instance.currentUser);
            RefreshForm();
        }                       

        private void button1_Click(object sender, EventArgs e)
        {
            SaveProblem();
            OpenSolution form = new OpenSolution(new Solution(this.problem, CentralManager.Instance.currentUser));
        }        
    }
}
