using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LunchOrder.Interfaces;
using LunchOrder.Entity;

namespace LunchOrder.Repositories
{
    public class MealRepository
    {
        private static List<IMeal> _meals;
        private static MealGroupRepository _repo = new MealGroupRepository();

        static MealRepository()
        {
            Meal dish1 = new Meal("Margheritta", 20, _repo.FindGroupById(1));
            Meal dish2 = new Meal("Vegetariana", 22, _repo.FindGroupById(1));
            Meal dish3 = new Meal("Tosca", 25, _repo.FindGroupById(1));
            Meal dish4 = new Meal("Venecia", 22, _repo.FindGroupById(1));

            Meal dish5 = new Meal("Podwójny ser", 2, _repo.FindGroupById(2));
            Meal dish6 = new Meal("Salami", 2, _repo.FindGroupById(2));
            Meal dish7 = new Meal("Szynka", 2, _repo.FindGroupById(2));
            Meal dish8 = new Meal("Pieczarki", 2, _repo.FindGroupById(2));

            Meal dish9 = new Meal("Schabowy z frytkami/ryżem/ziemniakami", 30, _repo.FindGroupById(3));
            Meal dish10 = new Meal("Ryba z frytkami", 28, _repo.FindGroupById(3));
            Meal dish11 = new Meal("Placek po węgiersku", 27, _repo.FindGroupById(3));

            Meal dish12 = new Meal("Bar sałatkowy", 5, _repo.FindGroupById(4));
            Meal dish13 = new Meal("Zestaw sosów", 6, _repo.FindGroupById(4));

            Meal dish14 = new Meal("Pomidorowa", 12, _repo.FindGroupById(5));
            Meal dish15 = new Meal("Rosół", 10, _repo.FindGroupById(5));

            Meal dish16 = new Meal("Kawa", 5, _repo.FindGroupById(6));
            Meal dish17 = new Meal("Herbata", 5, _repo.FindGroupById(6));
            Meal dish18 = new Meal("Cola", 5, _repo.FindGroupById(6));

            _meals = new List<IMeal> { dish1, dish2, dish3, dish4, dish5, dish6, dish7, dish8, dish9, dish10, dish11, dish12, dish13, dish14, dish15, dish16, dish17, dish18 };
        }

        public List<IMeal> FindAllMeals()
        {
            return _meals;
        }

        public List<IMeal> FindAllMealByGroupId(long pGroupId)
        {
            return FindAllMeals().Where(pGroup => pGroup.MealGroup.Id == pGroupId).ToList();
        }

        public IMeal FindMealById(long pId)
        {
            return FindAllMeals().FirstOrDefault(pMeal => pMeal.Id == pId);
        }
    }
}
