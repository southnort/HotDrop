namespace HotDrop.Forms
{
    partial class SelectedCellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inn = new System.Windows.Forms.RichTextBox();
            this.clientName = new System.Windows.Forms.RichTextBox();
            this.phoneNumber = new System.Windows.Forms.RichTextBox();
            this.descr = new System.Windows.Forms.RichTextBox();
            this.control = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inn
            // 
            this.inn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(46, 12);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(203, 46);
            this.inn.TabIndex = 0;
            this.inn.Text = "";
            this.inn.TextChanged += new System.EventHandler(this.inn_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.Location = new System.Drawing.Point(46, 64);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(203, 46);
            this.clientName.TabIndex = 1;
            this.clientName.Text = "";
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(46, 116);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(203, 46);
            this.phoneNumber.TabIndex = 2;
            this.phoneNumber.Text = "";
            this.phoneNumber.TextChanged += new System.EventHandler(this.phoneNumber_TextChanged);
            // 
            // descr
            // 
            this.descr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descr.Location = new System.Drawing.Point(289, 12);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(335, 150);
            this.descr.TabIndex = 3;
            this.descr.Text = "";
            this.descr.TextChanged += new System.EventHandler(this.descr_TextChanged);
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control.Location = new System.Drawing.Point(12, 195);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(179, 21);
            this.control.TabIndex = 4;
            this.control.Text = "Занесено в контроль";
            this.control.UseVisualStyleBackColor = true;
            this.control.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 150);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 46);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 46);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 46);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SelectedCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 228);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.control);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.inn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectedCellForm";
            this.Text = "SelectedCellForm";
            this.Load += new System.EventHandler(this.SelectedCellForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inn;
        private System.Windows.Forms.RichTextBox clientName;
        private System.Windows.Forms.RichTextBox phoneNumber;
        private System.Windows.Forms.RichTextBox descr;
        private System.Windows.Forms.CheckBox control;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}