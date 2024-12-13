using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.domain;
using EquipmentRentalManagementPrototype.managers;

namespace EquipmentRentalManagementPrototype.database
{
    internal class CustomerRepository
    {
        private DBconnector dbConnector;

        public CustomerRepository()
        {
            dbConnector = new DBconnector();
        }

        public void GetAllCustomers()
        {
            string query = "SELECT * FROM customer_list";
            var result = dbConnector.ExecuteQuery(query);

            if (result != null)
            {
                foreach (var row in result)
                {
                    // Null handling
                    bool? nullableStatus = row["customer_status"] != DBNull.Value ? Convert.ToBoolean(row["customer_status"]) : (bool?)null;
                    double? nullableDiscount = row["discount"] != DBNull.Value ? Convert.ToDouble(row["discount"]) : (double?)null;
                    double? nullableSalesAmount = row["sales_amount"] != DBNull.Value ? Convert.ToDouble(row["sales_amount"]) : (double?)null;

                    if (nullableStatus == null)
                    {
                        nullableStatus = true;
                    }
                    if (nullableDiscount == null)
                    {
                        nullableDiscount = 0;
                    }
                    if (nullableSalesAmount == null)
                    {
                        nullableSalesAmount = 0;
                    }

                    bool status = (bool)nullableStatus;
                    double discount = (double)nullableDiscount;
                    double salesAmount = (double)nullableSalesAmount;

                    // Create customer object
                    Customer customer = new Customer(
                        (int)row["customer_id"],
                        (string)row["last_name"],
                        (string)row["first_name"],
                        (string)row["phone"],
                        (string)row["email"],
                        status,
                        discount,
                        salesAmount
                        );

                    // Add customer to list
                    CustomerManager.AddCustomer(customer);
                }
            }
        }

        public void AddCustomer(Customer customer)
        {
            string query = "INSERT INTO customer_list (customer_id, last_name, first_name, phone, email, customer_status, discount, sales_amount) VALUES ('" + customer.Id + "', '" + customer.LastName + "', '" + customer.FirstName + "', '" + customer.Phone + "', '" + customer.Email + "', " + customer.Status + ", " + customer.Discount + ", " + customer.SalesAmount + ")";
            dbConnector.ExecuteCommand(query);
        }

        public void UpdateCustomer(Customer customerOld, Customer customerNew)
        {
            string query = "UPDATE customer_list SET last_name = '" + customerNew.LastName + "', first_name = '" + customerNew.FirstName + "', phone = '" + customerNew.Phone + "', email = '" + customerNew.Email + "', customer_status = " + customerNew.Status + ", discount = " + customerNew.Discount + ", sales_amount = " + customerNew.SalesAmount + " WHERE customer_id = " + customerOld.Id;
            dbConnector.ExecuteCommand(query);
        }

        public void DeleteCustomer(Customer customer)
        {
            string query = "DELETE FROM customer_list WHERE customer_id = " + customer.Id;
            dbConnector.ExecuteCommand(query);
        }

        public List<Dictionary<string, object>> GetSalesByDate()
        {
            string query = "SELECT DATE(rental_date) AS date, SUM(cost) AS total_sales FROM rental_list GROUP BY DATE(rental_date)";
            return dbConnector.ExecuteQuery(query);
        }

        public List<Dictionary<string, object>> GetSalesByCustomer()
        {
            string query = "SELECT customer_id, SUM(cost) AS total_sales FROM rental_list GROUP BY customer_id";
            return dbConnector.ExecuteQuery(query);
        }
    }
}
