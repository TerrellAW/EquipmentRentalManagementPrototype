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
        private bool _banned;
        private bool _discount;
        private int _salesAmount;

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
        public bool Banned
        {
            get { return _banned; }
            set { _banned = value; }
        }
        public bool Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public int SalesAmount
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
            _banned = false;
            _discount = false;
            _salesAmount = 0;
        }
        public Customer(int id, string lastName, string firstName, string phone, string email, bool banned, bool discount, int salesAmount)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            Email = email;
            Banned = banned;
            Discount = discount;
            SalesAmount = salesAmount;
        }

        // Methods
        public override string ToString()
        {
            return 
                $"ID: {Id}\n " +
                $"Name: {FirstName} {LastName}\n " +
                $"Phone Number: {Phone}\n " +
                $"Email: {Email}\n " +
                $"Banned: {Banned}\n " +
                $"Discount: {Discount}\n " +
                $"Sales Amount: {SalesAmount}";
        }
    }
}
