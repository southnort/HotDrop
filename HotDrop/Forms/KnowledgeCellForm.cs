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
    public partial class KnowledgeCellForm : Form
    {
        private KnowledgeCell cell;

        public KnowledgeCellForm(KnowledgeCell cell)
        {
            this.cell = cell;
            InitializeComponent();
        }

        private void KnowledgeCellForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            descriptionWebBrowser.DocumentText = cell.Description;
            solutionWebBrowser.DocumentText = cell.Solution;
            commentsWebBrowser.DocumentText = cell.Comments;
            typesTextBox.Text = cell.GetTypesString();
            tagsTextBox.Text = cell.GetTagsString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var form = new KnowledgeCellEditingForm(cell);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                FillForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
