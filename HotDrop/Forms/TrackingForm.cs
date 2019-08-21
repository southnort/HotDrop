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
    public partial class TrackingForm : Form
    {
        private HotDropContext db = Program.dataBase;
        private List<TrackingCell> table;

        public TrackingForm()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {       
            if (onlyActiveCheckBox.Checked)
                table = db.TrackingCells.Where(x => x.IsDone != 1).ToList();
            else
                table = db.TrackingCells.ToList();

            trackingDataGridView.DataSource = table;
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {            
            RefreshTable();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (trackingDataGridView.CurrentRow != null)
            {
                var id = (int)trackingDataGridView.CurrentRow.Cells[4].Value;

                string text = "Действительно удалить " + id + "?";
                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    var item = db.TrackingCells.Single(x => x.Id == id);
                    db.TrackingCells.Remove(item);
                    db.SaveChanges();
                    RefreshTable();
                }
            }
        }

        private void trackingDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (trackingDataGridView.CurrentRow != null)
            {
                var id = (int)trackingDataGridView.CurrentRow.Cells[4].Value;
                var call = db.TrackingCells.Single(x => x.Id == id);

                TrackingCellForm form = new TrackingCellForm(call);
                form.ShowDialog();               
                RefreshTable();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var cell = new TrackingCell("","");

            TrackingCellForm form = new TrackingCellForm(cell);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                db.TrackingCells.Add(cell);
                db.SaveChanges();
                
                RefreshTable();
            }
        }
    }
}
