namespace EquipmentRentalManagementPrototype
{
    partial class CustomerUI
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
            this.OperatorLabel = new System.Windows.Forms.Label();
            this.OperatorText = new System.Windows.Forms.Label();
            this.EquipMgrBtn = new System.Windows.Forms.Button();
            this.CatMgrBtn = new System.Windows.Forms.Button();
            this.CustomMgrBtn = new System.Windows.Forms.Button();
            this.RentMgrBtn = new System.Windows.Forms.Button();
            this.EquipRentMgrBtn = new System.Windows.Forms.Button();
            this.SysMgrBtn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CustomerPageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.CustomerPageTitle);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerTop_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 1;
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
            // EquipMgrBtn
            // 
            this.EquipMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipMgrBtn.Location = new System.Drawing.Point(3, 45);
            this.EquipMgrBtn.Name = "EquipMgrBtn";
            this.EquipMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.EquipMgrBtn.TabIndex = 0;
            this.EquipMgrBtn.Text = "Equipment Mgr";
            this.EquipMgrBtn.UseVisualStyleBackColor = true;
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
            // 
            // EquipRentMgrBtn
            // 
            this.EquipRentMgrBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipRentMgrBtn.Location = new System.Drawing.Point(3, 233);
            this.EquipRentMgrBtn.Name = "EquipRentMgrBtn";
            this.EquipRentMgrBtn.Size = new System.Drawing.Size(168, 41);
            this.EquipRentMgrBtn.TabIndex = 4;
            this.EquipRentMgrBtn.Text = "Equipment Rental Mgr";
            this.EquipRentMgrBtn.UseVisualStyleBackColor = true;
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SysMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.EquipRentMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.RentMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.CustomMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.CatMgrBtn);
            this.splitContainer2.Panel1.Controls.Add(this.EquipMgrBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OperatorText);
            this.splitContainer2.Panel2.Controls.Add(this.OperatorLabel);
            this.splitContainer2.Size = new System.Drawing.Size(800, 374);
            this.splitContainer2.SplitterDistance = 174;
            this.splitContainer2.TabIndex = 0;
            // 
            // CustomerPageTitle
            // 
            this.CustomerPageTitle.AutoSize = true;
            this.CustomerPageTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPageTitle.Location = new System.Drawing.Point(201, 9);
            this.CustomerPageTitle.Name = "CustomerPageTitle";
            this.CustomerPageTitle.Size = new System.Drawing.Size(415, 49);
            this.CustomerPageTitle.TabIndex = 0;
            this.CustomerPageTitle.Text = "Customer Management";
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomerUI";
            this.Text = "Equipment Rental Management System";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label CustomerPageTitle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button SysMgrBtn;
        private System.Windows.Forms.Button EquipRentMgrBtn;
        private System.Windows.Forms.Button RentMgrBtn;
        private System.Windows.Forms.Button CustomMgrBtn;
        private System.Windows.Forms.Button CatMgrBtn;
        private System.Windows.Forms.Button EquipMgrBtn;
        private System.Windows.Forms.Label OperatorText;
        private System.Windows.Forms.Label OperatorLabel;
    }
}