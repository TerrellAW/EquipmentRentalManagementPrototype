using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentRentalManagementPrototype.domain
{
    internal class Customer
    {
        // Fields
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _phone;
        private string _email;
        private bool _status;
        private double _discount;
        private double _salesAmount;

        // Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public double SalesAmount
        {
            get { return _salesAmount; }
            set { _salesAmount = value; }
        }

        // Constructors
        public Customer()
        {
            _id = 0;
            _lastName = "";
            _firstName = "";
            _phone = "";
            _email = "";
            _status = false;
            _discount = 0;
            _salesAmount = 0;
        }
        public Customer(int id, string lastName, string firstName, string phone, string email, bool banned, double discount, int salesAmount)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            Email = email;
            Status = banned;
            Discount = discount;
            SalesAmount = salesAmount;
        }

        // Methods
        public override string ToString()
        {
            return 
                "" +
                $"ID: {Id}\n " +
                $"Name: {FirstName} {LastName}\n " +
                $"Phone Number: {Phone}\n " +
                $"Email: {Email}\n " +
                $"Active: {Status}\n " +
                $"Discount: {Discount}%\n " +
                $"Sales Amount: ${SalesAmount}";
        }
    }
}
