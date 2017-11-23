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
    public partial class NewCallForm : Form
    {
        public NewCallForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBox3.Text;
                text = text.Insert(33, " ");
                text = text.Insert(29, " ");
                text = text.Insert(26, " ");
                text = text.Insert(22, " ");
                text = text.Insert(2, " ");
                richTextBox3.Text = text;
            }
            catch
            {
                richTextBox3.Text += "  Error";
            }
        }

        private void NewCallForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
