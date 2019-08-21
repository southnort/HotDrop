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
    public partial class TrackingCellForm : Form
    {
        TrackingCell cell;

        public TrackingCellForm(TrackingCell cell)
        {
            this.cell = cell;

            InitializeComponent();
        }

        private void TrackingCellForm_Load(object sender, EventArgs e)
        {
            dateTextBox.Text = cell.CreationDate;
            requestNumberTextBox.Text = cell.Number;
            requestTextTextBox.Text = cell.Description;
            readyCheckBox.Checked = cell.IsDone == 1;

        }


        private void okButton_Click(object sender, EventArgs e)
        {
            cell.CreationDate = dateTextBox.Text;
            cell.Number = requestNumberTextBox.Text;
            cell.Description = requestTextTextBox.Text;
            cell.IsDone = readyCheckBox.Checked ? 1 : 0;

            Program.dataBase.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            cell.CreationDate = dateTextBox.Text;
            cell.Number = requestNumberTextBox.Text;
            cell.Description = requestTextTextBox.Text;
            cell.IsDone = 1;

            Program.dataBase.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        
    }
}
