using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace HotDrop.Forms
{
    public partial class BaseOfKnowledgeMain : Form
    {
        private HotDropContext db = Program.dataBase;

        public BaseOfKnowledgeMain()
        {
            InitializeComponent();
        }

        private void BaseOfKnowledgeMain_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void RefreshTable()
        {
            tabControlPanel.TabPages.Clear();
            var types = db.DocumentTypes.ToList();
            foreach (var type in types)
            {
                var page = CreatePage(type);
                tabControlPanel.TabPages.Add(page);
            }
        }



        private TabPage CreatePage(Models.DocumentType type)
        {
            var text = filterTextBox.Text;
            var page = new TabPage(type.Name);
            var dgv = new DataGridView();

            var list = db.KnowledgeCells.Where(x => x.DocumentTypes.Any(y => y.Name == type.Name)).ToList();

            //var list = db.KnowledgeCells.Local.Where(x => x.DocumentTypes.Contains(type)).ToList();
            var allCells = db.KnowledgeCells.Local.ToList();

            // var list = db.KnowledgeCells.Local.Where(x => x.DocumentTypes.Where(t => t.Name == type.Name).Any()).ToList();
            if (text == string.Empty)
                //dgv.DataSource = list.ToList();
                FillTable(dgv, list);
            else
            {
                list = list.Where(t =>
                t.Description.Contains(text) ||
                t.Solution.Contains(text) ||
                t.Comments.Contains(text) ||
                t.GetTagsString().Contains(text)
                ).ToList();

                //dgv.DataSource = list.ToList();

                FillTable(dgv, list.ToList());
            }

            page.Controls.Add(dgv);
            dgv.Parent = page;
            dgv.Dock = DockStyle.Fill;
            dgv.DoubleClick += dataGridView_CellDoubleClick;

            return page;
        }

        private void FillTable(DataGridView dgv, List<Models.KnowledgeCell> list)
        {
            dgv.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "Description",
                    HeaderText = "Описание",
                    Width = 300,
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Solution",
                    HeaderText = "Решение",
                    Width = 300,
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Heat",
                    HeaderText = "Heat",
                    Width = 40,
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Id",
                    HeaderText = "Id",
                    Width = 40,
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "CreationDate",
                    HeaderText = "Дата",
                    Width = 40,
                }

                );


            foreach (var cell in list)
            {
                var rowNum = dgv.Rows.Add();
                var row = dgv.Rows[rowNum];
                row.Cells["Description"].Value = GetText(cell.Description);
                row.Cells["Solution"].Value = GetText(cell.Solution);
                row.Cells["Heat"].Value = cell.Heat;
                row.Cells["Id"].Value = cell.Id;
                row.Cells["CreationDate"].Value = cell.CreationDate;
            }
        }

        private string GetText(string html)
        {
            try
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                return doc.DocumentNode.SelectSingleNode("//body").InnerText;
            }

            catch
            {
                return html;
            }

        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellDoubleClick(object sender, EventArgs e)
        {
            var dgv = (DataGridView)sender;

            if (dgv.CurrentRow != null)
            {
                var id = (int)dgv.CurrentRow.Cells[3].Value;
                var call =
                    db.KnowledgeCells.Single(x => x.Id == id);

                var form = new KnowledgeCellForm(call);
                form.ShowDialog();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var cell = new Models.KnowledgeCell("");
            var form = new KnowledgeCellEditingForm(cell);
            var result = form.ShowDialog();
            RefreshTable();
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Clear();
            RefreshTable();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void CreateFile()
        {
            var exporter = new PDFExporter();
            string resultString = "Выполнено успешно";
            try
            {
                var list = db.KnowledgeCells.ToList();
                list.Sort();
                exporter.ExportToFile(list, "Шпаргалка ЛО.pdf");                
            }
            catch (Exception ex)
            {
                resultString = ex.ToString();
            }

            finally
            {
                MessageBox.Show(resultString);
            }

        }

    }
}
