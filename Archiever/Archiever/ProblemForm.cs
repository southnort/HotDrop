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
            richTextBox2.Text = problem.name;
            richTextBox1.Text = problem.description;
        }

        private void RefreshSolutions()
        {
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








        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
