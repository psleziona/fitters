using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Services
{
    public class UserService : IUserService
    {
        User activeUser;

        public void AddProductToMeal(DateTime date, MealProductQuantity mealProduct, Type mealType)
        {
            Day day = GetDayInformation(date);
            day.Meals.AddProductToMeal(mealProduct, mealType);
            activeUser.Calendar.Days = activeUser.Calendar.Days.Where(d => d.Date != date).ToList();
            activeUser.Calendar.Days.Add(day);
            SaveUserData();
        }

        public void AddUserActivity(DateTime date, UserActivity activity)
        {
            Day day = GetDayInformation(date);
            day.AddUserActivity(activity);
            activeUser.Calendar.Days = activeUser.Calendar.Days.Where(d => d.Date != date).ToList();
            activeUser.Calendar.Days.Add(day);
            SaveUserData();
        }

        public void AuthUser(User user)
        {
            activeUser = user;
        }

        public Day GetDayInformation(DateTime date)
        {
            return activeUser.GetUserDay(date);
        }

        public List<Day> GetDayList(DateTime start, DateTime end)
        {
            return activeUser.Calendar.Days.Where(d => d.Date >= start && d.Date <= end).ToList();
        }

        private void SaveUserData()
        {
            FileUtility.WriteDateToFile(activeUser, "users/" + activeUser.Login);
        }
    }
}
