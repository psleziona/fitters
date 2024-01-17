using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitters.Models;

namespace Fitters
{
    public class MealProductQuantity : ICalorieCounter
    {
        private Product product;
        private double quantity;
        private double calories;

        public Product Product { get => product; }
        public double Quantity { get => quantity; }

        public MealProductQuantity(Product product, double quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.calories = product.GetCalories() * quantity;
        }

        public void CountCalories()
        {
            calories = product.GetCalories() * quantity;
        }

        public double GetCalories()
        {
            return calories;
        }
    }
}
