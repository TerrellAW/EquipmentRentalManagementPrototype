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
using EquipmentRentalManagementPrototype.database;

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
        Customer displayedCustomer;
        string inputSearch;
        private CustomerRepository customerRepository;

        public CustomerUI()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            customerRepository.GetAllCustomers();
            Debug.WriteLine("Customer List Contains:\n");
            CustomerManager.ListData();
        }

        private void splitContainerTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            string fName = string.Empty;
            string lName = string.Empty;
            if (input.Text.Contains(" "))
            {
                string[] fullName = input.Text.Split(' ');
                lName = fullName[0];
                lName = fullName[1];
            }
            else
            {
                fName = input.Text;
                lName = input.Text;
            }

            listBox1.DataSource = CustomerManager.SearchCustomer(fName, lName);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = CustomerManager.DisplayAllCustomers();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCustomer;
            string[] splitCustomer;
            int customerId;
            if (listBox1.SelectedItem != null)
            {
                selectedCustomer = listBox1.SelectedItem.ToString();
                try
                {
                    splitCustomer = selectedCustomer.Trim(' ').Split('-');
                    customerId = int.Parse(splitCustomer[0]);
                    Debug.WriteLine("Selected customer's ID: " + customerId);

                    // Search for the customer in the customerList
                    displayedCustomer = CustomerManager.CustomerList.FirstOrDefault(customer => customer.Id == customerId);

                    if (displayedCustomer != null)
                    {
                        customerIdInput.Text = $"{displayedCustomer.Id}";
                        customerIdInput_Validating(customerIdInput, e);

                        lastNameInput.Text = displayedCustomer.LastName;
                        lastNameInput_TextChanged(lastNameInput, e);

                        firstNameInput.Text = displayedCustomer.FirstName;
                        firstNameInput_TextChanged(firstNameInput, e);

                        StatusSelector.SelectedIndex = displayedCustomer.Status ? 0 : 1;
                        StatusSelector_SelectedIndexChanged(StatusSelector, e);

                        phoneInput.Text = displayedCustomer.Phone;
                        phoneInput_Validating(phoneInput, e);

                        EmailInput.Text = displayedCustomer.Email;
                        EmailInput_Validating(EmailInput, e);

                        DiscountInput.Text = $"{displayedCustomer.Discount}";
                        DiscountInput_Validating(DiscountInput, e);
                    }
                    else
                    {
                        Debug.WriteLine("Customer not found.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Customer ID is invalid.");
                }
            }
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

            // Search for customer ID in customerList
            Customer customerSearched = CustomerManager.SearchCustomerId(inputId);

            // Deal with duplicate customer IDs
            if (customerSearched != null)
            {
                CustomerManager.DeleteCustomer(customerSearched);
                CustomerManager.AddCustomer(customer);
                customerRepository.UpdateCustomer(customerSearched, customer);
            }
            else
            {
                CustomerManager.AddCustomer(customer);
                customerRepository.AddCustomer(customer);
            }
            
            // Clear input fields
            customerIdInput.Text = string.Empty;
            lastNameInput.Text = string.Empty;
            firstNameInput.Text = string.Empty;
            phoneInput.Text = string.Empty;
            EmailInput.Text = string.Empty;
            DiscountInput.Text = string.Empty;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (displayedCustomer != null)
            {
                CustomerManager.DeleteCustomer(displayedCustomer);
                customerRepository.DeleteCustomer(displayedCustomer);
                displayedCustomer = null;
                customerIdInput.Text = string.Empty;
                lastNameInput.Text = string.Empty;
                firstNameInput.Text = string.Empty;
                StatusSelector.SelectedIndex = 0;
                phoneInput.Text = string.Empty;
                EmailInput.Text = string.Empty;
                DiscountInput.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a customer to remove.");
            }
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

        private void RentMgrBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }
    }
}
