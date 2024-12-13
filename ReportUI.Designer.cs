namespace EquipmentRentalManagementPrototype
{
    partial class ReportUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ReportPageTitle = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SysMgrBtn = new System.Windows.Forms.Button();
            this.ReportMgrBtn = new System.Windows.Forms.Button();
            this.RentMgrBtn = new System.Windows.Forms.Button();
            this.CustomMgrBtn = new System.Windows.Forms.Button();
            this.CatMgrBtn = new System.Windows.Forms.Button();
            this.EquipMgrBtn = new System.Windows.Forms.Button();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.ReportSelector = new System.Windows.Forms.ComboBox();
            this.OperatorText = new System.Windows.Forms.Label();
            this.OperatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ReportPageTitle);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerTop_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 2;
            // 
            // ReportPageTitle
            // 
            this.ReportPageTitle.AutoSize = true;
            this.ReportPageTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPageTitle.Location = new System.Drawing.Point(201, 9);
            this.ReportPageTitle.Name = "ReportPageTitle";
            this.ReportPageTitle.Size = new System.Drawing.Size(367, 49);
            this.ReportPageTitle.TabIndex = 0;
            this.ReportPageTitle.Text = "Report Management";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SysMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.ReportMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.RentMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.CustomMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.CatMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.EquipMgrBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ReportDataGrid);
            this.splitContainer2.Panel2.Controls.Add(this.GenerateReport);
            this.splitContainer2.Panel2.Controls.Add(this.ReportSelector);
            this.splitContainer2.Panel2.Controls.Add(this.OperatorText);
            this.splitContainer2.Panel2.Controls.Add(this.OperatorLabel);
            this.splitContainer2.Size = new System.Drawing.Size(800, 379);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.TabIndex = 0;
            // 
            // SysMgrBtn
            // 
            this.SysMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SysMgrBtn.Location = new System.Drawing.Point(3, 280);
            this.SysMgrBtn.Name = "SysMgrBtn";
            this.SysMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.SysMgrBtn.TabIndex = 5;
            this.SysMgrBtn.Text = "System Mgr";
            this.SysMgrBtn.UseVisualStyleBackColor = true;
            // 
            // ReportMgrBtn
            // 
            this.ReportMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportMgrBtn.Location = new System.Drawing.Point(3, 233);
            this.ReportMgrBtn.Name = "ReportMgrBtn";
            this.ReportMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.ReportMgrBtn.TabIndex = 4;
            this.ReportMgrBtn.Text = "Report Mgr";
            this.ReportMgrBtn.UseVisualStyleBackColor = true;
            // 
            // RentMgrBtn
            // 
            this.RentMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentMgrBtn.Location = new System.Drawing.Point(3, 186);
            this.RentMgrBtn.Name = "RentMgrBtn";
            this.RentMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.RentMgrBtn.TabIndex = 3;
            this.RentMgrBtn.Text = "Rental Mgr";
            this.RentMgrBtn.UseVisualStyleBackColor = true;
            this.RentMgrBtn.Click += new System.EventHandler(this.RentMgrBtn_Click);
            // 
            // CustomMgrBtn
            // 
            this.CustomMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomMgrBtn.Location = new System.Drawing.Point(3, 139);
            this.CustomMgrBtn.Name = "CustomMgrBtn";
            this.CustomMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.CustomMgrBtn.TabIndex = 2;
            this.CustomMgrBtn.Text = "Customer Mgr";
            this.CustomMgrBtn.UseVisualStyleBackColor = true;
            this.CustomMgrBtn.Click += new System.EventHandler(this.CustomMgrBtn_Click);
            // 
            // CatMgrBtn
            // 
            this.CatMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatMgrBtn.Location = new System.Drawing.Point(3, 92);
            this.CatMgrBtn.Name = "CatMgrBtn";
            this.CatMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.CatMgrBtn.TabIndex = 1;
            this.CatMgrBtn.Text = "Category Mgr";
            this.CatMgrBtn.UseVisualStyleBackColor = true;
            this.CatMgrBtn.Click += new System.EventHandler(this.CatMgrBtn_Click);
            // 
            // EquipMgrBtn
            // 
            this.EquipMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipMgrBtn.Location = new System.Drawing.Point(3, 45);
            this.EquipMgrBtn.Name = "EquipMgrBtn";
            this.EquipMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.EquipMgrBtn.TabIndex = 0;
            this.EquipMgrBtn.Text = "Equipment Mgr";
            this.EquipMgrBtn.UseVisualStyleBackColor = true;
            this.EquipMgrBtn.Click += new System.EventHandler(this.EquipMgrBtn_Click);
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(86, 139);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.RowTemplate.Height = 24;
            this.ReportDataGrid.Size = new System.Drawing.Size(304, 182);
            this.ReportDataGrid.TabIndex = 5;
            // 
            // GenerateReport
            // 
            this.GenerateReport.Location = new System.Drawing.Point(171, 45);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(103, 24);
            this.GenerateReport.TabIndex = 4;
            this.GenerateReport.Text = "Generate";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // ReportSelector
            // 
            this.ReportSelector.FormattingEnabled = true;
            this.ReportSelector.Items.AddRange(new object[] {
            "Sales by date",
            "Sales by customer",
            "List items by category"});
            this.ReportSelector.Location = new System.Drawing.Point(32, 45);
            this.ReportSelector.Name = "ReportSelector";
            this.ReportSelector.Size = new System.Drawing.Size(133, 24);
            this.ReportSelector.TabIndex = 3;
            this.ReportSelector.Text = "Select Report";
            this.ReportSelector.SelectedIndexChanged += new System.EventHandler(this.ReportSelector_SelectedIndexChanged);
            // 
            // OperatorText
            // 
            this.OperatorText.AutoSize = true;
            this.OperatorText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorText.Location = new System.Drawing.Point(415, 13);
            this.OperatorText.Name = "OperatorText";
            this.OperatorText.Size = new System.Drawing.Size(68, 18);
            this.OperatorText.TabIndex = 2;
            this.OperatorText.Text = "Operator:";
            // 
            // OperatorLabel
            // 
            this.OperatorLabel.AutoSize = true;
            this.OperatorLabel.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorLabel.Location = new System.Drawing.Point(489, 15);
            this.OperatorLabel.Name = "OperatorLabel";
            this.OperatorLabel.Size = new System.Drawing.Size(80, 15);
            this.OperatorLabel.TabIndex = 1;
            this.OperatorLabel.Text = "Not Logged In";
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportUI";
            this.Text = "ReportUI";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label ReportPageTitle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button SysMgrBtn;
        private System.Windows.Forms.Button ReportMgrBtn;
        private System.Windows.Forms.Button RentMgrBtn;
        private System.Windows.Forms.Button CustomMgrBtn;
        private System.Windows.Forms.Button CatMgrBtn;
        private System.Windows.Forms.Button EquipMgrBtn;
        private System.Windows.Forms.Label OperatorText;
        private System.Windows.Forms.Label OperatorLabel;
        private System.Windows.Forms.ComboBox ReportSelector;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.DataGridView ReportDataGrid;
    }
}