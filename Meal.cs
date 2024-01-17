﻿using System;
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

        public double GetCalories()
        {
            return calories;
        }

        public void CountCalories()
        {
            foreach (MealProductQuantity product in products)
            {
                calories += product.CountCalories();
            }
        }
    }
}
