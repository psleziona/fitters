using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class Meal : ICalorieCounter
    {
        private List<MealProductQuantity> products;
        private double calories;

        public double Calories { get => calories; }
        public List<MealProductQuantity> Products { get => products; }
        public double CountCalories()
        {
            /*
            foreach (var product in products)
            {
                calories += product.
            }
            */
            return 0.0;
        }
    }
}
