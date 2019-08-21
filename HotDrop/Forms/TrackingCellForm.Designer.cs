namespace HotDrop.Forms
{
    partial class TrackingCellForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackingCellForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.requestNumberTextBox = new System.Windows.Forms.TextBox();
            this.requestTextTextBox = new System.Windows.Forms.RichTextBox();
            this.readyCheckBox = new System.Windows.Forms.CheckBox();
            this.readyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ обращения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата обращения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(199, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Суть вопроса";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(12, 29);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(121, 20);
            this.dateTextBox.TabIndex = 3;
            // 
            // requestNumberTextBox
            // 
            this.requestNumberTextBox.Location = new System.Drawing.Point(12, 93);
            this.requestNumberTextBox.Name = "requestNumberTextBox";
            this.requestNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.requestNumberTextBox.TabIndex = 4;
            // 
            // requestTextTextBox
            // 
            this.requestTextTextBox.Location = new System.Drawing.Point(202, 29);
            this.requestTextTextBox.Name = "requestTextTextBox";
            this.requestTextTextBox.Size = new System.Drawing.Size(297, 84);
            this.requestTextTextBox.TabIndex = 5;
            this.requestTextTextBox.Text = "";
            // 
            // readyCheckBox
            // 
            this.readyCheckBox.AutoSize = true;
            this.readyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.readyCheckBox.Location = new System.Drawing.Point(202, 119);
            this.readyCheckBox.Name = "readyCheckBox";
            this.readyCheckBox.Size = new System.Drawing.Size(100, 21);
            this.readyCheckBox.TabIndex = 6;
            this.readyCheckBox.Text = "Исполнено";
            this.readyCheckBox.UseVisualStyleBackColor = true;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(12, 129);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(121, 42);
            this.readyButton.TabIndex = 7;
            this.readyButton.Text = "Исполнено";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(158, 174);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(121, 42);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "Сохранить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 42);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // TrackingCellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 228);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.readyCheckBox);
            this.Controls.Add(this.requestTextTextBox);
            this.Controls.Add(this.requestNumberTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackingCellForm";
            this.Text = "TrackingCellForm";
            this.Load += new System.EventHandler(this.TrackingCellForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox requestNumberTextBox;
        private System.Windows.Forms.RichTextBox requestTextTextBox;
        private System.Windows.Forms.CheckBox readyCheckBox;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}