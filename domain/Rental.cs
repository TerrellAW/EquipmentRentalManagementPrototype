using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentRentalManagementPrototype.domain
{
    internal class Rental
    {
        private int _rentalId;
        private DateTime _date;
        private int _customerId;
        private int _equipmentId;
        private DateTime _rentalDate;
        private DateTime _returnDate;
        private double _cost;

        public int RentalId
        {
            get { return _rentalId; }
            set { _rentalId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public int EquipmentId
        {
            get { return _equipmentId; }
            set { _equipmentId = value; }
        }

        public DateTime RentalDate
        {
            get { return _rentalDate; }
            set { _rentalDate = value; }
        }

        public DateTime ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Rental()
        {
            _rentalId = 0;
            _customerId = 0;
            _equipmentId = 0;
            _cost = 0;
        }

        public Rental(int rentalId, DateTime date, int customerId, int equipmentId, DateTime rentalDate, DateTime returnDate, double cost)
        {
            _rentalId = rentalId;
            _date = date;
            _customerId = customerId;
            _equipmentId = equipmentId;
            _rentalDate = rentalDate;
            _returnDate = returnDate;
            _cost = cost;
        }

        public override string ToString()
        {
            return
                $"{_rentalId} - {_date} - {_cost} \n";
        }
    }
}
