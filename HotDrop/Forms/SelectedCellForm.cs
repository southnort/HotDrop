﻿using System;
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
    public partial class SelectedCellForm : Form
    {
        CallCell call;

        public SelectedCellForm(CallCell call)
        {
            this.call = call;

            InitializeComponent();
        }

        private void SelectedCellForm_Load(object sender, EventArgs e)
        {
            inn.Text = call.Inn;
            clientName.Text = call.ClientName;
            phoneNumber.Text = call.PhoneNumber;
            descr.Text = call.Descr;

            control.Checked = call.Logged == 1;

        }

        private void inn_TextChanged(object sender, EventArgs e)
        {
            call.Inn = inn.Text;
        }

        private void clientName_TextChanged(object sender, EventArgs e)
        {
            call.ClientName = clientName.Text;
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            call.PhoneNumber = phoneNumber.Text;
        }

        private void descr_TextChanged(object sender, EventArgs e)
        {
            call.Descr = descr.Text;
        }

        private void control_CheckedChanged(object sender, EventArgs e)
        {
            call.Logged = control.Checked ? 1 : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Program.dataBase.ExecuteCommand(call.ToDataBaseString());
           
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonMethods.CopyText(inn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CommonMethods.CopyText(clientName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CommonMethods.CopyText(phoneNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonMethods.CopyText(descr);
        }
    }
}
