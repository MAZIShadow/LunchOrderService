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

        public AddOnFormLogic(IMealGroup pMealGroup)
        {
            if (pMealGroup == null)
            {
                throw new ArgumentNullException("Meal Group is null");
            }

            _mealGroupRepository = new MealGroupRepository();
            _mealRepository = new MealRepository();
            _mainGroup = pMealGroup;
        }
        
        public List<IMealGroup> GetSubGroups()
        {
            return _mealGroupRepository.FindSubGroupByMainGroupName(_mainGroup.GroupName);
        }

        public List<IMeal> GetSubMealsBySubGroupId(string pGroupName)
        {
            return _mealRepository.FindAllMealByGroupName(pGroupName);
        }
    }
}
