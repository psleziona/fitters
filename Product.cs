using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    abstract internal class Product
    {
        private string name;
        private double proteins;
        private double carbons;
        private double fats;
        private double calories;

        protected string Name { get => name; set => name = value; }
        protected double Proteins { get => proteins; set => proteins = value; }
        protected double Carbons { get => carbons; set => carbons = value; }
        protected double Fats { get => fats; set => fats = value; }
        protected double Calories { get => calories; set => calories = value; }

        public Product(string name, double proteins, double carbons, double fats)
        {
            this.Name = name;
            this.Proteins = proteins;
            this.Carbons = carbons;
            this.Fats = fats;
            countCalories();
        }
        

        private void countCalories()
        {
            this.Calories = 4 * this.Proteins + 4 * this.Carbons + 9 * this.Fats;
        }
    }
}
