/*
 * Program Name: Equipment Rent Management
 * Author: Flora Wang
 * Date: 2024/12/12
 * Description: Equipment Rent Management
 */
using EquipmentRentalManagementPrototype.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.domain;
using EquipmentRentalManagementPrototype.managers;
using System.Diagnostics;

namespace EquipmentRentalManagementPrototype
{
    public partial class RentalUI : Form
    {
        int inputId;
        DateTime currDate = DateTime.Now;
        int inputCustId;
        int inputEquipId;
        DateTime inputRentDate;
        DateTime inputReturnDate;
        double inputCost;
        private RentalRepository rentalRepository;
        private CustomerRepository customerRepository;
        private EquipmentRepository equipmentRepository;
        private Equipment equipment;
        private Customer customer;

        public RentalUI()
        {
            InitializeComponent();
            rentalRepository = new RentalRepository();
            customerRepository = new CustomerRepository();
            equipmentRepository = new EquipmentRepository();
        }

        //private void RentalUI_Load(object sender, EventArgs e)
        //{
        //    customerRepository.GetAllCustomers();
        //    Debug.WriteLine("Customer List Contains:\n");
        //    CustomerManager.ListData();
        //}

        // Search button
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Search by rental ID
            if (addIdTextBox1.Text != "")
            {
                try
                {
                    var rental = rentalRepository.GetRentalById(int.Parse(addIdTextBox1.Text));
                    if (rental != null)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(rental).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid rental ID");
                }
            }
            // Search by customer ID
            else if (textBox1.Text != "")
            {
                try
                {
                    var rental = rentalRepository.GetRentalByCustomerId(int.Parse(textBox1.Text));
                    if (rental != null)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(rental).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid customer ID");
                }
            }
            // Search by equipment ID
            else if (textBox2.Text != "")
            {
                try
                {
                    var rental = rentalRepository.GetRentalByEquipmentId(int.Parse(textBox2.Text));
                    if (rental != null)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(rental).ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid equipment ID");
                }
            }
            else
            {
                MessageBox.Show("Please fill a field to search");
            }
        }

        // Add button
        private void button2_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental(
                inputId,
                currDate,
                inputCustId,
                inputEquipId,
                inputRentDate,
                inputReturnDate,
                inputCost
                );

            Debug.WriteLine(rental.ToString());

            // Add rental to database
            rentalRepository.AddRental(rental);

            // Clear textboxes
            addIdTextBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            total.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox3.Text = string.Empty;
            label10.Text = string.Empty;
            label13.Text = string.Empty;
        }

        // Equipment ID textbox
        private void textBox5_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                inputEquipId = int.Parse(input.Text);

                // Find equipment by ID
                equipment = equipmentRepository.GetEquipmentById(inputEquipId);
                Debug.WriteLine(equipment.ToString());
                if (equipment != null)
                {
                   
                }
                else
                {
                    input.Text = string.Empty;
                    inputEquipId = 0;
                    MessageBox.Show("Equipment not found");
                }
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show("Please enter a valid equipment ID");
            }
        }

        // Customer ID textbox
        private void textBox3_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                inputCustId = int.Parse(input.Text);

                // Find customer by ID
                customer = CustomerManager.SearchCustomerId(inputCustId);
                Debug.WriteLine(customer.ToString());
                if (customer != null)
                {
                    label10.Text = customer.FirstName + " " + customer.LastName;
                }
                else
                {
                    input.Text = string.Empty;
                    inputCustId = 0;
                    MessageBox.Show("Customer not found");
                }
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show("Please enter a valid customer ID");
            }
        }

        private void IdInput_Validating(object sender, EventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                inputId = int.Parse(input.Text);

                // Check if ID already exists
                var rental = rentalRepository.GetRentalById(inputId);
                if (rental != null)
                {
                    input.Text = string.Empty;
                    inputId = 0;
                    MessageBox.Show("Rental ID already exists");
                }
            }
            catch (FormatException)
            {
                input.Text = string.Empty;
                MessageBox.Show("Please enter a valid rental ID");
            }
        }

        // Rental date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker input = (DateTimePicker)sender;
            inputRentDate = input.Value;

            CalculateTotal();
        }

        // Return date
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker input = (DateTimePicker)sender;
            inputReturnDate = input.Value;

            CalculateTotal();
        }
        


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Rental rental = (Rental)listBox1.SelectedItem;

                IdInput.Text = rental.RentalId.ToString();
                textBox3.Text = rental.CustomerId.ToString();
                textBox5.Text = rental.EquipmentId.ToString();
                dateTimePicker1.Value = rental.RentalDate;
                dateTimePicker2.Value = rental.ReturnDate;
                label10.Text = customer.FirstName + customer.LastName;

                date.Text = rental.Date.ToString();
              
                total.Text = rental.Cost.ToString();
            }
        }

        private void CalculateTotal()
        {
            if (equipment != null && inputRentDate != null && inputReturnDate != null)
            {
                TimeSpan timeSpan = inputReturnDate - inputRentDate;
                double totalCost = timeSpan.Days * equipment.DailyRate;
                total.Text = totalCost.ToString("F2");
                date.Text = currDate.ToString();
            }
            else
            {
                total.Text = "0.00";
                date.Text = currDate.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Rental rental = (Rental)listBox1.SelectedItem;
                rentalRepository.DeleteRental(rental.RentalId);
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Rental deleted");
            }
            else
            {
                MessageBox.Show("Please select a rental to delete");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var rentals = rentalRepository.GetAllRentals();
            foreach (var rental in rentals)
            {
                listBox1.Items.Add(rental.ToString());
            }
        }






        // Navigation buttons
        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }

        private void CustomMgrBtn_Click(object sender, EventArgs e)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.Show();

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

        private void RentMgrBtn_Click(object sender, EventArgs e)
        {
            RentalUI rental = new RentalUI();
            rental.Show();

            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.Show();

            this.Hide();
        }
    }
}