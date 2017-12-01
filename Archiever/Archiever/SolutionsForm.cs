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
    public partial class SolutionsForm : Form
    {
        private int defaultWidth = 190;
        private int defaultHeight = 80;
        private int spacingX = 5;
        private int spacingY = 5;
        private Section currentSection;

        public SolutionsForm()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            ShowSections();
            foreach (Section section in CentralManager.Instance.sections)
            {
                if (section.isActual)
                    comboBox1.Items.Add(section.name);
            }
        }


        private void ShowSections()
        {
            List<Section> sectionsList = new List<Section>(CentralManager.Instance.sections.Count);
            foreach (Section section in CentralManager.Instance.sections)
            {
                if (section.isActual)
                    sectionsList.Add(section);
            }
            

            for (int i = 0; i < sectionsList.Count; i++)
            {
                Section section = sectionsList[i];
                if (section.isActual && section != null)
                {
                    Button button = CreateButton(section.name, new EventHandler(ClickSectionButton));
                    button.Name = i.ToString();

                    int width = i % 3 * (defaultWidth + spacingX);
                    int height = i / 3 * (defaultHeight + spacingY);
                    button.Location = new Point(width, height);
                }
            }
        }

        private void ShowStickers(List<Problem> problems)
        {
            for (int i = 0; i < problems.Count; i++)
            {
                Button button = CreateButton(problems[i].name, new EventHandler(ClickOnProblem));
                button.Name = problems[i].id;
                if (!problems[i].isSolved) button.BackColor = Color.LightCoral;

                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void ShowStickers(List<Solution> solutions)
        {
        }

        private void ShowStickers(List<IDisplayable> list)
        {
            panel1.Controls.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                IDisplayable element = list[i];
                Button button = new Button();

                string type = element.ReturnType();
                switch (type)
                {
                    case "Problem":
                        button = CreateButton(element.NameForButton(), ClickOnProblem); break;
                    case "Solution":
                        button = CreateButton(element.NameForButton(), ClickOnSolution); break;

                    default:
                        CreateButton("Ошибка" + element.GetType(), EmptyClick); break;
                }


                //if (element.ReturnType().Contains("Problem"))
                //    button = CreateButton(element.NameForButton(), ClickOnProblem);

                //if (element.ReturnType().Contains("Solution"))
                //    button = CreateButton(element.NameForButton(), ClickOnSolution);

                //else button = CreateButton("Ошибка" + element.GetType(), EmptyClick);

                button.Name = element.GetID();
                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void ClickOnProblem(object sender, EventArgs e)
        {
            string guid = (sender as Button).Name;
            Problem problem = CentralManager.Instance.GetProblem(guid);
            ProblemForm form = new ProblemForm(problem);
            form.Show();
        }

        private void ClickOnSolution(object sender, EventArgs e)
        {
            string guid = (sender as Button).Name;
            Solution solution = CentralManager.Instance.GetSolutions(guid);
            OpenSolution form = new OpenSolution(solution);
            form.Show();
        }

        private void EmptyClick(object sender, EventArgs e)
        {
            //клик на пустой кнопке. Обработка ошибки. Метод должен быть пустым
        }

        private void SelectSection(int num)
        {
            Section section = CentralManager.Instance.sections[num];
            button2.Enabled = true;
            checkBox1.Enabled = true;

            panel1.Controls.Clear();
            currentSection = section;
            checkBox1.Checked = currentSection.isActual;
            RefreshForm();
        }

        private void RefreshForm()
        {
            List<Problem> prList = FindProblems(currentSection);
            ShowStickers(prList);
        }


        private List<Problem> FindProblems(Section section)
        {
            List<Problem> list = new List<Problem>();
            foreach (string guid in section.problemsIDs)
            {
                Problem pr = CentralManager.Instance.GetProblem(guid);
                list.Add(pr);
            }

            return list;
        }

        private void ClickSectionButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int numOfSection = int.Parse(b.Name);
            SelectSection(numOfSection);
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfSection = ((ComboBox)sender).SelectedIndex;
            SelectSection(numOfSection);
        }

        private void SolutionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = Prompt.ShowDialog("Новый тип", "Введите название нового раздела");
            if (result != "")
            {
                Section newSection = new Section(result, CentralManager.Instance.currentUser);
                CentralManager.Instance.sections.Add(newSection);
                comboBox1.Items.Add(newSection.name);
                ShowSections();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProblemForm form = new ProblemForm(new Problem(currentSection, CentralManager.Instance.currentUser));
            form.ShowDialog();
            RefreshForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            currentSection.SetActual(checkBox1.Checked);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<IDisplayable> tempList = new List<IDisplayable>();
            foreach (Solution solution in CentralManager.Instance.solutions)
                if (solution.ContainsString(richTextBox1.Text)) tempList.Add(solution);

            foreach (Problem problem in CentralManager.Instance.problems)
                if (problem.ContainsString(richTextBox1.Text)) tempList.Add(problem);

            ShowStickers(tempList);
        }
    }
}
