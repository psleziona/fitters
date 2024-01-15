using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class DayMeals
    {
        private DateTime date;
        private Meal breakfast;
        private Meal brunch;
        private Meal lunch;
        private Meal afternoonTea;
        private Meal dinner;

        public double GetEatenCalories()
        {
            return 5.0;
        }
    }
}
