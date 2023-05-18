﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMachine.Data
{
    [Table("Drinks")]
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
