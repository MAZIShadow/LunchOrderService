using System;
using System.Collections.Generic;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder.Windows
{
    internal class AddOnFormLogic
    {
        private readonly MealGroupRepository _mealGroupRepository;
        private readonly MealRepository _mealRepository;
        private readonly IMealGroup _mainGroup;
        private readonly HashSet<IMeal> _meals;

        public AddOnFormLogic(IMealGroup pMealGroup)
        {
            if (pMealGroup == null)
            {
                throw new ArgumentNullException("Meal Group is null");
            }

            _mealGroupRepository = new MealGroupRepository();
            _mealRepository = new MealRepository();
            _mainGroup = pMealGroup;
            _meals = new HashSet<IMeal>();
        }
        
        public List<IMealGroup> GetSubGroups()
        {
            return _mealGroupRepository.FindSubGroupByMainGroupName(_mainGroup.GroupName);
        }

        public List<IMeal> GetSubMealsBySubGroupId(string pGroupName)
        {
            return _mealRepository.FindAllMealByGroupName(pGroupName);
        }

        public void AddMeal(IMeal pMeal)
        {
            _meals.Add(pMeal);
        }

        public void RemoveMeal(IMeal pMeal)
        {
            _meals.Remove(pMeal);
        }

        public HashSet<IMeal> GetSelectedMeals()
        {
            return _meals;
        }
    }
}
