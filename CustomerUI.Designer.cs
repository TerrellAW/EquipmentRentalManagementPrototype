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
            this.CustomerPageTitle = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SysMgrBtn = new System.Windows.Forms.Button();
            this.EquipRentMgrBtn = new System.Windows.Forms.Button();
            this.RentMgrBtn = new System.Windows.Forms.Button();
            this.CustomMgrBtn = new System.Windows.Forms.Button();
            this.CatMgrBtn = new System.Windows.Forms.Button();
            this.EquipMgrBtn = new System.Windows.Forms.Button();
            this.DiscountInput = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.StatusSelector = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.customerIdInput = new System.Windows.Forms.TextBox();
            this.CustomerIdLabl = new System.Windows.Forms.Label();
            this.AddCustomerLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.DisplayAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchCustomerLabel = new System.Windows.Forms.Label();
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
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Panel2.Controls.Add(this.DiscountInput);
            this.splitContainer2.Panel2.Controls.Add(this.Remove);
            this.splitContainer2.Panel2.Controls.Add(this.Add);
            this.splitContainer2.Panel2.Controls.Add(this.EmailInput);
            this.splitContainer2.Panel2.Controls.Add(this.EmailLabel);
            this.splitContainer2.Panel2.Controls.Add(this.phoneInput);
            this.splitContainer2.Panel2.Controls.Add(this.PhoneLabel);
            this.splitContainer2.Panel2.Controls.Add(this.DiscountLabel);
            this.splitContainer2.Panel2.Controls.Add(this.StatusSelector);
            this.splitContainer2.Panel2.Controls.Add(this.StatusLabel);
            this.splitContainer2.Panel2.Controls.Add(this.firstNameInput);
            this.splitContainer2.Panel2.Controls.Add(this.FirstNameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.lastNameInput);
            this.splitContainer2.Panel2.Controls.Add(this.LastNameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.customerIdInput);
            this.splitContainer2.Panel2.Controls.Add(this.CustomerIdLabl);
            this.splitContainer2.Panel2.Controls.Add(this.AddCustomerLabel);
            this.splitContainer2.Panel2.Controls.Add(this.listBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.Search);
            this.splitContainer2.Panel2.Controls.Add(this.DisplayAll);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Panel2.Controls.Add(this.SearchCustomerLabel);
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
            // DiscountInput
            // 
            this.DiscountInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DiscountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscountInput.Location = new System.Drawing.Point(453, 258);
            this.DiscountInput.Name = "DiscountInput";
            this.DiscountInput.Size = new System.Drawing.Size(130, 22);
            this.DiscountInput.TabIndex = 31;
            this.DiscountInput.Validating += new System.ComponentModel.CancelEventHandler(this.DiscountInput_Validating);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Remove.Location = new System.Drawing.Point(511, 309);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(72, 26);
            this.Remove.TabIndex = 30;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Add.Location = new System.Drawing.Point(411, 309);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(72, 26);
            this.Add.TabIndex = 28;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInput.Location = new System.Drawing.Point(453, 229);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(130, 22);
            this.EmailInput.TabIndex = 27;
            this.EmailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInput_Validating);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(346, 232);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 18);
            this.EmailLabel.TabIndex = 26;
            this.EmailLabel.Text = "Email";
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneInput.Location = new System.Drawing.Point(453, 201);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(130, 22);
            this.phoneInput.TabIndex = 25;
            this.phoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.phoneInput_Validating);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(346, 204);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(51, 18);
            this.PhoneLabel.TabIndex = 24;
            this.PhoneLabel.Text = "Phone";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(346, 258);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(67, 18);
            this.DiscountLabel.TabIndex = 23;
            this.DiscountLabel.Text = "Discount";
            // 
            // StatusSelector
            // 
            this.StatusSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusSelector.FormattingEnabled = true;
            this.StatusSelector.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.StatusSelector.Location = new System.Drawing.Point(453, 171);
            this.StatusSelector.Name = "StatusSelector";
            this.StatusSelector.Size = new System.Drawing.Size(130, 24);
            this.StatusSelector.TabIndex = 21;
            this.StatusSelector.Text = "Active";
            this.StatusSelector.SelectedIndexChanged += new System.EventHandler(this.StatusSelector_SelectedIndexChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(346, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(50, 18);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Status";
            // 
            // firstNameInput
            // 
            this.firstNameInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameInput.Location = new System.Drawing.Point(453, 141);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(130, 22);
            this.firstNameInput.TabIndex = 19;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(346, 144);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(81, 18);
            this.FirstNameLabel.TabIndex = 18;
            this.FirstNameLabel.Text = "First Name";
            // 
            // lastNameInput
            // 
            this.lastNameInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lastNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameInput.Location = new System.Drawing.Point(453, 113);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(130, 22);
            this.lastNameInput.TabIndex = 17;
            this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(346, 116);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(80, 18);
            this.LastNameLabel.TabIndex = 16;
            this.LastNameLabel.Text = "Last Name";
            // 
            // customerIdInput
            // 
            this.customerIdInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.customerIdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerIdInput.Location = new System.Drawing.Point(453, 85);
            this.customerIdInput.Name = "customerIdInput";
            this.customerIdInput.Size = new System.Drawing.Size(130, 22);
            this.customerIdInput.TabIndex = 15;
            this.customerIdInput.Validating += new System.ComponentModel.CancelEventHandler(this.customerIdInput_Validating);
            // 
            // CustomerIdLabl
            // 
            this.CustomerIdLabl.AutoSize = true;
            this.CustomerIdLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabl.Location = new System.Drawing.Point(346, 88);
            this.CustomerIdLabl.Name = "CustomerIdLabl";
            this.CustomerIdLabl.Size = new System.Drawing.Size(92, 18);
            this.CustomerIdLabl.TabIndex = 14;
            this.CustomerIdLabl.Text = "Customer ID";
            // 
            // AddCustomerLabel
            // 
            this.AddCustomerLabel.AutoSize = true;
            this.AddCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerLabel.Location = new System.Drawing.Point(399, 45);
            this.AddCustomerLabel.Name = "AddCustomerLabel";
            this.AddCustomerLabel.Size = new System.Drawing.Size(184, 22);
            this.AddCustomerLabel.TabIndex = 13;
            this.AddCustomerLabel.Text = "Add Customer Details";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(34, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 196);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search Result";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Search.Location = new System.Drawing.Point(143, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 26);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DisplayAll
            // 
            this.DisplayAll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DisplayAll.Location = new System.Drawing.Point(32, 85);
            this.DisplayAll.Name = "DisplayAll";
            this.DisplayAll.Size = new System.Drawing.Size(84, 26);
            this.DisplayAll.TabIndex = 9;
            this.DisplayAll.Text = "Display All";
            this.DisplayAll.UseVisualStyleBackColor = false;
            this.DisplayAll.Click += new System.EventHandler(this.DisplayAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(32, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // SearchCustomerLabel
            // 
            this.SearchCustomerLabel.AutoSize = true;
            this.SearchCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerLabel.Location = new System.Drawing.Point(28, 15);
            this.SearchCustomerLabel.Name = "SearchCustomerLabel";
            this.SearchCustomerLabel.Size = new System.Drawing.Size(184, 20);
            this.SearchCustomerLabel.TabIndex = 7;
            this.SearchCustomerLabel.Text = "Search Customer by ID";
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
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button DisplayAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SearchCustomerLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddCustomerLabel;
        private System.Windows.Forms.TextBox customerIdInput;
        private System.Windows.Forms.Label CustomerIdLabl;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.ComboBox StatusSelector;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox DiscountInput;
    }
}