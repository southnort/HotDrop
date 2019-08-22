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
    public partial class KnowledgeCellEditingForm : Form
    {
        private KnowledgeCell cell;

        public KnowledgeCellEditingForm(KnowledgeCell cell)
        {
            this.cell = cell;
            InitializeComponent();
        }

        private void KnowledgeCellEditingForm_Load(object sender, EventArgs e)
        {
            descriptionTextBox.Text = cell.Description;
            solutionTextBox.Text = cell.Solution;
            commentsTextBox.Text = cell.Comments;
            creationDateTextBox.Text = cell.CreationDate;
            documentsTypesTextBox.Text = cell.GetTypesString();
            tagsTextBox.Text = cell.GetTagsString();
        }

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            var html = Clipboard.GetText(TextDataFormat.Html);
            if (html.Length < 1) html = "Empty";

            var box = (TextBoxBase)sender;
            box.Text = html;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBoxBase)sender;
            descriptionWebBrowser.DocumentText = box.Text;
        }

        private void solutionTextBox_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBoxBase)sender;
            solutionWebBrowser.DocumentText = box.Text;
        }

        private void commentsTextBox_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBoxBase)sender;
            commentsWebBrowser.DocumentText = box.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {            
            cell.Description = descriptionTextBox.Text;
            cell.Solution = solutionTextBox.Text;
            cell.Comments = commentsTextBox.Text;
            cell.CreationDate = creationDateTextBox.Text;
            cell.SetDocumetTypes(documentsTypesTextBox.Text);
            cell.SetTags(tagsTextBox.Text);

            Program.dataBase.KnowledgeCells.Add(cell);
            Program.dataBase.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
