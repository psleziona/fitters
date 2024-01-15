using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class Meal : ICalorieCounter
    {
        private List<MealProductQuantity> products;
        private double calories;
        public double CountCalories()
        {
            throw new NotImplementedException();
        }
    }
}
