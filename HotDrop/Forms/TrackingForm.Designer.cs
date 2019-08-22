namespace HotDrop.Forms
{
    partial class TrackingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.onlyActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.trackingDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.onlyActiveCheckBox);
            this.panel1.Controls.Add(this.createButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 66);
            this.panel1.TabIndex = 3;
            // 
            // onlyActiveCheckBox
            // 
            this.onlyActiveCheckBox.AutoSize = true;
            this.onlyActiveCheckBox.Checked = true;
            this.onlyActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyActiveCheckBox.Location = new System.Drawing.Point(3, 45);
            this.onlyActiveCheckBox.Name = "onlyActiveCheckBox";
            this.onlyActiveCheckBox.Size = new System.Drawing.Size(179, 17);
            this.onlyActiveCheckBox.TabIndex = 3;
            this.onlyActiveCheckBox.Text = "Показывать только активные";
            this.onlyActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(87, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(81, 36);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "+";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(45, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(36, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(36, 36);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "O";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // trackingDataGridView
            // 
            this.trackingDataGridView.AllowUserToAddRows = false;
            this.trackingDataGridView.AllowUserToDeleteRows = false;
            this.trackingDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trackingDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.trackingDataGridView.Location = new System.Drawing.Point(12, 84);
            this.trackingDataGridView.Name = "trackingDataGridView";
            this.trackingDataGridView.Size = new System.Drawing.Size(776, 354);
            this.trackingDataGridView.TabIndex = 2;
            this.trackingDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trackingDataGridView_CellDoubleClick);
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackingDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackingForm";
            this.Text = "TrackingForm";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView trackingDataGridView;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.CheckBox onlyActiveCheckBox;
    }
}