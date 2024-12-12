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

        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public static Customer SearchCustomer(string fName, string lName)
        {
            foreach (Customer customer in customerList)
            {
                if (customer.FirstName == fName)
                {
                    return customer;
                }
                else if (customer.LastName == lName)
                {
                    return customer;
                }
            }
            return null;
        }

        public static void UpdateCustomer(Customer customer)
        {
            Customer existingCustomer = SearchCustomer(customer.FirstName, customer.LastName);
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
    }
}
