using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchOrder.Interfaces;
using LunchOrder.Entity;

namespace LunchOrder.Repositories
{
    public class OrderRepository
    {
        public List<IOrder> FindAllOrdersByDateTime(DateTime pDateTime)
        {
            using (var context = new dbmealsEntities())
            {
                var orders = new List<IOrder>();
                var ordersDb = context.ORDERS.Where(pOrders => pOrders.ORDER_DATE == pDateTime).ToList();

                foreach (var orderDb in ordersDb)
                {
                    orders.Add(new Order(orderDb));
                }

                return orders;
            }
        }

        private static ORDER_ITEMS ConvertMealToOrderItem(IMeal pMeal)
        {
            var orderItem = new ORDER_ITEMS
            {
                NAME = pMeal.MealName,
                PRICE = (double) pMeal.MealPrice
            };

            if (pMeal.AddOns != null && pMeal.AddOns.Any())
            {
                foreach (var mealAddOn in pMeal.AddOns)
                {
                    orderItem.ORDER_ITEMS1.Add(ConvertMealToOrderItem(mealAddOn));
                }
            }

            return orderItem;
        }

        public bool SaveOrder(IOrder pOrder)
        {
            if (pOrder == null)
            {
                return false;
            }

            try
            {
                using (var context = new dbmealsEntities())
                {
                    var order = new ORDER
                    {
                        ORDER_DATE = pOrder.OrderDate,
                        COMMENT = pOrder.Comment,
                        DELIVERY_EMAIL = pOrder.EmailDelivery
                    };

                    foreach (var pOrderMeal in pOrder.Meals)
                    {
                        order.ORDER_ITEMS.Add(ConvertMealToOrderItem(pOrderMeal));
                        order.PRICE += (double) pOrderMeal.CalculateAddOnsPrice();
                    }

                    context.ORDERS.Add(order);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                //todo: logowanie bledow
            }

            return false;
        }
    }
}







