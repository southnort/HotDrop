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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCallForm tempForm = new NewCallForm();
            tempForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SolutionsForm tempForm = new SolutionsForm();
            //tempForm.Show();

            
          string daily = Prompt.AddNewDailyDialog("1","2");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
