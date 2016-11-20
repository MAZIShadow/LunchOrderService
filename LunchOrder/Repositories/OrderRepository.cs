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
            return FindAllOrdersByDateTimes(pDateTime, pDateTime);
        }

        public List<IOrder> FindAllOrdersByDateTimes(DateTime pFromDateTime, DateTime pToDateTime)
        {
            using (var context = new dbmealsEntities())
            {
                var from = new DateTime(pFromDateTime.Year, pFromDateTime.Month, pFromDateTime.Day);
                var to = new DateTime(pToDateTime.Year, pToDateTime.Month, pToDateTime.Day).AddDays(1).AddSeconds(-1);
                var orders = new List<IOrder>();
                var ordersDb =
                    context.ORDERS.Where(pOrders => pOrders.ORDER_DATE >= from && pOrders.ORDER_DATE <= to).ToList();

                foreach (var orderDb in ordersDb)
                {
                    orders.Add(new Order(orderDb));
                }

                return orders;
            }
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
                        order.ORDER_ITEMS.Add(Convertes.ConverterObjectToEntityDb.ConvertMealToOrderItemDb(pOrderMeal));
                        order.PRICE += (double) (pOrderMeal.CalculateAddOnsPrice() + pOrderMeal.MealPrice);
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







