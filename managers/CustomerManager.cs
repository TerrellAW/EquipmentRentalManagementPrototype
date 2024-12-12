using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipmentRentalManagementPrototype.domain;

namespace EquipmentRentalManagementPrototype.managers
{
    internal class CustomerManager
    {
        private static List<Customer> customerList = new List<Customer>();

        public static List<Customer> CustomerList
        {
            get { return customerList; }
        }

        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public static List<string> SearchCustomer(string fName, string lName)
        {
            List<string> searchedCustomers = new List<string>();
            foreach (Customer customer in customerList)
            {
                if (customer.FirstName == fName)
                {
                    searchedCustomers.Add($"{customer.Id} - {customer.FirstName} {customer.LastName}");
                }
                else if (customer.LastName == lName)
                {
                    searchedCustomers.Add($"{customer.Id} - {customer.FirstName} {customer.LastName}");
                }
            }
            return searchedCustomers;
        }

        public static Customer SearchCustomerId(int customerId)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.Id == customerId)
                {
                    return customer;
                }
            }
            return null;
        }

        public static void UpdateCustomer(Customer customer)
        {
            Customer existingCustomer = SearchCustomerId(customer.Id);
            if (existingCustomer != null)
            {
                existingCustomer.Id = customer.Id;
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Phone = customer.Phone;
                existingCustomer.Email = customer.Email;
                existingCustomer.Status = customer.Status;
                existingCustomer.Discount = customer.Discount;
                existingCustomer.SalesAmount = customer.SalesAmount;
            }
        }

        public static void DeleteCustomer(Customer customer)
        {
            customerList.Remove(customer);
        }

        public static List<string> DisplayAllCustomers()
        {
            List<string> customerDetails = new List<string>();
            if (!customerList.Any())
            {
                customerDetails.Add("No customers found.");
            }
            foreach (Customer customer in customerList)
            {
                customerDetails.Add($"{customer.Id} - {customer.FirstName} {customer.LastName}");
            }
            return customerDetails;
        }
    }
}
