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
    public partial class Form1 : Form
    {
        private bool showReady = false;

        public Form1()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            User user = CentralManager.Instance.currentUser;
            dataGridView1.Rows.Clear();
            foreach (Daily dl in user.dailys)
            {
                if (dl.endDate == null || showReady)
                {
                    try
                    {
                        int rowNumber = dataGridView1.Rows.Add();

                        dataGridView1.Rows[rowNumber].Cells[0].Value = user.dailys.IndexOf(dl);
                        dataGridView1.Rows[rowNumber].Cells[1].Value = dl.startDate.ToString();
                        dataGridView1.Rows[rowNumber].Cells[2].Value = (dl.endDate != null);
                        dataGridView1.Rows[rowNumber].Cells[3].Value = dl.number;
                        dataGridView1.Rows[rowNumber].Cells[4].Value = dl.text;
                        dataGridView1.Rows[rowNumber].Cells[5].Value = dl.endDate != null ? dl.endDate.ToString() : string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NewCallForm tempForm = new NewCallForm();
            tempForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SolutionsForm tempForm = new SolutionsForm();
            tempForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Daily dl = Prompt.AddNewDailyDialog();
            if (dl != null)
            {
                CentralManager.Instance.currentUser.dailys.Add(dl);

                int rowNumber = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowNumber].Cells[0].Value = CentralManager.Instance.currentUser.dailys.IndexOf(dl);
                dataGridView1.Rows[rowNumber].Cells[1].Value = dl.startDate.ToString();
                dataGridView1.Rows[rowNumber].Cells[2].Value = (dl.endDate != null);
                dataGridView1.Rows[rowNumber].Cells[3].Value = dl.number;
                dataGridView1.Rows[rowNumber].Cells[4].Value = dl.text;
                dataGridView1.Rows[rowNumber].Cells[5].Value = dl.endDate != null ? dl.endDate.ToString() : string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showReady = !showReady;
            RefreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridView dg = (DataGridView)sender;           
            int numOfVal = (int)dg.Rows[e.RowIndex].Cells[0].Value;

            Daily daily = CentralManager.Instance.currentUser.dailys[numOfVal];
            daily.End(!daily.isDone);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Приложение будет закрыто. Данные сохранятся");
            CentralManager.Instance.EndManager();
        }
    }
}
