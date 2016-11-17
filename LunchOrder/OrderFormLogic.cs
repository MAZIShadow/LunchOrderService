using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder
{
    class OrderFormLogic
    {
        private Entity.Order _order;
        private MealGroupRepository _mealGroupRepository;
        private MealRepository _mealRepository;

        public OrderFormLogic()
        {
            _mealGroupRepository = new MealGroupRepository();
            _mealRepository = new MealRepository();
            ResetOrder();
        }

        public void ResetOrder()
        {
            _order = new Entity.Order();
        }

        public void AddMeal(IMeal pMeal)
        {
            _order.AddMeal(pMeal);
        }

        public void RemoveMeal(IMeal pMeal)
        {
            _order.DeleteMeal(pMeal);
        }

        public decimal OrderPrice()
        {
            return _order.CalculatePrice();
        }

        public List<IMealGroup> GetMainGroups()
        {
            return _mealGroupRepository.FindAllMainMealGroups();
        }

        public List<IMeal> GetMealsByGroupId(long pId)
        {
            return _mealRepository.FindAllMealByGroupId(pId);
        }

        public TreeNode ReloadTreeView()
        {
            TreeNode root = new TreeNode("Zamówienie");

            foreach (IMeal meal in _order.Meals)
            {
                TreeNode mealNode = new TreeNode(string.Format("{0} ({1} zł)", meal.MealName, meal.MealPrice));
                mealNode.Tag = meal;
                root.Nodes.Add(mealNode);

                foreach (IMeal mealAddOn in meal.AddOns)
                {
                    TreeNode mealAddOnNode = new TreeNode(string.Format("{0} ({1} zł)", mealAddOn.MealName, mealAddOn.MealPrice));
                    mealAddOnNode.Tag = mealAddOn;
                    mealNode.Nodes.Add(mealAddOnNode);
                }
            }

            return root;
        }
    }
}