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
    public partial class OpenSolution : Form
    {
        private Solution solution;

        public OpenSolution(Solution solution)
        {
            this.solution = solution;
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            richTextBox1.Text = solution.problem.name + "\n\n" +
                solution.problem.description;
            richTextBox4.Text = solution.shortDescription;
            richTextBox2.Text = solution.description;
            richTextBox3.Text = solution.comment;
            checkBox1.Checked = solution.isActual;   
        }
            
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            solution.SetShortDescription(richTextBox4.Text, CentralManager.Instance.currentUser);
            solution.SetDescription(richTextBox2.Text, CentralManager.Instance.currentUser);
            solution.SetComment(richTextBox3.Text, CentralManager.Instance.currentUser);
            solution.SetActual(checkBox1.Checked, CentralManager.Instance.currentUser);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
