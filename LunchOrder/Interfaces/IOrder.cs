using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder.Interfaces
{
    public interface IOrder
    {
        long? Id { get; set; }
        DateTime OrderDate { get; set; }
        List<IMeal> Meals { get; set; }
        decimal OrderPrice { get; set; }
        string EmailDelivery { get; set; }
        string Comment { get; set; }

        void AddMeal(IMeal pMeal);
        void DeleteMeal(IMeal pMeal);
        decimal CalculatePrice();
    }
}
