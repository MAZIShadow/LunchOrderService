using LunchOrder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder.Entity
{
    public class MealAddOn : IMealAddOn
    {
        public long? Id { get; set; }
        public string MealAddOnName { get; set; }
        public decimal MealAddOnPrice { get; set; }
    }
}
