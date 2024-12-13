using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.domain;

namespace EquipmentRentalManagementPrototype.database
{
    internal class EquipmentRepository
    {
        private DBconnector dbConnector;

        public EquipmentRepository()
        {
            dbConnector = new DBconnector();
        }

        public List<Equipment> GetAllEquipment()
        {
            string query = "SELECT * FROM equipment_list";
            var result = dbConnector.ExecuteQuery(query);

            List<Equipment> eqs = new List<Equipment>();
            foreach (var row in result)
            {
                eqs.Add(new Equipment((int)row["equipment_id"], (string)row["equipment_name"], (string)row["description"], (int)row["category_id"], (float)row["daily_rate"], row["status"] != DBNull.Value ? (string)row["status"] : string.Empty));
            }
            return eqs;
        }

        public Equipment GetEquipmentById(int id)
        {
            string query = $"SELECT * FROM equipment_list WHERE equipment_id = {id}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }

            string status = result[0]["status"] != DBNull.Value ? (string)result[0]["status"] : string.Empty;
            return new Equipment((int)result[0]["equipment_id"], (string)result[0]["equipment_name"], (string)result[0]["description"], (int)result[0]["category_id"], (float)result[0]["daily_rate"], status);
        }

        public void AddEquipment(Equipment equipment)
        {
            try
            {
                string checkQuery = $"SELECT * FROM equipment_list WHERE equipment_id = {equipment.Id}";
                var checkResult = dbConnector.ExecuteQuery(checkQuery);
                if (checkResult.Count > 0)
                {
                    throw new Exception("Equipment ID already exists");
                }
                string query = $"INSERT INTO equipment_list (equipment_id, equipment_name, description, category_id, daily_rate, status) VALUES ({equipment.Id}, '{equipment.Name}', '{equipment.Description}', {equipment.CategoryId}, {equipment.DailyRate}, '{equipment.Status}')";
                dbConnector.ExecuteCommand(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteEquipment(int id)
        {
            string query = $"DELETE FROM equipment_list WHERE equipment_id = {id}";
            dbConnector.ExecuteCommand(query);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            string query = $"UPDATE equipment_list SET equipment_name = '{equipment.Name}', description = '{equipment.Description}', category_id = {equipment.CategoryId}, daily_rate = {equipment.DailyRate}, status = '{equipment.Status}' WHERE equipment_id = {equipment.Id}";
            dbConnector.ExecuteCommand(query);
        }
    }
}
