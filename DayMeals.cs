using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class DayMeals
    {
        private Meal? breakfast;
        private Meal? brunch;
        private Meal? lunch;
        private Meal? afternoonTea;
        private Meal? dinner;

        public Meal Breakfast { get => breakfast; }
        public Meal Brunch {  get => brunch; }
        public Meal Lunch { get => lunch; }
        public Meal AfternoonTea { get => afternoonTea; }
        public Meal Dinner {  get => dinner; }


        public double GetEatenCalories()
        {
            double total = 0;
            if (breakfast != null)
            {
                total += breakfast.Calories;
            }
            if (brunch != null)
            {
                total += brunch.Calories;
            }
            if (afternoonTea != null)
            {
                total += afternoonTea.Calories;
            }
            if (dinner != null)
            {
                total += dinner.Calories;
            }
            if(lunch != null)
            {
                total += lunch.Calories;
            }
            return total;
        }

        public int GetEatenMealsNumber()
        {
            int total = 0;
            if (breakfast != null)
            {
                total++;
            }
            if (brunch != null)
            {
                total++;
            }
            if (afternoonTea != null)
            {
                total++;
            }
            if (dinner != null)
            {
                total++;
            }
            if (lunch != null)
            {
                total++;
            }
            return total;
        }

    }
}
