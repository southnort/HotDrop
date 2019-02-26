using System;
using System.Windows.Forms;
using HotDrop.Models;
using HotDrop.Forms;

namespace HotDrop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text += " - " + Application.ProductVersion;

            string date = DateTime.Today.Day == 5 ?
                DateTime.Today.AddDays(3).ToShortDateString() :
                DateTime.Today.AddDays(1).ToShortDateString();

            string requestText =
               $"Если ответа от вас не поступит до вечера \"{date}\", обращение будет автоматически закрыто";
            richTextBox1.Text = requestText;
            richTextBox2.Text = "Обращение заказчика";


        }






        private void inn_TextChanged(object sender, EventArgs e)
        {
            countOfInn.Text = inn.Text.Length.ToString();
        }

        private void innCopy_Click(object sender, EventArgs e)
        {
            if (inn.Text.Length > 0)
                Clipboard.SetText(inn.Text);
        }

        private void clientNameCopy_Click(object sender, EventArgs e)
        {
            if (clientName.Text.Length > 0)
                Clipboard.SetText(clientName.Text);
        }

        private void phoneNumberCopy_Click(object sender, EventArgs e)
        {
            if (phoneNumber.Text.Length > 0)
                Clipboard.SetText(phoneNumber.Text);
        }

        private void requestDescriptionCopy_Click(object sender, EventArgs e)
        {
            if (requestDescription.Text.Length > 0)
                Clipboard.SetText(requestDescription.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CallCell cc = new CallCell(inn.Text, clientName.Text,
                phoneNumber.Text, requestDescription.Text, control.Checked);

            Program.dataBase.ExecuteCommand(cc.ToDataBaseString());

            inn.Clear();
            clientName.Clear();
            phoneNumber.Clear();
            requestDescription.Clear();

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.Show();
        }

        private void ikzButton_Click(object sender, EventArgs e)
        {
            try
            {
                string text = ikz.Text;
                text = text.Insert(33, " ");
                text = text.Insert(29, " ");
                text = text.Insert(26, " ");
                text = text.Insert(22, " ");
                text = text.Insert(2, " ");
                ikz.Text = text;
            }
            catch
            {
                ikz.Text += "  Error";
            }
        }
    }
}
