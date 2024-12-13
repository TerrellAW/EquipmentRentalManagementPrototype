using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRentalManagementPrototype.domain;


namespace EquipmentRentalManagementPrototype.database
{
    internal class CategoryRepository
    {
        private DBconnector dbConnector;

        public CategoryRepository()
        {
            dbConnector = new DBconnector();
        }

        public List<Category> GetAllCategories()
        {
            string query = "SELECT * FROM category_list";
            var result = dbConnector.ExecuteQuery(query);

            List<Category> categories = new List<Category>();
            foreach (var row in result)
            {
                categories.Add(new Category((int)row["category_id"], (string)row["category_name"]));
            }
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            string query = $"SELECT * FROM category_list WHERE category_id = {id}";
            var result = dbConnector.ExecuteQuery(query);
            if (result.Count == 0)
            {
                return null;
            }
            return new Category((int)result[0]["category_id"], (string)result[0]["category_name"]);
        }

        public void AddCategory(Category category)
        {
            try
            {
                string checkQuery = $"SELECT * FROM category_list WHERE category_id = {category.Id}";
                var checkResult = dbConnector.ExecuteQuery(checkQuery);
                if (checkResult.Count > 0)
                {
                   throw new Exception("Category ID already exists");
                }
                string query = $"INSERT INTO category_list (category_id, category_name) VALUES ({category.Id}, '{category.Name}')";
                dbConnector.ExecuteCommand(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void DeleteCategory(int id)
        {
            string query = $"DELETE FROM category_list WHERE category_id = {id}";
            dbConnector.ExecuteCommand(query);
        }

        public List<Dictionary<string, object>> GetItemsByCategory()
        {
            string query = "SELECT category_id, equipment_name FROM equipment_list";
            return dbConnector.ExecuteQuery(query);
        }
    }
}
