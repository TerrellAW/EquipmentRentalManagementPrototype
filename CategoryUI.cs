using EquipmentRentalManagementPrototype.database;
using EquipmentRentalManagementPrototype.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRentalManagementPrototype
{
    public partial class CategoryUI : Form
    {
        private CategoryRepository categoryRepository;
        public CategoryUI()
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository();
        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {
            categoryListBox.Items.Clear();
            var categories = categoryRepository.GetAllCategories();
            foreach (var category in categories)
            {
                categoryListBox.Items.Add(category).ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please enter a category ID");
                return;
            }
            var category = categoryRepository.GetCategoryById(int.Parse(searchTextBox.Text));
            if (category != null)
            {
                categoryListBox.Items.Clear();
                categoryListBox.Items.Add(category).ToString();
            }
            else
            {
                categoryListBox.Items.Clear();
                MessageBox.Show("Category not found");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = addNameTextBox.Text;
                string id = addIdTextBox.Text;
                if (name != "" && id != "")
                {
                    categoryRepository.AddCategory(new Category(int.Parse(id), name));
                    MessageBox.Show("Category added");

                    addIdTextBox.Text = "";
                    addNameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill in all fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                var category = (Category)categoryListBox.SelectedItem;
                addIdTextBox.Text = category.Id.ToString();
                addNameTextBox.Text = category.Name;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                var category = (Category)categoryListBox.SelectedItem;
                categoryRepository.DeleteCategory(category.Id);
                categoryListBox.Items.Remove(category);
                addIdTextBox.Text = "";
                addNameTextBox.Text = "";
                MessageBox.Show("Category deleted");
            }
            else
            {
                MessageBox.Show("Please select a category to delete");
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
            Rental rental = new Rental();
            rental.Show();

            this.Hide();
        }

        private void EquipRentMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }
    }
}
