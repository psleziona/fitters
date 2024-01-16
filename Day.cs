using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class Day
    {
        private DateTime date;
        private DayMeals meals;
        private List<UserActivity> activities;
        private UserInformation information;

        public DateTime Date { get => date; }
        public DayMeals Meals { get => meals; }

        public Day()
        {
            date = DateTime.Now;
        }

        public Day(UserInformation information)
        {
            this.information = information;
            date = DateTime.Now;
        }



        public int GetEatenMealsNumber()
        {
            return meals.GetEatenMealsNumber();
        }

        public double GetEatenCalories()
        {
            return meals.GetEatenCalories();
        }

        public double GetBurnedCalories()
        {
            return activities.Aggregate(0.0, (total, next) => total + next.BurnedCalories);
        }
    }
}
