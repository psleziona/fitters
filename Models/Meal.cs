using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    public abstract class Meal : ICalorieCounter
    {
        private List<MealProductQuantity> products;
        private double calories;

        public List<MealProductQuantity> Products { get => products; }
        public double Calories { get => calories; set => calories = value; }

        public Meal() 
        {
            products = new List<MealProductQuantity>();
        }

        public double GetMealProteins()
        {
            return products.Aggregate(0.0, (total, p) => total + p.Product.Proteins * p.Quantity);
        }

        public double GetMealFats()
        {
            return products.Aggregate(0.0, (total, p) => total + p.Product.Fats * p.Quantity);
        }

        public double GetMealCarbons()
        {
            return products.Aggregate(0.0, (total, p) => total + p.Product.Carbons * p.Quantity);
        }

        public double GetCalories()
        {
            return calories;
        }

        public void CountCalories()
        {
            calories = products.Aggregate(0.0, (total, p) => total + p.GetCalories());
        }

        public void AddProduct(MealProductQuantity product)
        {
            products.Add(product);
            CountCalories();
        }
    }
}
