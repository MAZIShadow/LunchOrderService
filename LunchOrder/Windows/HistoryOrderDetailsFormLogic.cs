using System;
using System.Linq;
using System.Windows.Forms;
using LunchOrder.Entity;
using LunchOrder.Interfaces;
using LunchOrder.Repositories;

namespace LunchOrder.Windows
{
    internal class HistoryOrderDetailsFormLogic
    {
        private readonly IOrder _order;
        private readonly OrderItemRepository _orderItemRepository;

        public HistoryOrderDetailsFormLogic(IOrder pOrder)
        {
            _order = pOrder;
            _orderItemRepository = new OrderItemRepository();
        }

        public TreeNode ReloadTreeView()
        {
            var root = new TreeNode("Zamówienie");

            var list = _orderItemRepository.FindAllOrderItemByOrderId(_order.Id.Value);

            foreach (var meal in list)
            {
                root.Nodes.Add(AddSubOrderedItems(meal));
            }

            return root;
        }

        private static TreeNode AddSubOrderedItems(IMeal pMeal)
        {
            var mealNode = new TreeNode($"{pMeal.MealName} ({pMeal.MealPrice} zł)");

            if (pMeal.AddOns == null || !pMeal.AddOns.Any())
            {
                return mealNode;
            }

            foreach (var mealAddOn in pMeal.AddOns)
            {
                mealNode.Nodes.Add(AddSubOrderedItems(mealAddOn));
            }

            return mealNode;
        }

        public DateTime OrderDateTime => _order.OrderDate;
        public string OrderEmail => _order.EmailDelivery;
        public string OrderPrice => $"{_order.OrderPrice:,00} zł";
        public string OrderComments => _order.Comment;
    }
}