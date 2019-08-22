namespace HotDrop.Forms
{
    partial class KnowledgeCellEditingForm
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
            this.descriptionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.solutionTextBox = new System.Windows.Forms.RichTextBox();
            this.solutionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.commentsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.documentsTypesTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tagsTextBox = new System.Windows.Forms.RichTextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionWebBrowser
            // 
            this.descriptionWebBrowser.Location = new System.Drawing.Point(12, 41);
            this.descriptionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.descriptionWebBrowser.Name = "descriptionWebBrowser";
            this.descriptionWebBrowser.Size = new System.Drawing.Size(484, 112);
            this.descriptionWebBrowser.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 159);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(484, 75);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            this.descriptionTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.solutionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.solutionTextBox.Location = new System.Drawing.Point(524, 159);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(484, 75);
            this.solutionTextBox.TabIndex = 3;
            this.solutionTextBox.Text = "";
            this.solutionTextBox.TextChanged += new System.EventHandler(this.solutionTextBox_TextChanged);
            this.solutionTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // solutionWebBrowser
            // 
            this.solutionWebBrowser.Location = new System.Drawing.Point(524, 41);
            this.solutionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.solutionWebBrowser.Name = "solutionWebBrowser";
            this.solutionWebBrowser.Size = new System.Drawing.Size(484, 112);
            this.solutionWebBrowser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Описание проблемы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание решения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Комментарии";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commentsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.commentsTextBox.Location = new System.Drawing.Point(524, 383);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(484, 75);
            this.commentsTextBox.TabIndex = 7;
            this.commentsTextBox.Text = "";
            this.commentsTextBox.TextChanged += new System.EventHandler(this.commentsTextBox_TextChanged);
            this.commentsTextBox.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // commentsWebBrowser
            // 
            this.commentsWebBrowser.Location = new System.Drawing.Point(524, 265);
            this.commentsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.commentsWebBrowser.Name = "commentsWebBrowser";
            this.commentsWebBrowser.Size = new System.Drawing.Size(484, 112);
            this.commentsWebBrowser.TabIndex = 6;
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.creationDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.creationDateTextBox.Location = new System.Drawing.Point(12, 265);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.Size = new System.Drawing.Size(235, 20);
            this.creationDateTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата создания";
            // 
            // documentsTypesTextBox
            // 
            this.documentsTypesTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.documentsTypesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.documentsTypesTextBox.Location = new System.Drawing.Point(12, 304);
            this.documentsTypesTextBox.Name = "documentsTypesTextBox";
            this.documentsTypesTextBox.Size = new System.Drawing.Size(235, 38);
            this.documentsTypesTextBox.TabIndex = 11;
            this.documentsTypesTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Типы документов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Теги";
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tagsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tagsTextBox.Location = new System.Drawing.Point(253, 265);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(243, 77);
            this.tagsTextBox.TabIndex = 13;
            this.tagsTextBox.Text = "";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 421);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(232, 44);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(264, 421);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(232, 44);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // KnowledgeCellEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1020, 477);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tagsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.documentsTypesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creationDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.commentsWebBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.solutionWebBrowser);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionWebBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KnowledgeCellEditingForm";
            this.Text = "KnowledgeCellEditingForm";
            this.Load += new System.EventHandler(this.KnowledgeCellEditingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser descriptionWebBrowser;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.RichTextBox solutionTextBox;
        private System.Windows.Forms.WebBrowser solutionWebBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.WebBrowser commentsWebBrowser;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox documentsTypesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tagsTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}