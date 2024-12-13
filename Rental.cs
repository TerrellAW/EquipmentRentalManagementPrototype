﻿/*
 * Program Name: Equipment Rent Management
 * Author: Flora Wang
 * Date: 2024/12/12
 * Description: Equipment Rent Management
 */
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
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
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
            Rental rental = new Rental();
            rental.Show();

            this.Hide();
        }



        private void Home_Click_1(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.Show();

            this.Hide();
        }
    }
}