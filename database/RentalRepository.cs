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

        public Rental GetRentalByDate(DateTime date)
        {
            string query = $"SELECT * FROM rental_list WHERE date = {date}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }

            return new Rental((int)result[0]["rental_id"], (DateTime)result[0]["date"], (int)result[0]["customer_id"], (int)result[0]["equipment_id"], (DateTime)result[0]["rental_date"], (DateTime)result[0]["return_date"], (float)result[0]["cost"]);
        }
    }
}
