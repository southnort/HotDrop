using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotDrop.Models;

namespace HotDrop.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            var table = Program.dataBase.GetTable("SELECT * FROM CallCells");

            historyDataGridView.DataSource = table;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (historyDataGridView.CurrentRow != null)
            {
                string id = historyDataGridView.CurrentRow.Cells[0].Value.ToString();

                string text = "Действительно удалить " + id + "?";
                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.dataBase.ExecuteCommand($"DELETE FROM CallCells WHERE id = {id}");
                    RefreshTable();
                }
            }
        }

        private void historyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historyDataGridView.CurrentRow != null)
            {
                string id = historyDataGridView.CurrentRow.Cells[0].Value.ToString();
                var table = Program.dataBase.GetTable
                    ($"SELECT * FROM CallCells WHERE id = {id}");
                var cell = table.Rows[0];
                var call = new CallCell(cell);

                SelectedCellForm form = new SelectedCellForm(call);
                form.ShowDialog();
                RefreshTable();
            }

        }
    }
}
