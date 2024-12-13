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
        private void Home_Click(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.ShowDialog();

            this.Hide();
        }

        private void EquipMgrBtn_Click(object sender, EventArgs e)
        {
            EquipmentUI equipmentUI = new EquipmentUI();
            equipmentUI.ShowDialog();

            this.Hide();
        }

        private void CatMgrBtn_Click(object sender, EventArgs e)
        {
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.ShowDialog();

            this.Hide();
        }

        private void CustomMgrBtn_Click(object sender, EventArgs e)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.ShowDialog();

            this.Hide();
        }

        private void RentMgrBtn_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();
            rental.ShowDialog();

            this.Hide();
        }

        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.ShowDialog();

            this.Hide();
        }


    }
}