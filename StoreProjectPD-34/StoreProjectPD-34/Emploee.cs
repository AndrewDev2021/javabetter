﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProjectPD_34
{
    class Emploee : Person, IId
    {
        private static int counter = 1;

        public int Id { get; set; }

        public Emploee(String Name, String SurName, int Age) : base(Name, SurName, Age)
        {
            this.Id = counter++;
        }

        public override string ToString()
        {
            return String.Format(Id + " " + base.ToString());
        }
    }
}
