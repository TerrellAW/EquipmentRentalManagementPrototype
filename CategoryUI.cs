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
            var category = categoryRepository.GetCategoryById(int.Parse(searchTextBox.Text));
            if (category != null)
            {
                categoryListBox.Items.Clear();
                categoryListBox.Items.Add(category).ToString();
            }
            else
            {
                MessageBox.Show("Category not found");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = addnameTextBox.Text;
            string id = addIdTextBox.Text;
            if (name != "" && id != "")
            {
                categoryRepository.AddCategory(new Category(int.Parse(id), name));
                MessageBox.Show("Category added");

                addIdTextBox.Text = "";
                addnameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                var category = (Category)categoryListBox.SelectedItem;
                addIdTextBox.Text = category.Id.ToString();
                addnameTextBox.Text = category.Name;
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
                addnameTextBox.Text = "";
                MessageBox.Show("Category deleted");
            }
            else
            {
                MessageBox.Show("Please select a category to delete");
            }

        }
    }
}
