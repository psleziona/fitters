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

        public DateTime Date { get => date; set => date = value; }
        public DayMeals Meals { get => meals; }
        public UserInformation Information { get => information; set => information = value;  }
        public List<UserActivity> Activities {  get => activities; }

        public Day()
        {
            meals = new DayMeals();
            activities = new List<UserActivity>();
        }

        public Day(DateTime date)
        {
            this.date = date;
            meals = new DayMeals();
            activities = new List<UserActivity>();
        }

        public Day(UserInformation information)
        {
            this.information = information;
            date = DateTime.Today;
            meals = new DayMeals();
            activities = new List<UserActivity>();
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

        public double GetDayCaloriesBalance()
        {
            return GetEatenCalories() - GetBurnedCalories();
        }

        public void AddUserActivity(UserActivity userActivity)
        {
            activities.Add(userActivity);
        }

        public double GetEatenProteins()
        {
            return meals.GetEatenProteins();
        }

        public double GetEatenFats()
        {
            return meals.GetEatenFats();
        }

        public double GetEatenCarbons()
        {
            return meals.GetEatenCarbons();
        }
    }
}
