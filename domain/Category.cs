using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentRentalManagementPrototype.domain
{
    internal class Category
    {
        private int id;
        private string name;

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

        public Category() 
        {
            id = 0;
            name = "";
        }

        public Category(int id, string name) 
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Category ID: {id}\n" +
                $"Category Name: {name}";
        }

    }
}
