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
        private static List<IMealGroup> mainGroups;

        static MealGroupRepository()
        {
            MealGroup pizzasGroup = new MealGroup(1, "Pizza", null);
            MealGroup pizzaAddonsGroup = new MealGroup(2, "Dodatki do pizzy", pizzasGroup);
            MealGroup mainMealsGroup = new MealGroup(3, "Dania główne", null);
            MealGroup mainMealAddonsGroup = new MealGroup(4, "Dodatki do dań głównych", mainMealsGroup);
            MealGroup soupsGroup = new MealGroup(5, "Zupy", null);
            MealGroup drinksGroup = new MealGroup(6, "Napoje", null);

            mainGroups = new List<IMealGroup> { pizzasGroup, pizzaAddonsGroup, mainMealsGroup, mainMealAddonsGroup, soupsGroup, drinksGroup };
        }

        public List<IMealGroup> FindAllMealGroups()
        {
            return mainGroups;
        }

        public List<IMealGroup> FindAllMainMealGroups()
        {
            return FindAllMealGroups().Where(pMealGroup => pMealGroup.ParentMealGroup == null).ToList();
        }

        public List<IMealGroup> FindSubGroupByMainGroupName(string pMealGroupName)
        {
            return FindAllMealGroups().Where(pGroup => pGroup.GroupName == pMealGroupName).Select(pGroup => pGroup.ParentMealGroup).ToList();
        }

        public IMealGroup FindGroupById(long pId)
        {
            return FindAllMealGroups().FirstOrDefault(pGroup => pGroup.Id == pId);
        }
    }
}
