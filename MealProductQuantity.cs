using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public class MealProductQuantity : ICalorieCounter
    {
        private Product product;
        private double quantity;
        private double calories;

        public Product Product { get => product; }
        public double Quantity { get => quantity; }

        public double CountCalories()
        {
            return 5.0;
        }
    }
}
