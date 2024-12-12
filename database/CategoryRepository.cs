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
            string query = $"INSERT INTO category_list (category_id, category_name) VALUES ({category.Id}, '{category.Name}')";
            dbConnector.ExecuteCommand(query);
        }

        public void DeleteCategory(int id)
        {
            string query = $"DELETE FROM category_list WHERE category_id = {id}";
            dbConnector.ExecuteCommand(query);
        }
    }
}
