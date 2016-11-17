using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchOrder.Interfaces
{
    public interface IMeal
    {
        long? Id { get; set; }
        string MealName { get; set; }
        decimal MealPrice { get; set; }
        HashSet<IMeal> AddOns { get; set; }
        IMealGroup MealGroup { get; set; }
        decimal CalculateAddOnsPrice();
    }
}
