using LunchOrder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchOrder.Entity
{
    public class Meal : IMeal
    {
        public Meal()
        {
            AddOns = new HashSet<IMeal>();
        }

        public Meal(string pMealName, decimal pPrice) : this(pMealName, pPrice, null)
        {
        }

        public Meal(string pMealName, decimal pPrice, IMealGroup pMealGroup) : this()
        {
            this.MealName = pMealName;
            this.MealPrice = pPrice;
            this.MealGroup = pMealGroup;
        }

        public long? Id { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public IMealGroup MealGroup { get; set; }
        public HashSet<IMeal> AddOns { get; set; }

        public decimal CalculateAddOnsPrice()
        {
            return AddOns.Sum(pAddOn => pAddOn.MealPrice);
        }

        public override string ToString()
        {
            return $"{MealName} [{MealPrice,0} zł]";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.MealName.GetHashCode() ^ this.MealPrice.GetHashCode();
        }
    }
}
