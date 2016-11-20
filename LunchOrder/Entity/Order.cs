using LunchOrder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchOrder.Entity
{
    public class Order : IOrder
    {
        public Order()
        {
            Meals = new List<IMeal>();
        }

        public Order(ORDER pOrderDb) : this()
        {
            Id = pOrderDb.ID <= 0 ? (long?)null : pOrderDb.ID;
            OrderDate = pOrderDb.ORDER_DATE;
            Comment = pOrderDb.COMMENT;
            EmailDelivery = pOrderDb.DELIVERY_EMAIL;
            OrderPrice = (decimal) pOrderDb.PRICE;
            


            //GroupName = pOrderDb.NAME;

            //if (pOrderDb.MEAL_GROUPS2 != null)
            //{
            //    ParentMealGroup = new MealGroup(pOrderDb.MEAL_GROUPS2);
            //}
        }

        public long? Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<IMeal> Meals { get; set; }
        public decimal OrderPrice { get; set; }
        public string EmailDelivery { get; set; }
        public string Comment { get; set; }

        public void AddMeal(IMeal pMeal)
        {
            Meals.Add(pMeal);
        }

        public void DeleteMeal(IMeal pMeal)
        {
            Meals.Remove(pMeal);
        }

        public decimal CalculatePrice()
        {
            decimal sum = 0;

            foreach (IMeal meal in Meals)
            {
                if (meal.AddOns != null)
                {
                    sum += meal.CalculateAddOnsPrice();
                }

                sum += meal.MealPrice;
            }

            return sum;
        }
    }
}
