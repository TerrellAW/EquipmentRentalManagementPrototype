using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentRentalManagementPrototype.domain
{
    internal class Equipment
    {
        private int id;
        private string name;
        private string description;
        private int categoryId;
        private float dailyRate;
        private string status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public float DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Equipment()
        {
            id = 0;
            name = "";
            description = "";
            categoryId = 0;
            dailyRate = 0;
            status = "";
        }

        public Equipment(int id, string name, string description, int categoryId, float dailyRate, string status)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.categoryId = categoryId;
            this.dailyRate = dailyRate;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{id} - {name} - {description} \n" +
                $"\tCategory: {categoryId}, " +
                $"Daily Rate: {dailyRate}, " +
                $"Status: {status} ";
        }
       
    }
}
