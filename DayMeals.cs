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
        public Breakfast Breakfast { get => (Breakfast)meals.First(m => m.GetType() == typeof(Breakfast)); }
        public Brunch Brunch { get => (Brunch)meals.First(m => m.GetType() == typeof(Brunch)); }
        public Lunch Lunch { get => (Lunch)meals.First(m => m.GetType() == typeof(Lunch)); }
        public AfternoonTea AfternoonTea { get => (AfternoonTea)meals.First(m => m.GetType() == typeof(AfternoonTea)); }
        public Dinner Dinner { get => (Dinner)meals.First(m => m.GetType() == typeof(Dinner)); }

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

        public void AddProductToMeal(MealProductQuantity mealProduct, Type mealType)
        {
            meals.First(m => m.GetType() == mealType).AddProduct(mealProduct);
        }

    }
}
