﻿using System;
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
        private string categoryName;
        private double dailyRate;
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

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public double DailyRate
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
            categoryName = "";
            dailyRate = 0;
            status = "";
        }

        public Equipment(int id, string name, string description, string categoryName, double dailyRate, string status)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.categoryName = categoryName;
            this.dailyRate = dailyRate;
            this.status = status;
        }

        public override string ToString()
        {
            return $"Equipment ID: {id}\n" +
                $"Equipment Name: {name}\n" +
                $"Equipment Description: {description}\n" +
                $"Equipment Category: {categoryName}\n" +
                $"Equipment Daily Rate: {dailyRate}\n" +
                $"Equipment Status: {status}";
        }
       
    }
}