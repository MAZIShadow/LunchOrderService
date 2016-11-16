using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder.Interfaces
{
    public interface IMeal
    {
        long? Id { get; set; }
        string MealName { get; set; }
        decimal MealPrice { get; set; }
        HashSet<IMealAddOn> AddOns { get; set; }
    }
}
