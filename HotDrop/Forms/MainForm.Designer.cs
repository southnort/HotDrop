namespace HotDrop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inn = new System.Windows.Forms.RichTextBox();
            this.clientName = new System.Windows.Forms.RichTextBox();
            this.phoneNumber = new System.Windows.Forms.RichTextBox();
            this.requestDescription = new System.Windows.Forms.RichTextBox();
            this.innCopy = new System.Windows.Forms.Button();
            this.clientNameCopy = new System.Windows.Forms.Button();
            this.phoneNumberCopy = new System.Windows.Forms.Button();
            this.requestDescriptionCopy = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.control = new System.Windows.Forms.CheckBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.trackingButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.countOfInn = new System.Windows.Forms.Label();
            this.ikz = new System.Windows.Forms.RichTextBox();
            this.ikzButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inn
            // 
            this.inn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(53, 12);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(297, 34);
            this.inn.TabIndex = 0;
            this.inn.Text = "";
            this.inn.TextChanged += new System.EventHandler(this.inn_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.Location = new System.Drawing.Point(53, 52);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(297, 50);
            this.clientName.TabIndex = 1;
            this.clientName.Text = "";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(53, 108);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(297, 42);
            this.phoneNumber.TabIndex = 2;
            this.phoneNumber.Text = "";
            // 
            // requestDescription
            // 
            this.requestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requestDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestDescription.Location = new System.Drawing.Point(53, 156);
            this.requestDescription.Name = "requestDescription";
            this.requestDescription.Size = new System.Drawing.Size(297, 193);
            this.requestDescription.TabIndex = 3;
            this.requestDescription.Text = "";
            // 
            // innCopy
            // 
            this.innCopy.Location = new System.Drawing.Point(6, 12);
            this.innCopy.Name = "innCopy";
            this.innCopy.Size = new System.Drawing.Size(41, 34);
            this.innCopy.TabIndex = 6;
            this.innCopy.UseVisualStyleBackColor = true;
            this.innCopy.Click += new System.EventHandler(this.innCopy_Click);
            // 
            // clientNameCopy
            // 
            this.clientNameCopy.Location = new System.Drawing.Point(6, 52);
            this.clientNameCopy.Name = "clientNameCopy";
            this.clientNameCopy.Size = new System.Drawing.Size(41, 50);
            this.clientNameCopy.TabIndex = 7;
            this.clientNameCopy.UseVisualStyleBackColor = true;
            this.clientNameCopy.Click += new System.EventHandler(this.clientNameCopy_Click);
            // 
            // phoneNumberCopy
            // 
            this.phoneNumberCopy.Location = new System.Drawing.Point(6, 108);
            this.phoneNumberCopy.Name = "phoneNumberCopy";
            this.phoneNumberCopy.Size = new System.Drawing.Size(41, 42);
            this.phoneNumberCopy.TabIndex = 8;
            this.phoneNumberCopy.UseVisualStyleBackColor = true;
            this.phoneNumberCopy.Click += new System.EventHandler(this.phoneNumberCopy_Click);
            // 
            // requestDescriptionCopy
            // 
            this.requestDescriptionCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requestDescriptionCopy.Location = new System.Drawing.Point(6, 156);
            this.requestDescriptionCopy.Name = "requestDescriptionCopy";
            this.requestDescriptionCopy.Size = new System.Drawing.Size(41, 193);
            this.requestDescriptionCopy.TabIndex = 9;
            this.requestDescriptionCopy.UseVisualStyleBackColor = true;
            this.requestDescriptionCopy.Click += new System.EventHandler(this.requestDescriptionCopy_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(6, 355);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(344, 75);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.Checked = true;
            this.control.CheckState = System.Windows.Forms.CheckState.Checked;
            this.control.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control.Location = new System.Drawing.Point(356, 12);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(179, 21);
            this.control.TabIndex = 11;
            this.control.Text = "Занесено в Контроль";
            this.control.UseVisualStyleBackColor = true;
            this.control.CheckedChanged += new System.EventHandler(this.control_CheckedChanged);
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.historyButton.Location = new System.Drawing.Point(688, 277);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(128, 47);
            this.historyButton.TabIndex = 13;
            this.historyButton.Text = "Показать историю";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // trackingButton
            // 
            this.trackingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackingButton.Location = new System.Drawing.Point(688, 330);
            this.trackingButton.Name = "trackingButton";
            this.trackingButton.Size = new System.Drawing.Size(128, 47);
            this.trackingButton.TabIndex = 14;
            this.trackingButton.Text = "Отслеживание";
            this.trackingButton.UseVisualStyleBackColor = true;
            this.trackingButton.Click += new System.EventHandler(this.trackingButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveButton.Location = new System.Drawing.Point(688, 383);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(128, 47);
            this.archiveButton.TabIndex = 15;
            this.archiveButton.Text = "База знаний";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // countOfInn
            // 
            this.countOfInn.AutoSize = true;
            this.countOfInn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfInn.Location = new System.Drawing.Point(326, 29);
            this.countOfInn.Name = "countOfInn";
            this.countOfInn.Size = new System.Drawing.Size(24, 17);
            this.countOfInn.TabIndex = 16;
            this.countOfInn.Text = "10";
            this.countOfInn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ikz
            // 
            this.ikz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ikz.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ikz.Location = new System.Drawing.Point(356, 355);
            this.ikz.Name = "ikz";
            this.ikz.Size = new System.Drawing.Size(326, 33);
            this.ikz.TabIndex = 17;
            this.ikz.Text = "";
            // 
            // ikzButton
            // 
            this.ikzButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ikzButton.Location = new System.Drawing.Point(356, 394);
            this.ikzButton.Name = "ikzButton";
            this.ikzButton.Size = new System.Drawing.Size(115, 36);
            this.ikzButton.TabIndex = 18;
            this.ikzButton.Text = "ИКЗ";
            this.ikzButton.UseVisualStyleBackColor = true;
            this.ikzButton.Click += new System.EventHandler(this.ikzButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(625, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 101);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(625, 146);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(191, 101);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox3.Location = new System.Drawing.Point(389, 146);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(197, 101);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox4.Location = new System.Drawing.Point(389, 39);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(197, 101);
            this.richTextBox4.TabIndex = 21;
            this.richTextBox4.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(356, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 101);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(356, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 101);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(592, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 101);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(592, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 101);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // accountButton
            // 
            this.accountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountButton.Location = new System.Drawing.Point(477, 394);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(115, 36);
            this.accountButton.TabIndex = 27;
            this.accountButton.Text = "Р/с";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 442);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ikzButton);
            this.Controls.Add(this.ikz);
            this.Controls.Add(this.countOfInn);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.requestDescription);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.trackingButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.control);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.requestDescriptionCopy);
            this.Controls.Add(this.phoneNumberCopy);
            this.Controls.Add(this.clientNameCopy);
            this.Controls.Add(this.innCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "HotDrop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inn;
        private System.Windows.Forms.RichTextBox clientName;
        private System.Windows.Forms.RichTextBox phoneNumber;
        private System.Windows.Forms.RichTextBox requestDescription;
        private System.Windows.Forms.Button innCopy;
        private System.Windows.Forms.Button clientNameCopy;
        private System.Windows.Forms.Button phoneNumberCopy;
        private System.Windows.Forms.Button requestDescriptionCopy;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox control;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button trackingButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Label countOfInn;
        private System.Windows.Forms.RichTextBox ikz;
        private System.Windows.Forms.Button ikzButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button accountButton;
    }
}