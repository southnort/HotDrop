using System;
using System.Windows.Forms;
using HotDrop.Models;
using HotDrop.Forms;
using System.Drawing;


namespace HotDrop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text += " - " + Application.ProductVersion;

            string date = DateTime.Today.DayOfWeek == DayOfWeek.Friday ?
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
            CopyText(inn);
        }

        private void clientNameCopy_Click(object sender, EventArgs e)
        {
            CopyText(clientName);
        }

        private void phoneNumberCopy_Click(object sender, EventArgs e)
        {
            CopyText(phoneNumber);
        }

        private void requestDescriptionCopy_Click(object sender, EventArgs e)
        {
            CopyText(requestDescription);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CopyText(richTextBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopyText(richTextBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CopyText(richTextBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CopyText(richTextBox2);
        }

        private void CopyText(RichTextBox textBox)
        {
            CommonMethods.CopyText(textBox);
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            CallCell cc = new CallCell(inn.Text, clientName.Text,
                phoneNumber.Text, requestDescription.Text, control.Checked);

            Program.dataBase.CallCells.Add(cc);
            Program.dataBase.SaveChanges();

            inn.Clear();
            clientName.Clear();
            phoneNumber.Clear();
            requestDescription.Clear();
            ikz.Clear();

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.Show();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            //var form = new BaseOfKnowledgeMain();
            var form = new KnowledgeCellForm();
            form.Show();
        }

        private void trackingButton_Click(object sender, EventArgs e)
        {
            var form = new TrackingForm();
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

        private void accountButton_Click(object sender, EventArgs e)
        {
            ikz.Text = ikz.Text.Replace(".", "");
        }

       

        private void control_CheckedChanged(object sender, EventArgs e)
        {
            if (!control.Checked)
            {
                control.ForeColor = Color.Red;
                control.BackColor = Color.Aquamarine;
            }
            else
            {
                control.ForeColor = Color.Black;
                control.BackColor = SystemColors.Control;
            }
        }

       
    }
}
