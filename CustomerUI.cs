using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.domain;
using EquipmentRentalManagementPrototype.managers;

namespace EquipmentRentalManagementPrototype
{
    public partial class CustomerUI : Form
    {
        int inputId;
        string inputLastName;
        string inputFirstName;
        bool status = true;
        string inputPhone;
        string inputEmail;
        double inputDiscount = 0;

        public CustomerUI()
        {
            InitializeComponent();
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainerTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerIdInput_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                inputId = int.Parse(input.Text);
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show("Please enter a valid customer ID number.");
            }
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            inputLastName = input.Text;
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            inputFirstName = input.Text;
        }

        private void StatusSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Text == "Active")
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        private void phoneInput_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string errorMessage = "Please enter a valid phone number.";
            try
            {
                string cleanedPhone = input.Text.Replace("(", "")
                                                .Replace(")", "")
                                                .Replace("-", "")
                                                .Replace(" ", "");

                long phoneNum = long.Parse(cleanedPhone);

                if (string.IsNullOrEmpty(cleanedPhone))
                {
                    input.Text = string.Empty;
                    MessageBox.Show(errorMessage);
                    return;
                }
                else if (cleanedPhone.Length != 10)
                {
                    input.Text = string.Empty;
                    MessageBox.Show(errorMessage);
                    return;
                }
                string formattedPhone = $"{cleanedPhone.Substring(0, 3)}-{cleanedPhone.Substring(3, 3)}-{cleanedPhone.Substring(6, 4)}";
                inputPhone = formattedPhone;
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show(errorMessage);
            }
        }

        private void EmailInput_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string errorMessage = "Please enter a valid email address.";
            if (string.IsNullOrEmpty(input.Text))
            {
                input.Text = string.Empty;
                MessageBox.Show(errorMessage);
                return;
            }
            else if (!input.Text.Contains("@") || !input.Text.Contains("."))
            {
                input.Text = string.Empty;
                MessageBox.Show(errorMessage);
                return;
            }
            inputEmail = input.Text.ToLower();
        }

        private void DiscountInput_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string errorMessage = "Please enter a valid discount percentage.";
            double inputDouble;
            try
            {
                inputDouble = double.Parse(input.Text);
                if (inputDouble >= 0 && inputDouble <= 100)
                {
                    inputDiscount = inputDouble;
                }
                else
                {
                    input.Text = string.Empty;
                    MessageBox.Show(errorMessage);
                }
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show(errorMessage);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Create new customer object and add to customerList
            Customer customer = new Customer(
                inputId, 
                inputLastName, 
                inputFirstName, 
                inputPhone, 
                inputEmail, 
                status, 
                inputDiscount, 
                0
                );

            Debug.WriteLine(customer.ToString());

            CustomerManager.AddCustomer(customer);

            // Add customer to database

        }
    }
}
