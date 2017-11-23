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
            for (int i = 0; i < CentralManager.Instance.sections.Count; i++)
            {
                Section section = CentralManager.Instance.sections[i];
                Button button = CreateButton(section.name, new EventHandler(ClickSectionButton));

                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void ShowStickers(Problem[] problems)
        {
            for (int i = 0; i < problems.Length; i++)
            {
                Button button = CreateButton(problems[i].name, new EventHandler(ClickOnProblem));
                button.Name = i.ToString();

                int width = i % 3 * (defaultWidth + spacingX);
                int height = i / 3 * (defaultHeight + spacingY);
                button.Location = new Point(width, height);
            }
        }

        private void ShowStickers(Solution[] solutions)
        {
        }

        private void ClickOnProblem(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void ClickSectionButton(object sender, EventArgs e)
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

        private void SolutionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
