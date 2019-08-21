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
        private HotDropContext db = Program.dataBase;
        private List<CallCell> table;
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            if (filterTextBox.Text.Length > 0)
            {
                var text = filterTextBox.Text;

                table = db.CallCells.Where(x =>
                x.ClientName.Contains(text) ||
                x.Descr.Contains(text) ||
                x.PhoneNumber.Contains(text) ||
                x.Inn.Contains(text)            
                )
                .OrderByDescending(x => x.CallDateTime).ToList();
            }

            else
                table = db.CallCells.OrderByDescending(x => x.CallDateTime).ToList();
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
                var id = (int)historyDataGridView.CurrentRow.Cells[0].Value;

                string text = "Действительно удалить " + id + "?";
                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    var item = db.CallCells.Single(x => x.Id == id);
                    db.CallCells.Remove(item);
                    db.SaveChanges();
                    RefreshTable();
                }
            }
        }

        private void historyDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historyDataGridView.CurrentRow != null)
            {
                var id = (int)historyDataGridView.CurrentRow.Cells[0].Value;
                var call = db.CallCells.Single(x => x.Id == id);

                SelectedCellForm form = new SelectedCellForm(call);
                form.ShowDialog();
                RefreshTable();
            }

        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            filterTextBox.Clear();
            RefreshTable();
        }
    }
}
