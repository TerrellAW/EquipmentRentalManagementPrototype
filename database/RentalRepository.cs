using EquipmentRentalManagementPrototype.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentRentalManagementPrototype.database
{
    internal class RentalRepository
    {
        private DBconnector dbConnector;

        public RentalRepository()
        {
            dbConnector = new DBconnector();
        }

        public List<Rental> GetAllRentals()
        {
            string query = "SELECT * FROM rental_list";
            var result = dbConnector.ExecuteQuery(query);
            List<Rental> rentals = new List<Rental>();
            foreach (var item in result)
            {
                rentals.Add(new Rental((int)item["rental_id"], (DateTime)item["date"], (int)item["customer_id"], (int)item["equipment_id"], (DateTime)item["rental_date"], (DateTime)item["return_date"], (float)item["cost"]));
            }
            return rentals;
        }

        public void AddRental(Rental rental)
        {
            string query = $"INSERT INTO rental_list (rental_id, date, customer_id, equipment_id, rental_date, return_date, cost) VALUES ('{rental.RentalId}', '{rental.Date.ToString("yyyy-MM-dd")}', {rental.CustomerId}, {rental.EquipmentId}, '{rental.RentalDate.ToString("yyyy-MM-dd")}', '{rental.ReturnDate.ToString("yyyy-MM-dd")}', {rental.Cost})";
            dbConnector.ExecuteQuery(query);
        }

        public Rental GetRentalById(int id)
        {
            string query = $"SELECT * FROM rental_list WHERE rental_id = {id}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }

            return new Rental((int)result[0]["rental_id"], (DateTime)result[0]["date"], (int)result[0]["customer_id"], (int)result[0]["equipment_id"], (DateTime)result[0]["rental_date"], (DateTime)result[0]["return_date"], (float)result[0]["cost"]);
        }

        public Rental GetRentalByCustomerId(int id)
        {
            string query = $"SELECT * FROM rental_list WHERE customer_id = {id}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }

            return new Rental((int)result[0]["rental_id"], (DateTime)result[0]["date"], (int)result[0]["customer_id"], (int)result[0]["equipment_id"], (DateTime)result[0]["rental_date"], (DateTime)result[0]["return_date"], (float)result[0]["cost"]);
        }

        public Rental GetRentalByEquipmentId(int id)
        {
            string query = $"SELECT * FROM rental_list WHERE equipment_id = {id}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }

            return new Rental((int)result[0]["rental_id"], (DateTime)result[0]["date"], (int)result[0]["customer_id"], (int)result[0]["equipment_id"], (DateTime)result[0]["rental_date"], (DateTime)result[0]["return_date"], (float)result[0]["cost"]);
        }


        public void DeleteRental(int id)
        {
            string query = $"DELETE FROM rental_list WHERE rental_id = {id}";
            dbConnector.ExecuteQuery(query);
        }
    }
}
