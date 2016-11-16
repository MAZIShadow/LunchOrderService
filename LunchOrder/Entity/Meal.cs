using LunchOrder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchOrder.Entity
{
    public class Meal : IMeal
    {
        public long? Id { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public HashSet<IMealAddOn> AddOns { get; set;}
    }
}
