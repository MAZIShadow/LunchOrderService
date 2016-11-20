using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchOrder.Interfaces;

namespace LunchOrder.Convertes
{
    public static class ConverterObjectToEntityDb
    {
        public static ORDER_ITEMS ConvertMealToOrderItemDb(IMeal pMeal)
        {
            var orderItem = new ORDER_ITEMS
            {
                NAME = pMeal.MealName,
                PRICE = (double)pMeal.MealPrice
            };

            if (pMeal.AddOns != null && pMeal.AddOns.Any())
            {
                foreach (var mealAddOn in pMeal.AddOns)
                {
                    orderItem.ORDER_ITEMS1.Add(ConvertMealToOrderItemDb(mealAddOn));
                }
            }

            return orderItem;
        }
    }
}
