using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchOrder.Interfaces;

namespace LunchOrder.Entity
{
    public class MealGroup : IMealGroup
    {
        public MealGroup(MEAL_GROUPS pMealGroups)
        {
            Id = pMealGroups.ID <= 0 ? (long?)null : pMealGroups.ID;
            GroupName = pMealGroups.NAME;
            
            if (pMealGroups.MEAL_GROUPS2 != null)
            {
                ParentMealGroup = new MealGroup(pMealGroups.MEAL_GROUPS2);
            }
        }

        public MealGroup(long? pId, string pGroupName, IMealGroup pParentMealGroup)
        {
            this.Id = pId;
            this.GroupName = pGroupName;
            this.ParentMealGroup = pParentMealGroup;
        }

        public long? Id { get; set; }
        public string GroupName { get; set; }

        public IMealGroup ParentMealGroup { get; set; }

        public override string ToString()
        {
            return this.GroupName;
        }
    }
}
