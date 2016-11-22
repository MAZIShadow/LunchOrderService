using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchOrder.Interfaces;

namespace LunchOrder.Entity
{
    public class MealGroup : IMealGroup
    {
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

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            MealGroup mealGroup = obj as MealGroup;

            if (mealGroup == null)
            {
                return false;
            }

            if (this.ParentMealGroup == null)
            {
                if (mealGroup.ParentMealGroup != null)
                {
                    return false;
                }
            }
            else if (!this.ParentMealGroup.Equals(mealGroup.ParentMealGroup))
            {
                return false;
            }

            return mealGroup.GroupName == this.GroupName;
        }

        public override int GetHashCode()
        {
            int groupHashCode = this.ParentMealGroup == null ? 1 : this.ParentMealGroup.GetHashCode();

            return this.GroupName.GetHashCode() ^ groupHashCode;
        }
    }
}
