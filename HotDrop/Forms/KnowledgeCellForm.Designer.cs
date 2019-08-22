namespace HotDrop.Forms
{
    partial class KnowledgeCellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgeCellForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.solutionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.commentsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.typesTextBox = new System.Windows.Forms.TextBox();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.tagsTextBox);
            this.panel1.Controls.Add(this.typesTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 203);
            this.panel1.TabIndex = 0;
            // 
            // descriptionWebBrowser
            // 
            this.descriptionWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionWebBrowser.Location = new System.Drawing.Point(12, 12);
            this.descriptionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.descriptionWebBrowser.Name = "descriptionWebBrowser";
            this.descriptionWebBrowser.Size = new System.Drawing.Size(353, 264);
            this.descriptionWebBrowser.TabIndex = 1;
            // 
            // solutionWebBrowser
            // 
            this.solutionWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionWebBrowser.Location = new System.Drawing.Point(371, 12);
            this.solutionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.solutionWebBrowser.Name = "solutionWebBrowser";
            this.solutionWebBrowser.Size = new System.Drawing.Size(527, 264);
            this.solutionWebBrowser.TabIndex = 2;
            // 
            // commentsWebBrowser
            // 
            this.commentsWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsWebBrowser.Location = new System.Drawing.Point(371, 282);
            this.commentsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.commentsWebBrowser.Name = "commentsWebBrowser";
            this.commentsWebBrowser.Size = new System.Drawing.Size(527, 203);
            this.commentsWebBrowser.TabIndex = 3;
            // 
            // typesTextBox
            // 
            this.typesTextBox.Location = new System.Drawing.Point(3, 3);
            this.typesTextBox.Name = "typesTextBox";
            this.typesTextBox.ReadOnly = true;
            this.typesTextBox.Size = new System.Drawing.Size(205, 20);
            this.typesTextBox.TabIndex = 0;
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(3, 29);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.ReadOnly = true;
            this.tagsTextBox.Size = new System.Drawing.Size(205, 20);
            this.tagsTextBox.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(214, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KnowledgeCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(910, 497);
            this.Controls.Add(this.commentsWebBrowser);
            this.Controls.Add(this.solutionWebBrowser);
            this.Controls.Add(this.descriptionWebBrowser);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnowledgeCellForm";
            this.Text = "KnowledgeCellForm";
            this.Load += new System.EventHandler(this.KnowledgeCellForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser descriptionWebBrowser;
        private System.Windows.Forms.WebBrowser solutionWebBrowser;
        private System.Windows.Forms.WebBrowser commentsWebBrowser;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.TextBox typesTextBox;
        private System.Windows.Forms.Button button1;
    }
}