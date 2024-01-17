using Fitters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class DayMeals
    {
        private List<Meal> meals;
        
        public DayMeals()
        {
            meals = new List<Meal>
            {
                new Breakfast(),
                new Brunch(),
                new Lunch(),
                new AfternoonTea(),
                new Dinner()
            };
        }


        public double GetEatenCalories()
        {
            return meals.Aggregate(0.0, (total, meal) => total + meal.GetCalories());
        }

        public int GetEatenMealsNumber()
        {
            return meals.Where(meal => meal.GetCalories() > 0).Count();
        }

    }
}
