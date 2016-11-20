using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchOrder.Interfaces;

namespace LunchOrder.Repositories
{
    public class OrderItemRepository
    {
        public List<IMeal> FindAllOrderItemByOrderId(long pOrderId)
        {
            using (var context = new dbmealsEntities())
            {
                var orders = new List<IMeal>();
                var orderItemsDb =
                    context.ORDER_ITEMS.Where(pOrderItem => pOrderItem.ORDER.ID == pOrderId && pOrderItem.ORDER_ITEMS2 == null).ToList();

                foreach (var orderItemDb in orderItemsDb)
                {
                    orders.Add(GetOrderItem(orderItemDb));
                    
                }

                return orders;
            }
        }

        private static IMeal GetOrderItem(ORDER_ITEMS pOrderItemDb)
        {
            var meal = Convertes.ConverterEntityDbToObject.ConvertMealDbToMeal(pOrderItemDb);

            if (pOrderItemDb.ORDER_ITEMS1.Any())
            {
                foreach (var orderItemDb in pOrderItemDb.ORDER_ITEMS1)
                {
                    meal.AddOns.Add(GetOrderItem(orderItemDb));
                }
            }

            return meal;
        }
    }
}
