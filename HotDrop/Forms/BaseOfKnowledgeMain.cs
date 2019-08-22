using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var list = db.KnowledgeCells.Local.Where(x => x.DocumentTypes.Contains(type)).ToList();
            if (text == string.Empty)
                //dgv.DataSource = list.ToList();
                FillTable(dgv, list);
            else
            {
                list = list.Where(t =>
                t.Description.Contains(text) ||
                t.Solution.Contains(text) ||
                t.Comments.Contains(text) ||
                (t.Tags.Where(tag => tag.Name == text).Count() > 0)).ToList();

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
                    Width = 200,
                },

                new DataGridViewTextBoxColumn
                {
                    Name = "Solution",
                    HeaderText = "Решение",
                    Width = 200,
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
                row.Cells["Description"].Value = cell.Description;
                row.Cells["Solution"].Value = cell.Solution;
                row.Cells["Heat"].Value = cell.Heat;
                row.Cells["Id"].Value = cell.Id;
                row.Cells["CreationDate"].Value = cell.CreationDate;                
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
            var dgv = (DataGridView) sender;

            if (dgv.CurrentRow != null)
            {
                var id = int.Parse((string)dgv.CurrentRow.Cells[4].Value);
                var call = db.KnowledgeCells.Single(x => x.Id == id);

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
    }
}
