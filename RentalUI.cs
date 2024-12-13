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

namespace EquipmentRentalManagementPrototype
{
    public partial class RentalUI : Form
    {
        private RentalRepository rentalRepository;

        public RentalUI()
        {
            InitializeComponent();
            rentalRepository = new RentalRepository();
        }

        // Navigation buttons

        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }

        private void CustomMgrBtn_Click_1(object sender, EventArgs e)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.Show();

            this.Hide();
        }

        private void EquipMgrBtn_Click_1(object sender, EventArgs e)
        {
            EquipmentUI equipmentUI = new EquipmentUI();
            equipmentUI.Show();

            this.Hide();
        }

        private void CatMgrBtn_Click_1(object sender, EventArgs e)
        {
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.Show();

            this.Hide();
        }

        private void RentMgrBtn_Click_1(object sender, EventArgs e)
        {
            RentalUI rental = new RentalUI();
            rental.Show();

            this.Hide();
        }



        private void Home_Click_1(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addIdTextBox1.Text != "")
            {
                var rental = rentalRepository.GetRentalById(int.Parse(addIdTextBox1.Text));
                if (rental != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(rental).ToString();
                }

            }
            else if (textBox1.Text != "")
            {
                var rental = rentalRepository.GetRentalByCustomerId(int.Parse(textBox1.Text));
                if (rental != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(rental).ToString();
                }
            }
            // Trouble parsing string to DateTime
            else if (textBox2.Text != "")
            {
                var rental = rentalRepository.GetRentalByDate(DateTime.Parse(textBox2.Text));
                if (rental != null)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(rental).ToString();
                }
            }
            else
            {
                MessageBox.Show("Please fill a field to search");
            }
        }
    }
}