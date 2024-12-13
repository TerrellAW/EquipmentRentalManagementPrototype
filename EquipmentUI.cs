using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.database;
using EquipmentRentalManagementPrototype.domain;

namespace EquipmentRentalManagementPrototype
{
    public partial class EquipmentUI : Form
    {
        private EquipmentRepository equipmentRepository;
        public EquipmentUI()
        {
            InitializeComponent();
            equipmentRepository = new EquipmentRepository();
        }

        private void DisplayAll_Click(object sender, EventArgs e)
        {
            equipmentListBox.Items.Clear();
            var equipment = equipmentRepository.GetAllEquipment();
            foreach (var eq in equipment)
            {
                equipmentListBox.Items.Add(eq).ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (searchTextBox1.Text == "")
            {
                MessageBox.Show("Please enter an equipment ID");
                return;
            }
            var eq = equipmentRepository.GetEquipmentById(int.Parse(searchTextBox1.Text));
            if (eq != null)
            {
                equipmentListBox.Items.Clear();
                equipmentListBox.Items.Add(eq).ToString();
            }
            else
            {
                equipmentListBox.Items.Clear();
                MessageBox.Show("Equipment not found");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = addIdTextBox1.Text;
                string name = addNameTextBox1.Text;
                string description = addDescBox1.Text;
                string categoryId = addIdBox2.Text;
                string dailyRate = addRateBox1.Text;
                string status = addStatusBox1.Text;

                if (id != "" && name != "" && description != "" && categoryId != "" && dailyRate != "")
                {
                    equipmentRepository.AddEquipment(new Equipment(int.Parse(id), name, description, int.Parse(categoryId), float.Parse(dailyRate), status));
                    MessageBox.Show("Equipment added");

                    addIdTextBox1.Text = "";
                    addNameTextBox1.Text = "";
                    addDescBox1.Text = "";
                    addIdBox2.Text = "";
                    addRateBox1.Text = "";
                    addStatusBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem != null)
            {
                var eq = (Equipment)equipmentListBox.SelectedItem;
                equipmentRepository.DeleteEquipment(eq.Id);
                MessageBox.Show("Equipment removed");
            }
            else
            {
                MessageBox.Show("Please select an equipment to remove");
            }
        }

        private void equipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentListBox.SelectedItem != null)
            {
                var eq = (Equipment)equipmentListBox.SelectedItem;
                addIdTextBox1.Text = eq.Id.ToString();
                addNameTextBox1.Text = eq.Name;
                addDescBox1.Text = eq.Description;
                addIdBox2.Text = eq.CategoryId.ToString();
                addRateBox1.Text = eq.DailyRate.ToString();
                addStatusBox1.Text = eq.Status;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string id = addIdTextBox1.Text;
            string name = addNameTextBox1.Text;
            string description = addDescBox1.Text;
            string categoryId = addIdBox2.Text;
            string dailyRate = addRateBox1.Text;
            string status = addStatusBox1.Text;
            if (id != "" && name != "" && description != "" && categoryId != "" && dailyRate != "")
            {
                equipmentRepository.UpdateEquipment(new Equipment(int.Parse(id), name, description, int.Parse(categoryId), float.Parse(dailyRate), status));
                MessageBox.Show("Equipment updated");

                addIdTextBox1.Text = "";
                addNameTextBox1.Text = "";
                addDescBox1.Text = "";
                addIdBox2.Text = "";
                addRateBox1.Text = "";
                addStatusBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }


        // Navigation
        private void Home_Click(object sender, EventArgs e)
        {
            MainUI mainUI = new MainUI();
            mainUI.Show();

            this.Hide();
        }

        private void CatMgrBtn_Click(object sender, EventArgs e)
        {
            CategoryUI categoryUI = new CategoryUI();
            categoryUI.Show();

            this.Hide();
        }

        private void EquipMgrBtn_Click(object sender, EventArgs e)
        {
            EquipmentUI equipmentUI = new EquipmentUI();
            equipmentUI.Show();

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

        private void ReportMgrBtn_Click(object sender, EventArgs e)
        {
            ReportUI reportUI = new ReportUI();
            reportUI.Show();

            this.Hide();
        }
    }
}
