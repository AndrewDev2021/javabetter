﻿using StoreProjectPD_34.Factories;
using StoreProjectPD_34.Models;
using System;
using System.Text;

namespace StoreProjectPD_34.Database
{
    class DB
    {
        public IDBItem<Emploee> DbEmploee { get; set; }
        public IDBItem<HR> DbHrs { get; set; }

        public DB()
        {
            DbEmploee = new DBItem<Emploee>();
            DbHrs = new DBItem<HR>();
            InitEmploee();
        }

        private void InitEmploee()
        {
            var employees = EmployeeFactory.GetEmploees();
            foreach (var employee in employees)
            {
                DbEmploee.AddItem(employee);
            }
        }
    }
}
