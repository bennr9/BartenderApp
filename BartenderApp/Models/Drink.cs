using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BartenderApp.Models
{
    public class Drink
    {
        public int DrinkID { get; set; }
        public string DrinkName { get; set; }
        public int Quantity { get; set; }
    }

    public class DrinkDBContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
    }
}