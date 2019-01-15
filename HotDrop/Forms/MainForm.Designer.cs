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
            this.countOfInn = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.trackingButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inn
            // 
            this.inn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(12, 12);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(284, 42);
            this.inn.TabIndex = 0;
            this.inn.Text = "";
            this.inn.TextChanged += new System.EventHandler(this.inn_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientName.Location = new System.Drawing.Point(12, 60);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(284, 42);
            this.clientName.TabIndex = 1;
            this.clientName.Text = "";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(12, 108);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(284, 42);
            this.phoneNumber.TabIndex = 2;
            this.phoneNumber.Text = "";
            // 
            // requestDescription
            // 
            this.requestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requestDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestDescription.Location = new System.Drawing.Point(12, 156);
            this.requestDescription.Name = "requestDescription";
            this.requestDescription.Size = new System.Drawing.Size(284, 198);
            this.requestDescription.TabIndex = 3;
            this.requestDescription.Text = "";
            // 
            // innCopy
            // 
            this.innCopy.Location = new System.Drawing.Point(302, 12);
            this.innCopy.Name = "innCopy";
            this.innCopy.Size = new System.Drawing.Size(48, 42);
            this.innCopy.TabIndex = 6;
            this.innCopy.Text = "copy";
            this.innCopy.UseVisualStyleBackColor = true;
            this.innCopy.Click += new System.EventHandler(this.innCopy_Click);
            // 
            // clientNameCopy
            // 
            this.clientNameCopy.Location = new System.Drawing.Point(302, 60);
            this.clientNameCopy.Name = "clientNameCopy";
            this.clientNameCopy.Size = new System.Drawing.Size(48, 42);
            this.clientNameCopy.TabIndex = 7;
            this.clientNameCopy.Text = "copy";
            this.clientNameCopy.UseVisualStyleBackColor = true;
            this.clientNameCopy.Click += new System.EventHandler(this.clientNameCopy_Click);
            // 
            // phoneNumberCopy
            // 
            this.phoneNumberCopy.Location = new System.Drawing.Point(302, 108);
            this.phoneNumberCopy.Name = "phoneNumberCopy";
            this.phoneNumberCopy.Size = new System.Drawing.Size(48, 42);
            this.phoneNumberCopy.TabIndex = 8;
            this.phoneNumberCopy.Text = "copy";
            this.phoneNumberCopy.UseVisualStyleBackColor = true;
            this.phoneNumberCopy.Click += new System.EventHandler(this.phoneNumberCopy_Click);
            // 
            // requestDescriptionCopy
            // 
            this.requestDescriptionCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requestDescriptionCopy.Location = new System.Drawing.Point(302, 156);
            this.requestDescriptionCopy.Name = "requestDescriptionCopy";
            this.requestDescriptionCopy.Size = new System.Drawing.Size(48, 198);
            this.requestDescriptionCopy.TabIndex = 9;
            this.requestDescriptionCopy.Text = "copy";
            this.requestDescriptionCopy.UseVisualStyleBackColor = true;
            this.requestDescriptionCopy.Click += new System.EventHandler(this.requestDescriptionCopy_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(12, 360);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(338, 75);
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
            // 
            // countOfInn
            // 
            this.countOfInn.AutoSize = true;
            this.countOfInn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfInn.Location = new System.Drawing.Point(272, 37);
            this.countOfInn.Name = "countOfInn";
            this.countOfInn.Size = new System.Drawing.Size(16, 17);
            this.countOfInn.TabIndex = 12;
            this.countOfInn.Text = "0";
            // 
            // historyButton
            // 
            this.historyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.historyButton.Location = new System.Drawing.Point(808, 282);
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
            this.trackingButton.Location = new System.Drawing.Point(808, 335);
            this.trackingButton.Name = "trackingButton";
            this.trackingButton.Size = new System.Drawing.Size(128, 47);
            this.trackingButton.TabIndex = 14;
            this.trackingButton.Text = "Отслеживание";
            this.trackingButton.UseVisualStyleBackColor = true;
            // 
            // archiveButton
            // 
            this.archiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveButton.Location = new System.Drawing.Point(808, 388);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(128, 47);
            this.archiveButton.TabIndex = 15;
            this.archiveButton.Text = "Архив";
            this.archiveButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 447);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.requestDescription);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.trackingButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.countOfInn);
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
        private System.Windows.Forms.Label countOfInn;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button trackingButton;
        private System.Windows.Forms.Button archiveButton;
        
    }
}