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

namespace EquipmentRentalManagementPrototype
{
    public partial class CustomerUI : Form
    {
        int inputId;
        string inputLastName;
        string inputFirstName;
        bool status;
        string inputPhone;
        string inputEmail;
        bool inputDiscount;

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

        private void customerIdInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                inputId = int.Parse(input.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
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

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            inputPhone = input.Text;
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            inputEmail = input.Text;
        }

        private void DiscountSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Text == "Yes")
            {
                inputDiscount = true;
            }
            else
            {
                inputDiscount = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(
                $"Id: {inputId}\n" +
                $"Last Name: {inputLastName}\n" +
                $"First Name: {inputFirstName}\n" +
                $"Status: {status}\n" +
                $"Phone: {inputPhone}\n" +
                $"Email: {inputEmail}\n" +
                $"Discount: {inputDiscount}\n"
                );

            // Add customer to database

        }
    }
}
