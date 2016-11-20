using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchOrder.Entity;
using LunchOrder.Interfaces;

namespace LunchOrder.Convertes
{
    public static class ConverterEntityDbToObject
    {
        public static Meal ConvertMealDbToMeal(MEAL pMealDb)
        {
            return new Meal()
            {
                Id = pMealDb.ID <= 0 ? (long?)null : pMealDb.ID,
                MealName = pMealDb.NAME,
                MealPrice = (decimal)pMealDb.PRICE,
                MealGroup = pMealDb.MEAL_GROUPS != null ? ConvertMealGroupDbToMealGroup(pMealDb.MEAL_GROUPS) : null
            };
        }

        public static Meal ConvertMealDbToMeal(ORDER_ITEMS pOrderItem)
        {
            return new Meal()
            {
                Id = pOrderItem.ID <= 0 ? (long?)null : pOrderItem.ID,
                MealName = pOrderItem.NAME,
                MealPrice = (decimal)pOrderItem.PRICE,
            };
        }

        public static MealGroup ConvertMealGroupDbToMealGroup(MEAL_GROUPS pMealGroupDb)
        {
            return new MealGroup(pMealGroupDb.ID <= 0 ? (long?)null : pMealGroupDb.ID, pMealGroupDb.NAME,
                pMealGroupDb.MEAL_GROUPS2 != null ? ConvertMealGroupDbToMealGroup(pMealGroupDb.MEAL_GROUPS2) : null);
        }
    }
}
