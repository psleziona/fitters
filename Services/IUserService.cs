using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Services
{
    public interface IUserService
    {
        public void AuthUser(User user);
        public Day GetDayInformation(DateTime date);
        public void AddProductToMeal(DateTime date, MealProductQuantity mealProduct, Type mealType);
        public void AddUserActivity(DateTime date, UserActivity activity);
    }
}
