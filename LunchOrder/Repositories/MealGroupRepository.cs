using System.Collections.Generic;
using System.Linq;
using LunchOrder.Interfaces;
using LunchOrder.Entity;

namespace LunchOrder.Repositories
{
    public class MealGroupRepository
    {
        public List<IMealGroup> FindAllMainMealGroups()
        {
            using (dbmealsEntities context = new dbmealsEntities())
            {
                var mealGroupsDb = context.MEAL_GROUPS.Where(pMealGroup => pMealGroup.MEAL_GROUPS2 == null).ToList();
                var mealGroups = new List<IMealGroup>();

                foreach(var mealGroupDb in mealGroupsDb)
                {
                    mealGroups.Add(Convertes.ConverterEntityDbToObject.ConvertMealGroupDbToMealGroup(mealGroupDb));
                }

                return mealGroups;
            }
        }

        public List<IMealGroup> FindSubGroupByMainGroupName(string pMealGroupName)
        {
            using (var context = new dbmealsEntities())
            {
                var mealGroupsDb =
                    context.MEAL_GROUPS.Where(
                            pMealGroup => pMealGroup.MEAL_GROUPS2 != null && pMealGroup.MEAL_GROUPS2.NAME == pMealGroupName)
                        .ToList();
                var mealGroups = new List<IMealGroup>();

                foreach (var mealGroupDb in mealGroupsDb)
                {
                    mealGroups.Add(Convertes.ConverterEntityDbToObject.ConvertMealGroupDbToMealGroup(mealGroupDb));
                }

                return mealGroups;
            }
        }

        public IMealGroup FindGroupById(long pId)
        {
            using (var context = new dbmealsEntities())
            {
                var mealGroupDb = context.MEAL_GROUPS.FirstOrDefault(pMealGroup => pMealGroup.ID == pId);

                return mealGroupDb == null
                    ? null
                    : Convertes.ConverterEntityDbToObject.ConvertMealGroupDbToMealGroup(mealGroupDb);
            }
        }
    }
}
