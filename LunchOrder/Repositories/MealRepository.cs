using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchOrder.Interfaces;
using LunchOrder.Entity;

namespace LunchOrder.Repositories
{
    public class MealRepository
    {
        public List<IMeal> FindAllMealByGroupId(long pGroupId)
        {
            using (dbmealsEntities context = new dbmealsEntities())
            {
                List<MEAL> mealsDb = context.MEALS.Where(pMeal => pMeal.FK_MEAL_GROUP == pGroupId).ToList();
                List<IMeal> meals = new List<IMeal>();

                foreach(MEAL mealDb in mealsDb)
                {
                    meals.Add(new Meal(mealDb));
                }

                return meals;
            }
        }

        public IMeal FindMealById(long pId)
        {
            using (dbmealsEntities context = new dbmealsEntities())
            {
                MEAL mealDb = context.MEALS.FirstOrDefault(pMeal => pMeal.ID == pId);

                return mealDb == null ? null : new Meal(mealDb);
            }
        }
    }
}
