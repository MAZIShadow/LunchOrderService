using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                List<MEAL_GROUPS> mealGroupsDb = context.MEAL_GROUPS.Where(pMealGroup => pMealGroup.MEAL_GROUPS2 == null).ToList();
                List<IMealGroup> mealGroups = new List<IMealGroup>();

                foreach(MEAL_GROUPS mealGroupDb in mealGroupsDb)
                {
                    mealGroups.Add(new MealGroup(mealGroupDb));
                }

                return mealGroups;
            }
        }

        public List<IMealGroup> FindSubGroupByMainGroupName(string pMealGroupName)
        {
            using (dbmealsEntities context = new dbmealsEntities())
            {
                List<MEAL_GROUPS> mealGroupsDb = context.MEAL_GROUPS.Where(pMealGroup => pMealGroup.NAME == pMealGroupName).ToList();
                List<IMealGroup> mealGroups = new List<IMealGroup>();

                foreach (MEAL_GROUPS mealGroupDb in mealGroupsDb)
                {
                    mealGroups.Add(new MealGroup(mealGroupDb));
                }

                return mealGroups;
            }
        }

        public IMealGroup FindGroupById(long pId)
        {
            using (dbmealsEntities context = new dbmealsEntities())
            {
                MEAL_GROUPS mealGroupDb = context.MEAL_GROUPS.FirstOrDefault(pMealGroup => pMealGroup.ID == pId);

                return mealGroupDb == null ? null : new MealGroup(mealGroupDb);
            }
        }
    }
}
