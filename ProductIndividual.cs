using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitters
{
    internal class ProductIndividual : Product, ICalorieCounter
    {
        public ProductIndividual(string name, double proteins, double carbons, double fats) : base(name, proteins, carbons, fats)
        {

        }

        public double CountCalories()
        {
            throw new NotImplementedException();
        }
    }
}
