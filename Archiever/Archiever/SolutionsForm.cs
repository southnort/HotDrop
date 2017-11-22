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
            foreach (Section section in CentralManager.Instance.sections)
            {
                if (section.isActual)
                    comboBox1.Items.Add(section.name);
            }
            
        }


        private void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                CentralManager.Instance.sections.Add(new Section(i.ToString(), CentralManager.Instance.currentUser));
                CentralManager.Instance.problems.Add(new Problem(CentralManager.Instance.sections[i], "Problem " + i.ToString(), "Problem " + i.ToString(), CentralManager.Instance.currentUser));
            }

            ShowStickers(CentralManager.Instance.problems.ToArray());
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
    }
}
