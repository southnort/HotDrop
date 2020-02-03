using System;
using System.Windows.Forms;
using HotDrop.Models;
using HotDrop.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;


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

            Thread savingThread = new Thread(() =>
            {
                Program.dataBase.CallCells.Add(cc);
                Program.dataBase.SaveChanges();
            });
            savingThread.Start();

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
            var form = new BaseOfKnowledgeMain();
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


        private void OpenLink(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                ikz.Text = ex.Message;
            }
        }

        private void pgButton_Click(object sender, EventArgs e)
        {
            var url = $@"https://zakupki.gov.ru/epz/orderplan/search/results.html?searchString={ikz.Text}&morphology=on&search-filter=Дате+размещения&structured=true&fz44=on&customerPlaceWithNested=on&sortBy=BY_MODIFY_DATE&pageNumber=1&sortDirection=false&recordsPerPage=_10&searchType=false";
            //var url = $@"http://zakupki.gov.ru/epz/orderplan/quicksearch/search.html?searchString={ikz.Text}&morphology=on&searchType=false&structured=true&fz44=on&fz223=on&regionDeleted=false&actualPeriodStart=01.01.2019&actualPeriodEnd=31.12.2019&sortBy=BY_MODIFY_DATE&pageNumber=1&sortDirection=false&recordsPerPage=_10";
            OpenLink(url);
        }

        private void pzButton_Click(object sender, EventArgs e)
        {
            var url = $@"http://zakupki.gov.ru/epz/purchaseplanfz44/quicksearch/search.html?searchString={ikz.Text}&morphology=on&pageNumber=1&sortDirection=false&recordsPerPage=_10&plansSearch=false&structured=on&unstructured=on&regionDeleted=false&fiscalYear=0&planPeriodYearStart=0&planPeriodYearEnd=0&sortBy=UPDATE_DATE_SORT";
            OpenLink(url);
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            var url = $@"http://zakupki.gov.ru/epz/order/notice/ok504/view/common-info.html?regNumber={ikz.Text}";
            OpenLink(url);
        }

        private void contractButton_Click(object sender, EventArgs e)
        {
            var url = $@"http://zakupki.gov.ru/epz/contract/contractCard/common-info.html?reestrNumber={ikz.Text}";
            OpenLink(url);
        }

        private void allQuotesButton_Click(object sender, EventArgs e)
        {
            var url = $@"http://zakupki.gov.ru/epz/order/quicksearch/search.html?searchString={ikz.Text}&morphology=on";
            OpenLink(url);
        }

        private void allContractsButton_Click(object sender, EventArgs e)
        {
            var url = $@"http://zakupki.gov.ru/epz/contract/quicksearch/search.html?searchString={ikz.Text}&morphology=on&pageNumber=1&sortDirection=false&recordsPerPage=_10&sortBy=PO_DATE_OBNOVLENIJA&fz44=on&contractPriceFrom=0&contractPriceTo=200000000000&contractStageList_0=on&contractStageList_1=on&contractStageList_2=on&contractStageList_3=on&contractStageList=0%2C1%2C2%2C3&regionDeleted=false";
            OpenLink(url);
        }
    }
}
