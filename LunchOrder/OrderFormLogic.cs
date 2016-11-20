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
        public IOrder Order { get; private set; }
        private readonly MealGroupRepository _mealGroupRepository;
        private readonly MealRepository _mealRepository;

        public OrderFormLogic()
        {
            _mealGroupRepository = new MealGroupRepository();
            _mealRepository = new MealRepository();
            ResetOrder();
        }

        public bool IsOrderHasMeals()
        {
            return Order.Meals.Any();
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
            var root = new TreeNode("Zamówienie") { Tag = Order };

            foreach (var meal in Order.Meals)
            {
                root.Nodes.Add(AddMeals(meal));
            }

            return root;
        }

        private static TreeNode AddMeals(IMeal pMeal)
        {
            var mealNode = new TreeNode($"{pMeal.MealName} ({pMeal.MealPrice} zł)")
            {
                Tag = pMeal,
            };

            if (pMeal.AddOns == null || !pMeal.AddOns.Any())
            {
                return mealNode;
            }

            foreach (var mealAddOn in pMeal.AddOns)
            {
                mealNode.Nodes.Add(AddMeals(mealAddOn));
            }

            return mealNode;
        }

        public bool GroupHasSubGroups(IMealGroup pMealGroup)
        {
            return pMealGroup != null && _mealGroupRepository.FindSubGroupByMainGroupName(pMealGroup.GroupName).Any();
        }
    }
}