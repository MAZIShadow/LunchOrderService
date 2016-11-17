using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchOrder.Interfaces
{
    public interface IMealGroup
    {
        long? Id { get; set; }
        string GroupName { get; set; }
        IMealGroup ParentMealGroup { get; set; }
    }
}
