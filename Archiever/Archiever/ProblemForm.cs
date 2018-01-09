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
        private Problem currentProblem;
        private int defaultWidth = 190;
        private int defaultHeight = 80;
        private int spacingX = 5;
        private int spacingY = 5;        


        public ProblemForm(Problem problem)
        {
            currentProblem = problem;

            currentProblem.IncreaseHeat();
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
            CreateHTMLPanel(currentProblem.comments);
            RefreshForm();
        }

        private void CreateHTMLPanel(string text)
        {
            TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();            
            htmlPanel.Text = text;
            htmlPanel.Dock = DockStyle.Fill;
            panel2.Controls.Add(htmlPanel);
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
            comboBox1.Text = currentProblem.section.name;
            // if (CentralManager.Instance.problems.Contains(currentProblem))
            comboBox1.Enabled = false;

            checkBox1.Checked = currentProblem.isSolved;
        }

        private void RefreshLabels()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Создано: \n");
            sb.Append(currentProblem.creatingDateTime.ToString("dd.MM.yyyy"));
            sb.Append("\n");
            sb.Append(currentProblem.createdBy.login);
            label3.Text = sb.ToString();

            sb = new StringBuilder();
            sb.Append("Изменено: \n");
            sb.Append(currentProblem.lastChangingDateTime.ToString("dd.MM.yyyy"));
            sb.Append("\n");
            sb.Append(currentProblem.changedBy.login);
            label4.Text = sb.ToString();
        }

        private void RefreshDescription()
        {
            richTextBox1.Text = currentProblem.name;
            richTextBox2.Text = currentProblem.description;
            webBrowser1.DocumentText = CommentWithDate(currentProblem.comments);
        }

        private string CommentWithDate(string text)
        {
            if (text.Contains("<NextDate>"))
            {
                DateTime needDateTime = DateTime.Now.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Sunday) needDateTime = needDateTime.AddDays(1);
                if (needDateTime.DayOfWeek == DayOfWeek.Saturday) needDateTime = needDateTime.AddDays(2);

                text = text.Replace("<NextDate>", needDateTime.ToString("dd.MM.yyyy"));
            }
            return text;
        }

        private void RefreshSolutions()
        {
            if (CentralManager.Instance.problems.Contains(currentProblem))
            {
                panel1.Controls.Clear();
                for (int i = 0; i < currentProblem.solutionsIDs.Count; i++)
                {
                    string solID = currentProblem.solutionsIDs[i];
                    Button button = CreateButton(CentralManager.Instance.GetSolutions(solID).shortDescription,
                        ClickOnSolution);
                    button.Name = solID;

                    int width = i % 3 * (defaultWidth + spacingX);
                    int height = i / 3 * (defaultHeight + spacingY);
                    button.Location = new Point(width, height);
                }
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
            currentProblem.Solved(checkBox1.Checked, CentralManager.Instance.currentUser);
            currentProblem.SetName(richTextBox1.Text, CentralManager.Instance.currentUser);
            currentProblem.SetDescription(richTextBox2.Text, CentralManager.Instance.currentUser);            

            if (!CentralManager.Instance.problems.Contains(currentProblem))
            {
                CentralManager.Instance.problems.Add(currentProblem);
                currentProblem.section.problemsIDs.Add(currentProblem.id);
            }
        }

        private Form ChangeComment(Problem problem)
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
            textBox2.Text = problem.comments;
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 180, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { problem.comments = textBox2.Text; };
            confirmation.Click += (sender, e) => { form.Close(); };
            form.Controls.Add(textBox2);
            form.Controls.Add(confirmation);
            form.Controls.Add(label2);
            form.AcceptButton = confirmation;
            return form;
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

       
        private void button1_Click(object sender, EventArgs e)
        {
            SaveProblem();
            OpenSolution form = new OpenSolution(new Solution(this.currentProblem, CentralManager.Instance.currentUser));
            form.ShowDialog();
            RefreshSolutions();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = ChangeComment(currentProblem);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
                webBrowser1.DocumentText = currentProblem.comments;
        }
    }
}
