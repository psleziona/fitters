using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class MealProductQuantity : ICalorieCounter
    {
        private Product product;
        private double quantity;
        private double calories;
        public double CountCalories()
        {
            throw new NotImplementedException();
        }
    }
}
