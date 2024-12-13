﻿using System;
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
            string query = "INSERT INTO customer_list (customer_last_name, customer_first_name, customer_phone, customer_email, customer_status, customer_discount, customer_sales_amount) VALUES ('" + customer.LastName + "', '" + customer.FirstName + "', '" + customer.Phone + "', '" + customer.Email + "', " + customer.Status + ", " + customer.Discount + ", " + customer.SalesAmount + ")";
            dbConnector.ExecuteCommand(query);
        }

        public void UpdateCustomer(Customer customerOld, Customer customerNew)
        {
            string query = "UPDATE customer_list SET customer_last_name = '" + customerNew.LastName + "', customer_first_name = '" + customerNew.FirstName + "', customer_phone = '" + customerNew.Phone + "', customer_email = '" + customerNew.Email + "', customer_status = " + customerNew.Status + ", customer_discount = " + customerNew.Discount + ", customer_sales_amount = " + customerNew.SalesAmount + " WHERE customer_id = " + customerOld.Id;
            dbConnector.ExecuteCommand(query);
        }

        public void DeleteCustomer(Customer customer)
        {
            string query = "DELETE FROM customer_list WHERE customer_id = " + customer.Id;
            dbConnector.ExecuteCommand(query);
        }
    }
}