using System.Collections.Generic;
using System.Linq;
using LunchOrder.Interfaces;
using LunchOrder.Entity;

namespace LunchOrder.Repositories
{
    public class MealRepository
    {
        public List<IMeal> FindAllMealByGroupName(string pGroupName)
        {
            using (var context = new dbmealsEntities())
            {
                var meals = new List<IMeal>();
                var mealsDb = context.MEALS.Where(pMeal => pMeal.MEAL_GROUPS != null && pMeal.MEAL_GROUPS.NAME == pGroupName).ToList();

                foreach (var mealDb in mealsDb)
                {
                    meals.Add(Convertes.ConverterEntityDbToObject.ConvertMealDbToMeal(mealDb));
                }

                return meals;
            }
        }

        public IMeal FindMealById(long pId)
        {
            using (var context = new dbmealsEntities())
            {
                var mealDb = context.MEALS.FirstOrDefault(pMeal => pMeal.ID == pId);

                return mealDb == null ? null : Convertes.ConverterEntityDbToObject.ConvertMealDbToMeal(mealDb);
            }
        }
    }
}
