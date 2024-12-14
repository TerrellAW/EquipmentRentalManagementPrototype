using EquipmentRentalManagementPrototype.database;
using EquipmentRentalManagementPrototype.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRentalManagementPrototype
{
    public partial class ReportUI : Form
    {
        CustomerRepository customerRepository;
        CategoryRepository categoryRepository;
        int? selectedReportIndex = null;

        public ReportUI()
        {
            InitializeComponent();
            ReportDataGrid.Hide();
            customerRepository = new CustomerRepository();
            categoryRepository = new CategoryRepository();
        }

        private void splitContainerTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Sales by date
            if (comboBox.SelectedIndex == 0)
            {
                selectedReportIndex = 0;
            }
            // Sales by customer
            else if (comboBox.SelectedIndex == 1)
            {
                selectedReportIndex = 1;
            }
            // List items by category
            else if (comboBox.SelectedIndex == 2)
            {
                selectedReportIndex = 2;
            }
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            if (selectedReportIndex == 0)
            {
                // Sales by date

                // DataGrid setup
                ReportDataGrid.Show();
                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Rows.Clear();
                ReportDataGrid.Columns.Add("Date", "Date");
                ReportDataGrid.Columns.Add("Total Sales", "Total Sales");

                // Data retrieval
                var SalesByDate = customerRepository.GetSalesByDate();
                foreach (var row in SalesByDate)
                {
                    ReportDataGrid.Rows.Add(row["date"].ToString(), row["total_sales"].ToString());
                }
            }
            else if (selectedReportIndex == 1)
            {
                // Sales by customer

                // DataGrid setup
                ReportDataGrid.Show();
                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Rows.Clear();
                ReportDataGrid.Columns.Add("Customer", "Customer");
                ReportDataGrid.Columns.Add("Total Sales", "Total Sales");

                // Data retrieval
                var SalesByCustomer = customerRepository.GetSalesByCustomer();
                foreach (var row in SalesByCustomer)
                {
                    ReportDataGrid.Rows.Add(row["customer_id"].ToString(), row["total_sales"].ToString());
                }
            }
            else if (selectedReportIndex == 2)
            {
                // List items by category

                // DataGrid setup
                ReportDataGrid.Show();
                ReportDataGrid.Columns.Clear();
                ReportDataGrid.Rows.Clear();
                ReportDataGrid.Columns.Add("Category", "Category");
                ReportDataGrid.Columns.Add("Item", "Item");

                // Data retrieval
                var ItemsByCategory = categoryRepository.GetItemsByCategory();
                foreach (var row in ItemsByCategory)
                {
                    int categoryId = (int)row["category_id"];
                    ReportDataGrid.Rows.Add(row["category_id"].ToString(), row["equipment_name"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a report type.");
            }
        }


        // Navigation buttons
        private void Home_Click(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.Show();

            this.Hide();
        }

        private void EquipMgrBtn_Click(object sender, EventArgs e)
        {
            EquipmentUI equipmentUI = new EquipmentUI();
            equipmentUI.Show();

            this.Hide();
        }

        private void CatMgrBtn_Click(object sender, EventArgs e)
        {
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.Show();

            this.Hide();
        }

        private void CustomMgrBtn_Click(object sender, EventArgs e)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.Show();

            this.Hide();
        }

        private void RentMgrBtn_Click(object sender, EventArgs e)
        {
            RentalUI rental = new RentalUI();
            rental.Show();

            this.Hide();
        }

        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }
        
    }
}
