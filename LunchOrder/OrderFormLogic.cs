using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder
{
    internal class OrderFormLogic
    {
        public Entity.Order Order { get; private set; }
        private readonly MealGroupRepository _mealGroupRepository;
        private readonly MealRepository _mealRepository;

        public OrderFormLogic()
        {
            _mealGroupRepository = new MealGroupRepository();
            _mealRepository = new MealRepository();
            ResetOrder();
        }

        public void ResetOrder()
        {
            Order = new Entity.Order();
        }

        public void AddMeal(IMeal pMeal)
        {
            Order.AddMeal(pMeal);
        }

        public void RemoveMeal(IMeal pMeal)
        {
            Order.DeleteMeal(pMeal);
        }

        public decimal OrderPrice()
        {
            return Order.CalculatePrice();
        }

        public List<IMealGroup> GetMainGroups()
        {
            return _mealGroupRepository.FindAllMainMealGroups();
        }

        public List<IMeal> GetMealsByGroupName(string pGroupName)
        {
            return _mealRepository.FindAllMealByGroupName(pGroupName);
        }

        public TreeNode ReloadTreeView()
        {
            var root = new TreeNode("Zamówienie") {Tag = Order };

            foreach (var meal in Order.Meals)
            {
                var mealNode = new TreeNode($"{meal.MealName} ({meal.MealPrice} zł)") {Tag = meal};
                root.Nodes.Add(mealNode);

                foreach (var mealAddOn in meal.AddOns)
                {
                    var mealAddOnNode = new TreeNode($"{mealAddOn.MealName} ({mealAddOn.MealPrice} zł)")
                    {
                        Tag = mealAddOn
                    };
                    mealNode.Nodes.Add(mealAddOnNode);
                }
            }

            return root;
        }

        public bool GroupHasSubGroups(IMealGroup pMealGroup)
        {
            return pMealGroup != null && _mealGroupRepository.FindSubGroupByMainGroupName(pMealGroup.GroupName).Any();
        }
    }
}