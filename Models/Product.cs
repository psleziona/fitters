using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters.Models
{
    abstract public class Product : ICalorieCounter
    {
        private string name;
        private double proteins;
        private double carbons;
        private double fats;
        private double calories;

        public string Name { get => name; set => name = value; }
        public double Proteins { get => proteins; set => proteins = value; }
        public double Carbons { get => carbons; set => carbons = value; }
        public double Fats { get => fats; set => fats = value; }

        public Product(string name, double proteins, double carbons, double fats)
        {
            Name = name;
            Proteins = proteins;
            Carbons = carbons;
            Fats = fats;
            CountCalories();
        }


        public void CountCalories()
        {
            calories = 4 * proteins + 4 * carbons + 9 * fats;
        }

        public double GetCalories()
        {
            return calories;
        }
    }
}
